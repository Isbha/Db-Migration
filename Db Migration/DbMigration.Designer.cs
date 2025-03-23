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
            groupBox1 = new GroupBox();
            lblOldDb = new Label();
            txtBoxOldDb = new TextBox();
            txtBoxNewDb = new TextBox();
            lblNewDb = new Label();
            groupBox2 = new GroupBox();
            chckGuestDocuments = new CheckBox();
            chckAddOnDocuments = new CheckBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxNewDb);
            groupBox1.Controls.Add(lblNewDb);
            groupBox1.Controls.Add(txtBoxOldDb);
            groupBox1.Controls.Add(lblOldDb);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(46, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1418, 226);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Database Connections";
            // 
            // lblOldDb
            // 
            lblOldDb.AutoSize = true;
            lblOldDb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOldDb.Location = new Point(32, 54);
            lblOldDb.Name = "lblOldDb";
            lblOldDb.Size = new Size(182, 20);
            lblOldDb.TabIndex = 0;
            lblOldDb.Text = "Old Db Connection String:";
            lblOldDb.Click += label1_Click;
            // 
            // txtBoxOldDb
            // 
            txtBoxOldDb.Location = new Point(231, 54);
            txtBoxOldDb.Multiline = true;
            txtBoxOldDb.Name = "txtBoxOldDb";
            txtBoxOldDb.Size = new Size(449, 125);
            txtBoxOldDb.TabIndex = 1;
            txtBoxOldDb.TextChanged += textBox1_TextChanged;
            // 
            // txtBoxNewDb
            // 
            txtBoxNewDb.Location = new Point(924, 55);
            txtBoxNewDb.Multiline = true;
            txtBoxNewDb.Name = "txtBoxNewDb";
            txtBoxNewDb.Size = new Size(470, 124);
            txtBoxNewDb.TabIndex = 3;
            // 
            // lblNewDb
            // 
            lblNewDb.AutoSize = true;
            lblNewDb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewDb.Location = new Point(711, 55);
            lblNewDb.Name = "lblNewDb";
            lblNewDb.Size = new Size(188, 20);
            lblNewDb.TabIndex = 2;
            lblNewDb.Text = "New Db Connection String:";
            lblNewDb.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chckAddOnDocuments);
            groupBox2.Controls.Add(chckGuestDocuments);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(46, 315);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1418, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tables to Migrate";
            groupBox2.Enter += groupBox2_Enter;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(697, 476);
            button1.Name = "button1";
            button1.Size = new Size(115, 39);
            button1.TabIndex = 2;
            button1.Text = "Start Migration";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DbMigration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1514, 676);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "DbMigration";
            Text = "Db Migration";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
        private Button button1;
    }
}
