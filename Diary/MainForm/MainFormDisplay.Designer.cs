namespace MainForm
{
    partial class MainFormDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mstControl = new System.Windows.Forms.TabControl();
            this.tabDiary = new System.Windows.Forms.TabPage();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.tabClans = new System.Windows.Forms.TabPage();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.ucDiary1 = new MainForm.ucDiary();
            this.ucPersons1 = new MainForm.ucPersons();
            this.ucClan1 = new MainForm.ucClan();
            this.btnLoadDBBackup = new System.Windows.Forms.Button();
            this.mstControl.SuspendLayout();
            this.tabDiary.SuspendLayout();
            this.tabPerson.SuspendLayout();
            this.tabClans.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstControl
            // 
            this.mstControl.Controls.Add(this.tabDiary);
            this.mstControl.Controls.Add(this.tabPerson);
            this.mstControl.Controls.Add(this.tabClans);
            this.mstControl.Location = new System.Drawing.Point(12, 52);
            this.mstControl.Name = "mstControl";
            this.mstControl.SelectedIndex = 0;
            this.mstControl.Size = new System.Drawing.Size(1257, 809);
            this.mstControl.TabIndex = 0;
            // 
            // tabDiary
            // 
            this.tabDiary.Controls.Add(this.ucDiary1);
            this.tabDiary.Location = new System.Drawing.Point(4, 22);
            this.tabDiary.Name = "tabDiary";
            this.tabDiary.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiary.Size = new System.Drawing.Size(1249, 783);
            this.tabDiary.TabIndex = 0;
            this.tabDiary.Text = "Diary";
            this.tabDiary.UseVisualStyleBackColor = true;
            // 
            // tabPerson
            // 
            this.tabPerson.Controls.Add(this.ucPersons1);
            this.tabPerson.Location = new System.Drawing.Point(4, 22);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerson.Size = new System.Drawing.Size(1249, 783);
            this.tabPerson.TabIndex = 1;
            this.tabPerson.Text = "Persons";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // tabClans
            // 
            this.tabClans.Controls.Add(this.ucClan1);
            this.tabClans.Location = new System.Drawing.Point(4, 22);
            this.tabClans.Name = "tabClans";
            this.tabClans.Padding = new System.Windows.Forms.Padding(3);
            this.tabClans.Size = new System.Drawing.Size(1249, 783);
            this.tabClans.TabIndex = 2;
            this.tabClans.Text = "Clans";
            this.tabClans.UseVisualStyleBackColor = true;
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(935, 13);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(127, 33);
            this.btnSaveDB.TabIndex = 1;
            this.btnSaveDB.Text = "Datenbank speichern";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.Location = new System.Drawing.Point(802, 13);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(127, 33);
            this.btnLoadDB.TabIndex = 1;
            this.btnLoadDB.Text = "Datenbank laden";
            this.btnLoadDB.UseVisualStyleBackColor = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // ucDiary1
            // 
            this.ucDiary1.DataSourceDiary = typeof(MainForm.Diary);
            this.ucDiary1.Location = new System.Drawing.Point(113, 176);
            this.ucDiary1.Name = "ucDiary1";
            this.ucDiary1.Size = new System.Drawing.Size(697, 427);
            this.ucDiary1.TabIndex = 0;
            // 
            // ucPersons1
            // 
            this.ucPersons1.DataSourcePerson = typeof(MainForm.Person);
            this.ucPersons1.Location = new System.Drawing.Point(142, 233);
            this.ucPersons1.Name = "ucPersons1";
            this.ucPersons1.Size = new System.Drawing.Size(717, 468);
            this.ucPersons1.TabIndex = 0;
            // 
            // ucClan1
            // 
            this.ucClan1.DataSourceClan = typeof(MainForm.Clan);
            this.ucClan1.Location = new System.Drawing.Point(120, 90);
            this.ucClan1.Name = "ucClan1";
            this.ucClan1.Size = new System.Drawing.Size(887, 622);
            this.ucClan1.TabIndex = 0;
            // 
            // btnLoadDBBackup
            // 
            this.btnLoadDBBackup.Location = new System.Drawing.Point(624, 13);
            this.btnLoadDBBackup.Name = "btnLoadDBBackup";
            this.btnLoadDBBackup.Size = new System.Drawing.Size(172, 33);
            this.btnLoadDBBackup.TabIndex = 1;
            this.btnLoadDBBackup.Text = "Datenbankbackup laden";
            this.btnLoadDBBackup.UseVisualStyleBackColor = true;
            this.btnLoadDBBackup.Click += new System.EventHandler(this.btnLoadDBBackup_Click);
            // 
            // MainFormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 873);
            this.Controls.Add(this.btnLoadDBBackup);
            this.Controls.Add(this.btnLoadDB);
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.mstControl);
            this.Name = "MainFormDisplay";
            this.Text = "D&D Diary";
            this.Load += new System.EventHandler(this.MainFormDisplay_Load);
            this.mstControl.ResumeLayout(false);
            this.tabDiary.ResumeLayout(false);
            this.tabPerson.ResumeLayout(false);
            this.tabClans.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mstControl;
        private System.Windows.Forms.TabPage tabDiary;
        private System.Windows.Forms.TabPage tabPerson;
        private ucPersons ucPersons1;
        private ucDiary ucDiary1;
        private System.Windows.Forms.TabPage tabClans;
        private ucClan ucClan1;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.Button btnLoadDBBackup;
    }
}

