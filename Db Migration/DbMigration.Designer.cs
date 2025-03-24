namespace Db_Migration
{
    partial class DbMigration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtBoxOldDb = new TextBox();
            lblOldDb = new Label();
            groupBox2 = new GroupBox();
            chckAddOnDocuments = new CheckBox();
            chckGuestDocuments = new CheckBox();
            BtnMigration = new Button();
            progressBarMigration = new ProgressBar();
            errorProvider1 = new ErrorProvider(components);
            lblStatus = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            txtBoxNewDb = new TextBox();
            lblNewDb = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxOldDb);
            groupBox1.Controls.Add(lblOldDb);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(46, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1021, 282);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Database Connections";
            // 
            // txtBoxOldDb
            // 
            txtBoxOldDb.Location = new Point(231, 47);
            txtBoxOldDb.Multiline = true;
            txtBoxOldDb.Name = "txtBoxOldDb";
            txtBoxOldDb.Size = new Size(748, 94);
            txtBoxOldDb.TabIndex = 1;
            txtBoxOldDb.TextChanged += textBox1_TextChanged;
            // 
            // lblOldDb
            // 
            lblOldDb.AutoSize = true;
            lblOldDb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldDb.Location = new Point(32, 50);
            lblOldDb.Name = "lblOldDb";
            lblOldDb.Size = new Size(182, 20);
            lblOldDb.TabIndex = 0;
            lblOldDb.Text = "Old Db Connection String:";
            lblOldDb.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chckAddOnDocuments);
            groupBox2.Controls.Add(chckGuestDocuments);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(46, 319);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(534, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tables to Migrate";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // chckAddOnDocuments
            // 
            chckAddOnDocuments.AutoSize = true;
            chckAddOnDocuments.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chckAddOnDocuments.Location = new Point(238, 58);
            chckAddOnDocuments.Name = "chckAddOnDocuments";
            chckAddOnDocuments.Size = new Size(157, 24);
            chckAddOnDocuments.TabIndex = 1;
            chckAddOnDocuments.Text = "AddOn Documents";
            chckAddOnDocuments.UseVisualStyleBackColor = true;
            // 
            // chckGuestDocuments
            // 
            chckGuestDocuments.AutoSize = true;
            chckGuestDocuments.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chckGuestDocuments.Location = new Point(61, 57);
            chckGuestDocuments.Name = "chckGuestDocuments";
            chckGuestDocuments.Size = new Size(147, 24);
            chckGuestDocuments.TabIndex = 0;
            chckGuestDocuments.Text = "Guest Documents";
            chckGuestDocuments.UseVisualStyleBackColor = true;
            chckGuestDocuments.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // BtnMigration
            // 
            BtnMigration.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMigration.Location = new Point(851, 361);
            BtnMigration.Name = "BtnMigration";
            BtnMigration.Size = new Size(216, 51);
            BtnMigration.TabIndex = 2;
            BtnMigration.Text = "Start Migration";
            BtnMigration.UseVisualStyleBackColor = true;
            BtnMigration.Click += button1_Click;
            // 
            // progressBarMigration
            // 
            progressBarMigration.Location = new Point(46, 528);
            progressBarMigration.Name = "progressBarMigration";
            progressBarMigration.Size = new Size(1021, 38);
            progressBarMigration.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(406, 481);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:";
            lblStatus.Click += label1_Click_2;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // txtBoxNewDb
            // 
            txtBoxNewDb.Location = new Point(277, 196);
            txtBoxNewDb.Multiline = true;
            txtBoxNewDb.Name = "txtBoxNewDb";
            txtBoxNewDb.Size = new Size(748, 93);
            txtBoxNewDb.TabIndex = 5;
            // 
            // lblNewDb
            // 
            lblNewDb.AutoSize = true;
            lblNewDb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewDb.Location = new Point(69, 196);
            lblNewDb.Name = "lblNewDb";
            lblNewDb.Size = new Size(188, 20);
            lblNewDb.TabIndex = 4;
            lblNewDb.Text = "New Db Connection String:";
            // 
            // DbMigration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1514, 676);
            Controls.Add(txtBoxNewDb);
            Controls.Add(lblNewDb);
            Controls.Add(lblStatus);
            Controls.Add(progressBarMigration);
            Controls.Add(BtnMigration);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DbMigration";
            Text = "Db Migration";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblOldDb;
        private TextBox txtBoxOldDb;
        private TextBox txtBoxNewDb;
        private Label lblNewDb;
        private GroupBox groupBox2;
        private CheckBox chckGuestDocuments;
        private CheckBox chckAddOnDocuments;
        private Button BtnMigration;
        private ProgressBar progressBarMigration;
        private ErrorProvider errorProvider1;
        private Label lblStatus;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
