namespace MainForm
{
    partial class ucPersons
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
            this.dbgrdPersons = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Place = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.raceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alignementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diariesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbgrdDiary = new System.Windows.Forms.DataGridView();
            this.diaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPersons = new System.Windows.Forms.Label();
            this.lblDiaryEntries = new System.Windows.Forms.Label();
            this.ucAddNewPlace1 = new MainForm.ucAddNewPlace();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingameDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PeopleString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbgrdPersons
            // 
            this.dbgrdPersons.AutoGenerateColumns = false;
            this.dbgrdPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.clanDataGridViewTextBoxColumn,
            this.Place1,
            this.Place,
            this.raceDataGridViewTextBoxColumn,
            this.deadDataGridViewTextBoxColumn,
            this.alignementDataGridViewTextBoxColumn,
            this.comment2DataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.diariesDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.clanIDDataGridViewTextBoxColumn});
            this.dbgrdPersons.DataSource = this.personBindingSource;
            this.dbgrdPersons.Location = new System.Drawing.Point(42, 306);
            this.dbgrdPersons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbgrdPersons.Name = "dbgrdPersons";
            this.dbgrdPersons.Size = new System.Drawing.Size(933, 255);
            this.dbgrdPersons.TabIndex = 0;
            this.dbgrdPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPersons_CellClick);
            this.dbgrdPersons.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdPersons_RowsAdded);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // clanDataGridViewTextBoxColumn
            // 
            this.clanDataGridViewTextBoxColumn.DataPropertyName = "Clan";
            this.clanDataGridViewTextBoxColumn.HeaderText = "Clan";
            this.clanDataGridViewTextBoxColumn.Name = "clanDataGridViewTextBoxColumn";
            // 
            // Place1
            // 
            this.Place1.DataPropertyName = "Place_Met";
            this.Place1.DataSource = this.placeBindingSource;
            this.Place1.DisplayMember = "Name";
            this.Place1.HeaderText = "Met Place";
            this.Place1.Name = "Place1";
            this.Place1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Place1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Place1.ValueMember = "ID";
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(MainForm.Place);
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Place_LastKnown";
            this.Place.DataSource = this.placeBindingSource;
            this.Place.DisplayMember = "Name";
            this.Place.HeaderText = "Last known Place";
            this.Place.Name = "Place";
            this.Place.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Place.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Place.ValueMember = "ID";
            // 
            // raceDataGridViewTextBoxColumn
            // 
            this.raceDataGridViewTextBoxColumn.DataPropertyName = "Race";
            this.raceDataGridViewTextBoxColumn.HeaderText = "Race";
            this.raceDataGridViewTextBoxColumn.Name = "raceDataGridViewTextBoxColumn";
            // 
            // deadDataGridViewTextBoxColumn
            // 
            this.deadDataGridViewTextBoxColumn.DataPropertyName = "Dead";
            this.deadDataGridViewTextBoxColumn.HeaderText = "Dead";
            this.deadDataGridViewTextBoxColumn.Name = "deadDataGridViewTextBoxColumn";
            // 
            // alignementDataGridViewTextBoxColumn
            // 
            this.alignementDataGridViewTextBoxColumn.DataPropertyName = "Alignement";
            this.alignementDataGridViewTextBoxColumn.HeaderText = "Alignement";
            this.alignementDataGridViewTextBoxColumn.Name = "alignementDataGridViewTextBoxColumn";
            // 
            // comment2DataGridViewTextBoxColumn
            // 
            this.comment2DataGridViewTextBoxColumn.DataPropertyName = "Comment_2";
            this.comment2DataGridViewTextBoxColumn.HeaderText = "Comment_2";
            this.comment2DataGridViewTextBoxColumn.Name = "comment2DataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // diariesDataGridViewTextBoxColumn
            // 
            this.diariesDataGridViewTextBoxColumn.DataPropertyName = "Diaries";
            this.diariesDataGridViewTextBoxColumn.HeaderText = "Diaries";
            this.diariesDataGridViewTextBoxColumn.Name = "diariesDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 20;
            // 
            // clanIDDataGridViewTextBoxColumn
            // 
            this.clanIDDataGridViewTextBoxColumn.DataPropertyName = "Clan_ID";
            this.clanIDDataGridViewTextBoxColumn.HeaderText = "Clan_ID";
            this.clanIDDataGridViewTextBoxColumn.Name = "clanIDDataGridViewTextBoxColumn";
            this.clanIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(MainForm.Person);
            // 
            // dbgrdDiary
            // 
            this.dbgrdDiary.AutoGenerateColumns = false;
            this.dbgrdDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdDiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionIDDataGridViewTextBoxColumn,
            this.ingameDayDataGridViewTextBoxColumn,
            this.entryDataGridViewTextBoxColumn,
            this.placeIDDataGridViewTextBoxColumn,
            this.PeopleString,
            this.itemDataGridViewTextBoxColumn,
            this.questDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn1,
            this.questsIDDataGridViewTextBoxColumn,
            this.itemsIDDataGridViewTextBoxColumn});
            this.dbgrdDiary.DataSource = this.diaryBindingSource;
            this.dbgrdDiary.Location = new System.Drawing.Point(87, 32);
            this.dbgrdDiary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbgrdDiary.Name = "dbgrdDiary";
            this.dbgrdDiary.Size = new System.Drawing.Size(848, 231);
            this.dbgrdDiary.TabIndex = 1;
            this.dbgrdDiary.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dbgrdDiary_DataError);
            this.dbgrdDiary.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdDiary_RowsAdded);
            // 
            // diaryBindingSource
            // 
            this.diaryBindingSource.DataSource = typeof(MainForm.Diary);
            // 
            // lblPersons
            // 
            this.lblPersons.AutoSize = true;
            this.lblPersons.Location = new System.Drawing.Point(38, 281);
            this.lblPersons.Name = "lblPersons";
            this.lblPersons.Size = new System.Drawing.Size(67, 20);
            this.lblPersons.TabIndex = 2;
            this.lblPersons.Text = "Persons";
            // 
            // lblDiaryEntries
            // 
            this.lblDiaryEntries.AutoSize = true;
            this.lblDiaryEntries.Location = new System.Drawing.Point(83, 7);
            this.lblDiaryEntries.Name = "lblDiaryEntries";
            this.lblDiaryEntries.Size = new System.Drawing.Size(99, 20);
            this.lblDiaryEntries.TabIndex = 3;
            this.lblDiaryEntries.Text = "Diary Entries";
            // 
            // ucAddNewPlace1
            // 
            this.ucAddNewPlace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAddNewPlace1.Location = new System.Drawing.Point(25, 571);
            this.ucAddNewPlace1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddNewPlace1.Name = "ucAddNewPlace1";
            this.ucAddNewPlace1.Size = new System.Drawing.Size(1006, 60);
            this.ucAddNewPlace1.TabIndex = 4;
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "SessionID";
            this.sessionIDDataGridViewTextBoxColumn.HeaderText = "S";
            this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            // 
            // ingameDayDataGridViewTextBoxColumn
            // 
            this.ingameDayDataGridViewTextBoxColumn.DataPropertyName = "IngameDay";
            this.ingameDayDataGridViewTextBoxColumn.HeaderText = "IngameDay";
            this.ingameDayDataGridViewTextBoxColumn.Name = "ingameDayDataGridViewTextBoxColumn";
            // 
            // entryDataGridViewTextBoxColumn
            // 
            this.entryDataGridViewTextBoxColumn.DataPropertyName = "Entry";
            this.entryDataGridViewTextBoxColumn.HeaderText = "Entry";
            this.entryDataGridViewTextBoxColumn.Name = "entryDataGridViewTextBoxColumn";
            // 
            // placeIDDataGridViewTextBoxColumn
            // 
            this.placeIDDataGridViewTextBoxColumn.DataPropertyName = "Place_ID";
            this.placeIDDataGridViewTextBoxColumn.DataSource = this.placeBindingSource;
            this.placeIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.placeIDDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeIDDataGridViewTextBoxColumn.Name = "placeIDDataGridViewTextBoxColumn";
            this.placeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.placeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.placeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.placeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // PeopleString
            // 
            this.PeopleString.DataPropertyName = "PeopleString";
            this.PeopleString.HeaderText = "People";
            this.PeopleString.Name = "PeopleString";
            this.PeopleString.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // questDataGridViewTextBoxColumn
            // 
            this.questDataGridViewTextBoxColumn.DataPropertyName = "Quest";
            this.questDataGridViewTextBoxColumn.HeaderText = "Quest";
            this.questDataGridViewTextBoxColumn.Name = "questDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Width = 20;
            // 
            // questsIDDataGridViewTextBoxColumn
            // 
            this.questsIDDataGridViewTextBoxColumn.DataPropertyName = "Quests_ID";
            this.questsIDDataGridViewTextBoxColumn.HeaderText = "Quests_ID";
            this.questsIDDataGridViewTextBoxColumn.Name = "questsIDDataGridViewTextBoxColumn";
            this.questsIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // itemsIDDataGridViewTextBoxColumn
            // 
            this.itemsIDDataGridViewTextBoxColumn.DataPropertyName = "Items_ID";
            this.itemsIDDataGridViewTextBoxColumn.HeaderText = "Items_ID";
            this.itemsIDDataGridViewTextBoxColumn.Name = "itemsIDDataGridViewTextBoxColumn";
            this.itemsIDDataGridViewTextBoxColumn.Width = 20;
            // 
            // ucPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucAddNewPlace1);
            this.Controls.Add(this.lblDiaryEntries);
            this.Controls.Add(this.lblPersons);
            this.Controls.Add(this.dbgrdDiary);
            this.Controls.Add(this.dbgrdPersons);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "ucPersons";
            this.Size = new System.Drawing.Size(1076, 646);
            this.Load += new System.EventHandler(this.ucPersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgrdPersons;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView dbgrdDiary;
        private System.Windows.Forms.BindingSource diaryBindingSource;
        private System.Windows.Forms.Label lblPersons;
        private System.Windows.Forms.Label lblDiaryEntries;
        private ucAddNewPlace ucAddNewPlace1;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Place1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alignementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diariesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingameDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleString;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn questsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsIDDataGridViewTextBoxColumn;
    }
}
