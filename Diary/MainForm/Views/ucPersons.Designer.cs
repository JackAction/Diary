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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDiaryEntries = new System.Windows.Forms.Label();
            this.lblPersons = new System.Windows.Forms.Label();
            this.dbgrdDiary = new System.Windows.Forms.DataGridView();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingameDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.questBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.diaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbgrdPersons = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucAddNewPlace1 = new MainForm.ucAddNewPlace();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.raceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alignementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diariesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletePerson = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // lblPersons
            // 
            this.lblPersons.AutoSize = true;
            this.lblPersons.Location = new System.Drawing.Point(38, 281);
            this.lblPersons.Name = "lblPersons";
            this.lblPersons.Size = new System.Drawing.Size(67, 20);
            this.lblPersons.TabIndex = 2;
            this.lblPersons.Text = "Persons";
            // 
            // dbgrdDiary
            // 
            this.dbgrdDiary.AutoGenerateColumns = false;
            this.dbgrdDiary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dbgrdDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdDiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionIDDataGridViewTextBoxColumn,
            this.ingameDayDataGridViewTextBoxColumn,
            this.entryDataGridViewTextBoxColumn,
            this.PeopleString,
            this.placeIDDataGridViewTextBoxColumn,
            this.itemsIDDataGridViewTextBoxColumn,
            this.questsIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn1,
            this.Delete});
            this.dbgrdDiary.DataSource = this.diaryBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrdDiary.DefaultCellStyle = dataGridViewCellStyle1;
            this.dbgrdDiary.Location = new System.Drawing.Point(87, 32);
            this.dbgrdDiary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbgrdDiary.Name = "dbgrdDiary";
            this.dbgrdDiary.Size = new System.Drawing.Size(848, 231);
            this.dbgrdDiary.TabIndex = 1;
            this.dbgrdDiary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdDiary_CellContentClick);
            this.dbgrdDiary.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dbgrdDiary_DataError);
            this.dbgrdDiary.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdDiary_RowsAdded);
            this.dbgrdDiary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgrdDiary_KeyDown);
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
            // PeopleString
            // 
            this.PeopleString.DataPropertyName = "PeopleString";
            this.PeopleString.HeaderText = "People";
            this.PeopleString.Name = "PeopleString";
            this.PeopleString.ReadOnly = true;
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
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(MainForm.Place);
            // 
            // itemsIDDataGridViewTextBoxColumn
            // 
            this.itemsIDDataGridViewTextBoxColumn.DataPropertyName = "Items_ID";
            this.itemsIDDataGridViewTextBoxColumn.DataSource = this.itemBindingSource;
            this.itemsIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.itemsIDDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemsIDDataGridViewTextBoxColumn.Name = "itemsIDDataGridViewTextBoxColumn";
            this.itemsIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemsIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.itemsIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(MainForm.Item);
            // 
            // questsIDDataGridViewTextBoxColumn
            // 
            this.questsIDDataGridViewTextBoxColumn.DataPropertyName = "Quests_ID";
            this.questsIDDataGridViewTextBoxColumn.DataSource = this.questBindingSource;
            this.questsIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.questsIDDataGridViewTextBoxColumn.HeaderText = "Quest";
            this.questsIDDataGridViewTextBoxColumn.Name = "questsIDDataGridViewTextBoxColumn";
            this.questsIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.questsIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.questsIDDataGridViewTextBoxColumn.ValueMember = "ID";
            this.questsIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // questBindingSource
            // 
            this.questBindingSource.DataSource = typeof(MainForm.Quest);
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Width = 20;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 70;
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
            this.clanIDDataGridViewTextBoxColumn,
            this.DeletePerson});
            this.dbgrdPersons.DataSource = this.personBindingSource;
            this.dbgrdPersons.Location = new System.Drawing.Point(42, 306);
            this.dbgrdPersons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbgrdPersons.Name = "dbgrdPersons";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrdPersons.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dbgrdPersons.Size = new System.Drawing.Size(933, 255);
            this.dbgrdPersons.TabIndex = 0;
            this.dbgrdPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPersons_CellClick);
            this.dbgrdPersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPersons_CellContentClick);
            this.dbgrdPersons.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdPersons_RowsAdded);
            this.dbgrdPersons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgrdPersons_KeyDown);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(MainForm.Person);
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
            // DeletePerson
            // 
            this.DeletePerson.HeaderText = "Delete";
            this.DeletePerson.Name = "DeletePerson";
            this.DeletePerson.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeletePerson.Text = "X";
            this.DeletePerson.UseColumnTextForButtonValue = true;
            this.DeletePerson.Width = 70;
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
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource questBindingSource;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingameDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleString;
        private System.Windows.Forms.DataGridViewComboBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn questsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
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
        private System.Windows.Forms.DataGridViewButtonColumn DeletePerson;
    }
}
