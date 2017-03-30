namespace MainForm
{
    partial class ucClan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.clanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxFilterColumn = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ucPicture1 = new MainForm.ucPicture();
            this.lblDiaryEntries = new System.Windows.Forms.Label();
            this.lblClanMembers = new System.Windows.Forms.Label();
            this.lblClans = new System.Windows.Forms.Label();
            this.dbgrdDiary = new System.Windows.Forms.DataGridView();
            this.diaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbgrdPersons = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletePerson = new System.Windows.Forms.DataGridViewButtonColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbgrdClans = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingameDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdClans)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(1475, 486);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(87, 29);
            this.lblDetails.TabIndex = 15;
            this.lblDetails.Text = "Details";
            // 
            // txtDetails
            // 
            this.txtDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clanBindingSource, "Details", true));
            this.txtDetails.Location = new System.Drawing.Point(1481, 522);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(279, 349);
            this.txtDetails.TabIndex = 14;
            // 
            // clanBindingSource
            // 
            this.clanBindingSource.DataSource = typeof(MainForm.Clan);
            // 
            // cbxFilterColumn
            // 
            this.cbxFilterColumn.FormattingEnabled = true;
            this.cbxFilterColumn.Items.AddRange(new object[] {
            "All",
            "Name",
            "Details"});
            this.cbxFilterColumn.Location = new System.Drawing.Point(387, 457);
            this.cbxFilterColumn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbxFilterColumn.Name = "cbxFilterColumn";
            this.cbxFilterColumn.Size = new System.Drawing.Size(186, 37);
            this.cbxFilterColumn.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(585, 460);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(418, 35);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ucPicture1
            // 
            this.ucPicture1.Filename = null;
            this.ucPicture1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPicture1.Location = new System.Drawing.Point(1300, 42);
            this.ucPicture1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucPicture1.Name = "ucPicture1";
            this.ucPicture1.Size = new System.Drawing.Size(415, 442);
            this.ucPicture1.TabIndex = 6;
            // 
            // lblDiaryEntries
            // 
            this.lblDiaryEntries.AutoSize = true;
            this.lblDiaryEntries.Location = new System.Drawing.Point(54, 77);
            this.lblDiaryEntries.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiaryEntries.Name = "lblDiaryEntries";
            this.lblDiaryEntries.Size = new System.Drawing.Size(149, 29);
            this.lblDiaryEntries.TabIndex = 5;
            this.lblDiaryEntries.Text = "Diary Entries";
            // 
            // lblClanMembers
            // 
            this.lblClanMembers.AutoSize = true;
            this.lblClanMembers.Location = new System.Drawing.Point(54, 486);
            this.lblClanMembers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClanMembers.Name = "lblClanMembers";
            this.lblClanMembers.Size = new System.Drawing.Size(170, 29);
            this.lblClanMembers.TabIndex = 4;
            this.lblClanMembers.Text = "Clan Members";
            // 
            // lblClans
            // 
            this.lblClans.AutoSize = true;
            this.lblClans.Location = new System.Drawing.Point(1170, 486);
            this.lblClans.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblClans.Name = "lblClans";
            this.lblClans.Size = new System.Drawing.Size(74, 29);
            this.lblClans.TabIndex = 3;
            this.lblClans.Text = "Clans";
            // 
            // dbgrdDiary
            // 
            this.dbgrdDiary.AllowUserToAddRows = false;
            this.dbgrdDiary.AllowUserToDeleteRows = false;
            this.dbgrdDiary.AutoGenerateColumns = false;
            this.dbgrdDiary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dbgrdDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdDiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionIDDataGridViewTextBoxColumn,
            this.ingameDayDataGridViewTextBoxColumn,
            this.entryDataGridViewTextBoxColumn,
            this.PeopleString,
            this.placeDataGridViewTextBoxColumn1,
            this.itemDataGridViewTextBoxColumn,
            this.questDataGridViewTextBoxColumn});
            this.dbgrdDiary.DataSource = this.diaryBindingSource;
            this.dbgrdDiary.Location = new System.Drawing.Point(61, 113);
            this.dbgrdDiary.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dbgrdDiary.Name = "dbgrdDiary";
            this.dbgrdDiary.ReadOnly = true;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrdDiary.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dbgrdDiary.Size = new System.Drawing.Size(1081, 335);
            this.dbgrdDiary.TabIndex = 2;
            // 
            // diaryBindingSource
            // 
            this.diaryBindingSource.DataSource = typeof(MainForm.Diary);
            // 
            // dbgrdPersons
            // 
            this.dbgrdPersons.AutoGenerateColumns = false;
            this.dbgrdPersons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dbgrdPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.deadDataGridViewTextBoxColumn,
            this.comment2DataGridViewTextBoxColumn,
            this.DeletePerson});
            this.dbgrdPersons.DataSource = this.personBindingSource;
            this.dbgrdPersons.Location = new System.Drawing.Point(61, 522);
            this.dbgrdPersons.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dbgrdPersons.Name = "dbgrdPersons";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrdPersons.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dbgrdPersons.Size = new System.Drawing.Size(1020, 335);
            this.dbgrdPersons.TabIndex = 1;
            this.dbgrdPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPersons_CellClick);
            this.dbgrdPersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPersons_CellContentClick);
            this.dbgrdPersons.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdPersons_RowsAdded);
            this.dbgrdPersons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgrdPersons_KeyDown);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            // 
            // deadDataGridViewTextBoxColumn
            // 
            this.deadDataGridViewTextBoxColumn.DataPropertyName = "Dead";
            this.deadDataGridViewTextBoxColumn.HeaderText = "Dead";
            this.deadDataGridViewTextBoxColumn.Name = "deadDataGridViewTextBoxColumn";
            // 
            // comment2DataGridViewTextBoxColumn
            // 
            this.comment2DataGridViewTextBoxColumn.DataPropertyName = "Comment_2";
            this.comment2DataGridViewTextBoxColumn.HeaderText = "Comment";
            this.comment2DataGridViewTextBoxColumn.Name = "comment2DataGridViewTextBoxColumn";
            // 
            // DeletePerson
            // 
            this.DeletePerson.HeaderText = "Delete";
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeletePerson.Text = "X";
            this.DeletePerson.UseColumnTextForButtonValue = true;
            this.DeletePerson.Width = 70;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(MainForm.Person);
            // 
            // dbgrdClans
            // 
            this.dbgrdClans.AutoGenerateColumns = false;
            this.dbgrdClans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dbgrdClans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdClans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dbgrdClans.DataSource = this.clanBindingSource;
            this.dbgrdClans.Location = new System.Drawing.Point(1176, 522);
            this.dbgrdClans.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dbgrdClans.Name = "dbgrdClans";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrdClans.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dbgrdClans.Size = new System.Drawing.Size(249, 335);
            this.dbgrdClans.TabIndex = 0;
            this.dbgrdClans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdClans_CellClick);
            this.dbgrdClans.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdClans_RowsAdded);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "SessionID";
            this.sessionIDDataGridViewTextBoxColumn.HeaderText = "S";
            this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            this.sessionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sessionIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // ingameDayDataGridViewTextBoxColumn
            // 
            this.ingameDayDataGridViewTextBoxColumn.DataPropertyName = "IngameDay";
            this.ingameDayDataGridViewTextBoxColumn.HeaderText = "IngameDay";
            this.ingameDayDataGridViewTextBoxColumn.Name = "ingameDayDataGridViewTextBoxColumn";
            this.ingameDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entryDataGridViewTextBoxColumn
            // 
            this.entryDataGridViewTextBoxColumn.DataPropertyName = "Entry";
            this.entryDataGridViewTextBoxColumn.HeaderText = "Entry";
            this.entryDataGridViewTextBoxColumn.Name = "entryDataGridViewTextBoxColumn";
            this.entryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PeopleString
            // 
            this.PeopleString.DataPropertyName = "PeopleString";
            this.PeopleString.HeaderText = "People";
            this.PeopleString.Name = "PeopleString";
            this.PeopleString.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn1
            // 
            this.placeDataGridViewTextBoxColumn1.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn1.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn1.Name = "placeDataGridViewTextBoxColumn1";
            this.placeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // questDataGridViewTextBoxColumn
            // 
            this.questDataGridViewTextBoxColumn.DataPropertyName = "Quest";
            this.questDataGridViewTextBoxColumn.HeaderText = "Quest";
            this.questDataGridViewTextBoxColumn.Name = "questDataGridViewTextBoxColumn";
            this.questDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucClan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.cbxFilterColumn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ucPicture1);
            this.Controls.Add(this.lblDiaryEntries);
            this.Controls.Add(this.lblClanMembers);
            this.Controls.Add(this.lblClans);
            this.Controls.Add(this.dbgrdDiary);
            this.Controls.Add(this.dbgrdPersons);
            this.Controls.Add(this.dbgrdClans);
            this.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.Name = "ucClan";
            this.Size = new System.Drawing.Size(1850, 914);
            this.Load += new System.EventHandler(this.ucClan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdClans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgrdClans;
        private System.Windows.Forms.BindingSource clanBindingSource;
        private System.Windows.Forms.DataGridView dbgrdPersons;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView dbgrdDiary;
        private System.Windows.Forms.BindingSource diaryBindingSource;
        private System.Windows.Forms.Label lblClans;
        private System.Windows.Forms.Label lblClanMembers;
        private System.Windows.Forms.Label lblDiaryEntries;
        private ucPicture ucPicture1;
        private System.Windows.Forms.ComboBox cbxFilterColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeletePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingameDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleString;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questDataGridViewTextBoxColumn;
    }
}
