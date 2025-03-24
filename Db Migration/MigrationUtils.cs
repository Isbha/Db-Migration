using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Migration
{
    public class MigrationUtils
    {
        public static void MigrateData(string oldDb, string newDb, bool migrateAddOn, bool migrateGuest, Action<int,int> updateProgressBar)
        {
            try
            {
                using (SqlConnection oldDbConn = new SqlConnection(oldDb))
                using (SqlConnection newDbConn = new SqlConnection(newDb))
                {
                    oldDbConn.Open();
                    newDbConn.Open();

                    if (migrateAddOn)
                        TransferTable(oldDbConn, newDbConn, "DeskDocumentsTable", updateProgressBar);

                    if (migrateGuest)
                        TransferTable(oldDbConn, newDbConn, "AddOnDocumentsTable", updateProgressBar);
                    TransferTable(oldDbConn, newDbConn, "author", updateProgressBar);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static void TransferTable(SqlConnection oldConn, SqlConnection newConn, string tableName, Action<int,int> updateProgressBar)
        {
            int totalRecords = 0;
            string countQuery = $"SELECT COUNT(*) FROM {tableName}";

            using (SqlCommand countCmd = new SqlCommand(countQuery, oldConn))
            {
                totalRecords = Convert.ToInt32(countCmd.ExecuteScalar());
            }


            string query = $"SELECT * FROM {tableName}";
            using (SqlCommand cmd = new SqlCommand(query, oldConn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    List<string> columnNames = new List<string>();

                    // Get column names dynamically from the reader
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        columnNames.Add(reader.GetName(i));  // Adds column name to the list
                    }

                    string columns = string.Join(", ", columnNames); // e.g., "id, name, birthdate, nationality"
                    string parameters = string.Join(", ", columnNames.Select(col => $"@{col}")); // e.g., "@id, @name, @birthdate, @nationality"
                    int migratedRecords = 0;

                    while (reader.Read()) // Reads each row
                    {
                        try
                        {
                            // Construct dynamic insert query
                            string insertQuery = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})";

                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, newConn))
                            {
                                // Add parameters dynamically
                                foreach (string col in columnNames)
                                {
                                    insertCmd.Parameters.AddWithValue($"@{col}", reader[col]);
                                }

                                insertCmd.ExecuteNonQuery();
                            }
                            migratedRecords++;

                            // Update progress bar
                            updateProgressBar?.Invoke(migratedRecords, totalRecords);  // Update progress
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"{tableName} Error: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}