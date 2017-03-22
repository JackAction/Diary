namespace MainForm
{
    partial class ucPlace
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
            this.dbgrdPlaces = new System.Windows.Forms.DataGridView();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDiaryEntries = new System.Windows.Forms.Label();
            this.dbgrdDiary = new System.Windows.Forms.DataGridView();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingameDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPlaces = new System.Windows.Forms.Label();
            this.continentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbgrdPlaces
            // 
            this.dbgrdPlaces.AutoGenerateColumns = false;
            this.dbgrdPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.continentDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.buildingDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.comment2DataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn1});
            this.dbgrdPlaces.DataSource = this.placeBindingSource;
            this.dbgrdPlaces.Location = new System.Drawing.Point(21, 343);
            this.dbgrdPlaces.Name = "dbgrdPlaces";
            this.dbgrdPlaces.Size = new System.Drawing.Size(981, 235);
            this.dbgrdPlaces.TabIndex = 0;
            this.dbgrdPlaces.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPlaces_CellClick);
            this.dbgrdPlaces.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdPlaces_RowsAdded);
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(MainForm.Place);
            // 
            // lblDiaryEntries
            // 
            this.lblDiaryEntries.AutoSize = true;
            this.lblDiaryEntries.Location = new System.Drawing.Point(64, 40);
            this.lblDiaryEntries.Name = "lblDiaryEntries";
            this.lblDiaryEntries.Size = new System.Drawing.Size(99, 20);
            this.lblDiaryEntries.TabIndex = 5;
            this.lblDiaryEntries.Text = "Diary Entries";
            // 
            // dbgrdDiary
            // 
            this.dbgrdDiary.AutoGenerateColumns = false;
            this.dbgrdDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdDiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionIDDataGridViewTextBoxColumn,
            this.ingameDayDataGridViewTextBoxColumn,
            this.entryDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.questDataGridViewTextBoxColumn,
            this.PeopleString,
            this.iDDataGridViewTextBoxColumn,
            this.placeIDDataGridViewTextBoxColumn,
            this.questsIDDataGridViewTextBoxColumn,
            this.itemsIDDataGridViewTextBoxColumn});
            this.dbgrdDiary.DataSource = this.diaryBindingSource;
            this.dbgrdDiary.Location = new System.Drawing.Point(68, 65);
            this.dbgrdDiary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbgrdDiary.Name = "dbgrdDiary";
            this.dbgrdDiary.Size = new System.Drawing.Size(848, 231);
            this.dbgrdDiary.TabIndex = 4;
            this.dbgrdDiary.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dbgrdDiary_DataError);
            this.dbgrdDiary.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdDiary_RowsAdded);
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "SessionID";
            this.sessionIDDataGridViewTextBoxColumn.HeaderText = "S";
            this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            this.sessionIDDataGridViewTextBoxColumn.Width = 20;
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
            // questDataGridViewTextBoxColumn
            // 
            this.questDataGridViewTextBoxColumn.DataPropertyName = "Quest";
            this.questDataGridViewTextBoxColumn.HeaderText = "Quest";
            this.questDataGridViewTextBoxColumn.Name = "questDataGridViewTextBoxColumn";
            // 
            // PeopleString
            // 
            this.PeopleString.DataPropertyName = "PeopleString";
            this.PeopleString.HeaderText = "People";
            this.PeopleString.Name = "PeopleString";
            this.PeopleString.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 20;
            // 
            // placeIDDataGridViewTextBoxColumn
            // 
            this.placeIDDataGridViewTextBoxColumn.DataPropertyName = "Place_ID";
            this.placeIDDataGridViewTextBoxColumn.HeaderText = "Place_ID";
            this.placeIDDataGridViewTextBoxColumn.Name = "placeIDDataGridViewTextBoxColumn";
            this.placeIDDataGridViewTextBoxColumn.Width = 20;
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
            // diaryBindingSource
            // 
            this.diaryBindingSource.DataSource = typeof(MainForm.Diary);
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.Location = new System.Drawing.Point(17, 320);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(56, 20);
            this.lblPlaces.TabIndex = 6;
            this.lblPlaces.Text = "Places";
            // 
            // continentDataGridViewTextBoxColumn
            // 
            this.continentDataGridViewTextBoxColumn.DataPropertyName = "Continent";
            this.continentDataGridViewTextBoxColumn.HeaderText = "Continent";
            this.continentDataGridViewTextBoxColumn.Name = "continentDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "District";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            // 
            // buildingDataGridViewTextBoxColumn
            // 
            this.buildingDataGridViewTextBoxColumn.DataPropertyName = "Building";
            this.buildingDataGridViewTextBoxColumn.HeaderText = "Building";
            this.buildingDataGridViewTextBoxColumn.Name = "buildingDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Width = 20;
            // 
            // ucPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.lblDiaryEntries);
            this.Controls.Add(this.dbgrdDiary);
            this.Controls.Add(this.dbgrdPlaces);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "ucPlace";
            this.Size = new System.Drawing.Size(1038, 621);
            this.Load += new System.EventHandler(this.ucPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgrdPlaces;
        private System.Windows.Forms.Label lblDiaryEntries;
        private System.Windows.Forms.DataGridView dbgrdDiary;
        private System.Windows.Forms.BindingSource diaryBindingSource;
        private System.Windows.Forms.Label lblPlaces;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingameDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleString;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn continentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
    }
}
