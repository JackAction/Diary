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
            this.dbgrdDiary = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingameDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alignementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diariesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbgrdPersons
            // 
            this.dbgrdPersons.AutoGenerateColumns = false;
            this.dbgrdPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.clanIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.raceDataGridViewTextBoxColumn,
            this.deadDataGridViewTextBoxColumn,
            this.alignementDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.comment2DataGridViewTextBoxColumn,
            this.clanDataGridViewTextBoxColumn,
            this.diariesDataGridViewTextBoxColumn});
            this.dbgrdPersons.DataSource = this.personBindingSource;
            this.dbgrdPersons.Location = new System.Drawing.Point(28, 199);
            this.dbgrdPersons.Name = "dbgrdPersons";
            this.dbgrdPersons.Size = new System.Drawing.Size(622, 242);
            this.dbgrdPersons.TabIndex = 0;
            this.dbgrdPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPersons_CellClick);
            // 
            // dbgrdDiary
            // 
            this.dbgrdDiary.AutoGenerateColumns = false;
            this.dbgrdDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdDiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.placeIDDataGridViewTextBoxColumn,
            this.questsIDDataGridViewTextBoxColumn,
            this.itemsIDDataGridViewTextBoxColumn,
            this.sessionIDDataGridViewTextBoxColumn,
            this.ingameDayDataGridViewTextBoxColumn,
            this.entryDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.questDataGridViewTextBoxColumn,
            this.peopleDataGridViewTextBoxColumn});
            this.dbgrdDiary.DataSource = this.diaryBindingSource;
            this.dbgrdDiary.Location = new System.Drawing.Point(58, 21);
            this.dbgrdDiary.Name = "dbgrdDiary";
            this.dbgrdDiary.Size = new System.Drawing.Size(565, 150);
            this.dbgrdDiary.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // placeIDDataGridViewTextBoxColumn
            // 
            this.placeIDDataGridViewTextBoxColumn.DataPropertyName = "Place_ID";
            this.placeIDDataGridViewTextBoxColumn.HeaderText = "Place_ID";
            this.placeIDDataGridViewTextBoxColumn.Name = "placeIDDataGridViewTextBoxColumn";
            // 
            // questsIDDataGridViewTextBoxColumn
            // 
            this.questsIDDataGridViewTextBoxColumn.DataPropertyName = "Quests_ID";
            this.questsIDDataGridViewTextBoxColumn.HeaderText = "Quests_ID";
            this.questsIDDataGridViewTextBoxColumn.Name = "questsIDDataGridViewTextBoxColumn";
            // 
            // itemsIDDataGridViewTextBoxColumn
            // 
            this.itemsIDDataGridViewTextBoxColumn.DataPropertyName = "Items_ID";
            this.itemsIDDataGridViewTextBoxColumn.HeaderText = "Items_ID";
            this.itemsIDDataGridViewTextBoxColumn.Name = "itemsIDDataGridViewTextBoxColumn";
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "SessionID";
            this.sessionIDDataGridViewTextBoxColumn.HeaderText = "SessionID";
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
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // questDataGridViewTextBoxColumn
            // 
            this.questDataGridViewTextBoxColumn.DataPropertyName = "Quest";
            this.questDataGridViewTextBoxColumn.HeaderText = "Quest";
            this.questDataGridViewTextBoxColumn.Name = "questDataGridViewTextBoxColumn";
            // 
            // peopleDataGridViewTextBoxColumn
            // 
            this.peopleDataGridViewTextBoxColumn.DataPropertyName = "People";
            this.peopleDataGridViewTextBoxColumn.HeaderText = "People";
            this.peopleDataGridViewTextBoxColumn.Name = "peopleDataGridViewTextBoxColumn";
            // 
            // diaryBindingSource
            // 
            this.diaryBindingSource.DataSource = typeof(MainForm.Diary);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // clanIDDataGridViewTextBoxColumn
            // 
            this.clanIDDataGridViewTextBoxColumn.DataPropertyName = "Clan_ID";
            this.clanIDDataGridViewTextBoxColumn.HeaderText = "Clan_ID";
            this.clanIDDataGridViewTextBoxColumn.Name = "clanIDDataGridViewTextBoxColumn";
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
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "Details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // comment2DataGridViewTextBoxColumn
            // 
            this.comment2DataGridViewTextBoxColumn.DataPropertyName = "Comment_2";
            this.comment2DataGridViewTextBoxColumn.HeaderText = "Comment_2";
            this.comment2DataGridViewTextBoxColumn.Name = "comment2DataGridViewTextBoxColumn";
            // 
            // clanDataGridViewTextBoxColumn
            // 
            this.clanDataGridViewTextBoxColumn.DataPropertyName = "Clan";
            this.clanDataGridViewTextBoxColumn.HeaderText = "Clan";
            this.clanDataGridViewTextBoxColumn.Name = "clanDataGridViewTextBoxColumn";
            // 
            // diariesDataGridViewTextBoxColumn
            // 
            this.diariesDataGridViewTextBoxColumn.DataPropertyName = "Diaries";
            this.diariesDataGridViewTextBoxColumn.HeaderText = "Diaries";
            this.diariesDataGridViewTextBoxColumn.Name = "diariesDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(MainForm.Person);
            // 
            // ucPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dbgrdDiary);
            this.Controls.Add(this.dbgrdPersons);
            this.Name = "ucPersons";
            this.Size = new System.Drawing.Size(717, 468);
            this.Load += new System.EventHandler(this.ucPersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgrdPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alignementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diariesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView dbgrdDiary;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingameDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource diaryBindingSource;
    }
}
