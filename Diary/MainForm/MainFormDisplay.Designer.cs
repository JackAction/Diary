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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormDisplay));
            this.mstControl = new System.Windows.Forms.TabControl();
            this.tabDiary = new System.Windows.Forms.TabPage();
            this.tabPerson = new System.Windows.Forms.TabPage();
            this.btnUpdatePeopleForDiaryEntry = new System.Windows.Forms.Button();
            this.tabClans = new System.Windows.Forms.TabPage();
            this.tabPlaces = new System.Windows.Forms.TabPage();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.btnLoadDBBackup = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.lblSessionID = new System.Windows.Forms.Label();
            this.txtSessionID = new System.Windows.Forms.NumericUpDown();
            this.ucDiary1 = new MainForm.ucDiary();
            this.ucPersons1 = new MainForm.ucPersons();
            this.ucClan1 = new MainForm.ucClan();
            this.ucPlace1 = new MainForm.ucPlace();
            this.mstControl.SuspendLayout();
            this.tabDiary.SuspendLayout();
            this.tabPerson.SuspendLayout();
            this.tabClans.SuspendLayout();
            this.tabPlaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSessionID)).BeginInit();
            this.SuspendLayout();
            // 
            // mstControl
            // 
            this.mstControl.Controls.Add(this.tabDiary);
            this.mstControl.Controls.Add(this.tabPerson);
            this.mstControl.Controls.Add(this.tabClans);
            this.mstControl.Controls.Add(this.tabPlaces);
            this.mstControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstControl.ItemSize = new System.Drawing.Size(200, 45);
            this.mstControl.Location = new System.Drawing.Point(12, 54);
            this.mstControl.Name = "mstControl";
            this.mstControl.SelectedIndex = 0;
            this.mstControl.Size = new System.Drawing.Size(1257, 809);
            this.mstControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mstControl.TabIndex = 0;
            this.mstControl.SelectedIndexChanged += new System.EventHandler(this.mstControl_SelectedIndexChanged);
            // 
            // tabDiary
            // 
            this.tabDiary.Controls.Add(this.ucDiary1);
            this.tabDiary.Location = new System.Drawing.Point(4, 49);
            this.tabDiary.Name = "tabDiary";
            this.tabDiary.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiary.Size = new System.Drawing.Size(1249, 756);
            this.tabDiary.TabIndex = 0;
            this.tabDiary.Text = "Diary";
            this.tabDiary.UseVisualStyleBackColor = true;
            // 
            // tabPerson
            // 
            this.tabPerson.Controls.Add(this.btnUpdatePeopleForDiaryEntry);
            this.tabPerson.Controls.Add(this.ucPersons1);
            this.tabPerson.Location = new System.Drawing.Point(4, 49);
            this.tabPerson.Name = "tabPerson";
            this.tabPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerson.Size = new System.Drawing.Size(1249, 756);
            this.tabPerson.TabIndex = 1;
            this.tabPerson.Text = "People";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePeopleForDiaryEntry
            // 
            this.btnUpdatePeopleForDiaryEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePeopleForDiaryEntry.Location = new System.Drawing.Point(387, 132);
            this.btnUpdatePeopleForDiaryEntry.Name = "btnUpdatePeopleForDiaryEntry";
            this.btnUpdatePeopleForDiaryEntry.Size = new System.Drawing.Size(158, 83);
            this.btnUpdatePeopleForDiaryEntry.TabIndex = 1;
            this.btnUpdatePeopleForDiaryEntry.Text = "Update and return to Diary";
            this.btnUpdatePeopleForDiaryEntry.UseVisualStyleBackColor = true;
            this.btnUpdatePeopleForDiaryEntry.Visible = false;
            this.btnUpdatePeopleForDiaryEntry.Click += new System.EventHandler(this.btnAddPeopleToDiary_Click);
            // 
            // tabClans
            // 
            this.tabClans.Controls.Add(this.ucClan1);
            this.tabClans.Location = new System.Drawing.Point(4, 49);
            this.tabClans.Name = "tabClans";
            this.tabClans.Padding = new System.Windows.Forms.Padding(3);
            this.tabClans.Size = new System.Drawing.Size(1249, 756);
            this.tabClans.TabIndex = 2;
            this.tabClans.Text = "Clans";
            this.tabClans.UseVisualStyleBackColor = true;
            // 
            // tabPlaces
            // 
            this.tabPlaces.Controls.Add(this.ucPlace1);
            this.tabPlaces.Location = new System.Drawing.Point(4, 49);
            this.tabPlaces.Name = "tabPlaces";
            this.tabPlaces.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlaces.Size = new System.Drawing.Size(1249, 756);
            this.tabPlaces.TabIndex = 3;
            this.tabPlaces.Text = "Places";
            this.tabPlaces.UseVisualStyleBackColor = true;
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(935, 13);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(125, 36);
            this.btnSaveDB.TabIndex = 1;
            this.btnSaveDB.Text = "Datenbank Backup speichern";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.btnSaveDB_Click);
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.Location = new System.Drawing.Point(802, 13);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(127, 36);
            this.btnLoadDB.TabIndex = 1;
            this.btnLoadDB.Text = "Daten aus lokaler Datenbank laden";
            this.btnLoadDB.UseVisualStyleBackColor = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // btnLoadDBBackup
            // 
            this.btnLoadDBBackup.Location = new System.Drawing.Point(667, 13);
            this.btnLoadDBBackup.Name = "btnLoadDBBackup";
            this.btnLoadDBBackup.Size = new System.Drawing.Size(129, 36);
            this.btnLoadDBBackup.TabIndex = 1;
            this.btnLoadDBBackup.Text = "Datenbank Backup laden";
            this.btnLoadDBBackup.UseVisualStyleBackColor = true;
            this.btnLoadDBBackup.Click += new System.EventHandler(this.btnLoadDBBackup_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(286, 13);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(379, 13);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(89, 36);
            this.btnDiscard.TabIndex = 2;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // lblSessionID
            // 
            this.lblSessionID.AutoSize = true;
            this.lblSessionID.Location = new System.Drawing.Point(13, 13);
            this.lblSessionID.Name = "lblSessionID";
            this.lblSessionID.Size = new System.Drawing.Size(61, 13);
            this.lblSessionID.TabIndex = 3;
            this.lblSessionID.Text = "Session Nr:";
            // 
            // txtSessionID
            // 
            this.txtSessionID.Location = new System.Drawing.Point(80, 11);
            this.txtSessionID.Name = "txtSessionID";
            this.txtSessionID.Size = new System.Drawing.Size(42, 20);
            this.txtSessionID.TabIndex = 5;
            // 
            // ucDiary1
            // 
            this.ucDiary1.AutoSize = true;
            this.ucDiary1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucDiary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDiary1.Location = new System.Drawing.Point(3, 3);
            this.ucDiary1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDiary1.Name = "ucDiary1";
            this.ucDiary1.Size = new System.Drawing.Size(1243, 612);
            this.ucDiary1.TabIndex = 0;
            // 
            // ucPersons1
            // 
            this.ucPersons1.AutoSize = true;
            this.ucPersons1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPersons1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPersons1.Location = new System.Drawing.Point(3, 3);
            this.ucPersons1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPersons1.Name = "ucPersons1";
            this.ucPersons1.Size = new System.Drawing.Size(1243, 636);
            this.ucPersons1.TabIndex = 0;
            // 
            // ucClan1
            // 
            this.ucClan1.AutoSize = true;
            this.ucClan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucClan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucClan1.Location = new System.Drawing.Point(3, 3);
            this.ucClan1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucClan1.Name = "ucClan1";
            this.ucClan1.Size = new System.Drawing.Size(1243, 596);
            this.ucClan1.TabIndex = 0;
            // 
            // ucPlace1
            // 
            this.ucPlace1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPlace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPlace1.Location = new System.Drawing.Point(3, 3);
            this.ucPlace1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ucPlace1.Name = "ucPlace1";
            this.ucPlace1.Size = new System.Drawing.Size(1243, 764);
            this.ucPlace1.TabIndex = 0;
            // 
            // MainFormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 721);
            this.Controls.Add(this.txtSessionID);
            this.Controls.Add(this.lblSessionID);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoadDBBackup);
            this.Controls.Add(this.btnLoadDB);
            this.Controls.Add(this.btnSaveDB);
            this.Controls.Add(this.mstControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormDisplay";
            this.Text = "D&D Diary";
            this.Load += new System.EventHandler(this.MainFormDisplay_Load);
            this.mstControl.ResumeLayout(false);
            this.tabDiary.ResumeLayout(false);
            this.tabDiary.PerformLayout();
            this.tabPerson.ResumeLayout(false);
            this.tabPerson.PerformLayout();
            this.tabClans.ResumeLayout(false);
            this.tabClans.PerformLayout();
            this.tabPlaces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSessionID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mstControl;
        private System.Windows.Forms.TabPage tabDiary;
        private System.Windows.Forms.TabPage tabPerson;
        private ucPersons ucPersons1;
        private ucDiary ucDiary1;
        private System.Windows.Forms.TabPage tabClans;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.Button btnLoadDBBackup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private ucClan ucClan1;
        private System.Windows.Forms.TabPage tabPlaces;
        private ucPlace ucPlace1;
        private System.Windows.Forms.Label lblSessionID;
        private System.Windows.Forms.NumericUpDown txtSessionID;
        private System.Windows.Forms.Button btnUpdatePeopleForDiaryEntry;
    }
}

