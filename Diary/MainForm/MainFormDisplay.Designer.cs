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
            this.lblSessionID = new System.Windows.Forms.Label();
            this.txtSessionID = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBackupFromLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDropboxBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickDiscardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstControl
            // 
            this.mstControl.Controls.Add(this.tabDiary);
            this.mstControl.Controls.Add(this.tabPerson);
            this.mstControl.Controls.Add(this.tabClans);
            this.mstControl.Controls.Add(this.tabPlaces);
            this.mstControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mstControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstControl.ItemSize = new System.Drawing.Size(200, 45);
            this.mstControl.Location = new System.Drawing.Point(0, 29);
            this.mstControl.Name = "mstControl";
            this.mstControl.SelectedIndex = 0;
            this.mstControl.Size = new System.Drawing.Size(1266, 714);
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
            this.tabDiary.Size = new System.Drawing.Size(1258, 661);
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
            this.tabPerson.Size = new System.Drawing.Size(1258, 661);
            this.tabPerson.TabIndex = 1;
            this.tabPerson.Text = "People";
            this.tabPerson.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePeopleForDiaryEntry
            // 
            this.btnUpdatePeopleForDiaryEntry.BackColor = System.Drawing.Color.LawnGreen;
            this.btnUpdatePeopleForDiaryEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePeopleForDiaryEntry.Location = new System.Drawing.Point(257, 210);
            this.btnUpdatePeopleForDiaryEntry.Name = "btnUpdatePeopleForDiaryEntry";
            this.btnUpdatePeopleForDiaryEntry.Size = new System.Drawing.Size(323, 39);
            this.btnUpdatePeopleForDiaryEntry.TabIndex = 1;
            this.btnUpdatePeopleForDiaryEntry.Text = "Update and return to Diary";
            this.btnUpdatePeopleForDiaryEntry.UseVisualStyleBackColor = false;
            this.btnUpdatePeopleForDiaryEntry.Visible = false;
            this.btnUpdatePeopleForDiaryEntry.Click += new System.EventHandler(this.btnAddPeopleToDiary_Click);
            // 
            // tabClans
            // 
            this.tabClans.Controls.Add(this.ucClan1);
            this.tabClans.Location = new System.Drawing.Point(4, 49);
            this.tabClans.Name = "tabClans";
            this.tabClans.Padding = new System.Windows.Forms.Padding(3);
            this.tabClans.Size = new System.Drawing.Size(1258, 661);
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
            this.tabPlaces.Size = new System.Drawing.Size(1258, 661);
            this.tabPlaces.TabIndex = 3;
            this.tabPlaces.Text = "Places";
            this.tabPlaces.UseVisualStyleBackColor = true;
            // 
            // lblSessionID
            // 
            this.lblSessionID.AutoSize = true;
            this.lblSessionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionID.Location = new System.Drawing.Point(167, 6);
            this.lblSessionID.Name = "lblSessionID";
            this.lblSessionID.Size = new System.Drawing.Size(90, 20);
            this.lblSessionID.TabIndex = 3;
            this.lblSessionID.Text = "Session Nr:";
            // 
            // txtSessionID
            // 
            this.txtSessionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSessionID.Location = new System.Drawing.Point(261, 4);
            this.txtSessionID.Name = "txtSessionID";
            this.txtSessionID.Size = new System.Drawing.Size(42, 26);
            this.txtSessionID.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quickDiscardToolStripMenuItem,
            this.quickSaveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 29);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBackupFromLocalToolStripMenuItem,
            this.loadBackupToolStripMenuItem});
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.loadToolStripMenuItem.Text = "Load DB";
            // 
            // loadBackupFromLocalToolStripMenuItem
            // 
            this.loadBackupFromLocalToolStripMenuItem.Name = "loadBackupFromLocalToolStripMenuItem";
            this.loadBackupFromLocalToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.loadBackupFromLocalToolStripMenuItem.Text = "Load local Database";
            this.loadBackupFromLocalToolStripMenuItem.Click += new System.EventHandler(this.loadBackupFromLocalToolStripMenuItem_Click);
            // 
            // loadBackupToolStripMenuItem
            // 
            this.loadBackupToolStripMenuItem.Name = "loadBackupToolStripMenuItem";
            this.loadBackupToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.loadBackupToolStripMenuItem.Text = "Load Dropbox Backup";
            this.loadBackupToolStripMenuItem.Click += new System.EventHandler(this.loadBackupToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDropboxBackupToolStripMenuItem});
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.saveToolStripMenuItem.Text = "Save DB";
            // 
            // saveDropboxBackupToolStripMenuItem
            // 
            this.saveDropboxBackupToolStripMenuItem.Name = "saveDropboxBackupToolStripMenuItem";
            this.saveDropboxBackupToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.saveDropboxBackupToolStripMenuItem.Text = "Save Dropbox Backup";
            this.saveDropboxBackupToolStripMenuItem.Click += new System.EventHandler(this.saveDropboxBackupToolStripMenuItem_Click);
            // 
            // quickDiscardToolStripMenuItem
            // 
            this.quickDiscardToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.quickDiscardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.quickDiscardToolStripMenuItem.Name = "quickDiscardToolStripMenuItem";
            this.quickDiscardToolStripMenuItem.Size = new System.Drawing.Size(118, 25);
            this.quickDiscardToolStripMenuItem.Text = "Quick Discard";
            this.quickDiscardToolStripMenuItem.ToolTipText = "\r\n";
            this.quickDiscardToolStripMenuItem.Click += new System.EventHandler(this.quickDiscardToolStripMenuItem_Click);
            // 
            // quickSaveToolStripMenuItem
            // 
            this.quickSaveToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.quickSaveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.quickSaveToolStripMenuItem.Name = "quickSaveToolStripMenuItem";
            this.quickSaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.quickSaveToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.quickSaveToolStripMenuItem.Text = "Quick Save";
            this.quickSaveToolStripMenuItem.Click += new System.EventHandler(this.quickSaveToolStripMenuItem_Click);
            // 
            // ucDiary1
            // 
            this.ucDiary1.AutoSize = true;
            this.ucDiary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDiary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDiary1.Location = new System.Drawing.Point(3, 3);
            this.ucDiary1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDiary1.Name = "ucDiary1";
            this.ucDiary1.Size = new System.Drawing.Size(1252, 655);
            this.ucDiary1.TabIndex = 0;
            // 
            // ucPersons1
            // 
            this.ucPersons1.AutoSize = true;
            this.ucPersons1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPersons1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPersons1.Location = new System.Drawing.Point(3, 3);
            this.ucPersons1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPersons1.Name = "ucPersons1";
            this.ucPersons1.Size = new System.Drawing.Size(1252, 655);
            this.ucPersons1.TabIndex = 0;
            // 
            // ucClan1
            // 
            this.ucClan1.AutoSize = true;
            this.ucClan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucClan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucClan1.Location = new System.Drawing.Point(3, 3);
            this.ucClan1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucClan1.Name = "ucClan1";
            this.ucClan1.Size = new System.Drawing.Size(1252, 655);
            this.ucClan1.TabIndex = 0;
            // 
            // ucPlace1
            // 
            this.ucPlace1.AutoSize = true;
            this.ucPlace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPlace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPlace1.Location = new System.Drawing.Point(3, 3);
            this.ucPlace1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ucPlace1.Name = "ucPlace1";
            this.ucPlace1.Size = new System.Drawing.Size(1252, 655);
            this.ucPlace1.TabIndex = 0;
            // 
            // MainFormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 743);
            this.Controls.Add(this.txtSessionID);
            this.Controls.Add(this.lblSessionID);
            this.Controls.Add(this.mstControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
            this.tabPlaces.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSessionID)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private ucClan ucClan1;
        private System.Windows.Forms.TabPage tabPlaces;
        private ucPlace ucPlace1;
        private System.Windows.Forms.Label lblSessionID;
        private System.Windows.Forms.NumericUpDown txtSessionID;
        private System.Windows.Forms.Button btnUpdatePeopleForDiaryEntry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBackupFromLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDropboxBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickDiscardToolStripMenuItem;
    }
}

