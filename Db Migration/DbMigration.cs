namespace Db_Migration
{
    public partial class DbMigration : Form
    {
        public DbMigration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
          
            string oldDb = txtBoxOldDb.Text;
            string newDb = txtBoxNewDb.Text;

            if (string.IsNullOrWhiteSpace(oldDb) || string.IsNullOrWhiteSpace(newDb))
            {
                MessageBox.Show("Please provide both the old and new database connection strings.", "Warning");
                return;
            }
            progressBarMigration.Value = 0;
            //lblStatus.Text = "Migration in progress...";

            bool migrateAddOn = chckAddOnDocuments.Checked;
            bool migrateGuest = chckGuestDocuments.Checked;
            await Task.Run(() => MigrationUtils.MigrateData(oldDb, newDb, migrateAddOn, migrateGuest, UpdateProgressBar));


            //lblStatus.Text = "Migration Completed!";
        }
        private void UpdateProgressBar(int currentProgress, int totalRecords)
        {
            if (progressBarMigration.InvokeRequired)
            {
                progressBarMigration.Invoke(new Action<int, int>(UpdateProgressBar), currentProgress, totalRecords);
            }
            else
            {
                progressBarMigration.Maximum = totalRecords; // Set the max range
                progressBarMigration.Value = currentProgress; // Update progress
                lblStatus.Text = $"Migrating {currentProgress}/{totalRecords} records";

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}