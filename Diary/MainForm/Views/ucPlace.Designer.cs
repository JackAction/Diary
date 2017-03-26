﻿namespace MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.lblDiaryEntries = new System.Windows.Forms.Label();
            this.dbgrdDiary = new System.Windows.Forms.DataGridView();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingameDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.questBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.diaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbgrdPlaces = new System.Windows.Forms.DataGridView();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ucPicture1 = new MainForm.ucPicture();
            this.cbxFilterColumn = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.continentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletePlace = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dbgrdDiary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dbgrdDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdDiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionIDDataGridViewTextBoxColumn,
            this.ingameDayDataGridViewTextBoxColumn,
            this.entryDataGridViewTextBoxColumn,
            this.PeopleString,
            this.itemsIDDataGridViewTextBoxColumn,
            this.questsIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.placeIDDataGridViewTextBoxColumn,
            this.Delete});
            this.dbgrdDiary.DataSource = this.diaryBindingSource;
            this.dbgrdDiary.Location = new System.Drawing.Point(68, 65);
            this.dbgrdDiary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dbgrdDiary.Name = "dbgrdDiary";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrdDiary.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dbgrdDiary.Size = new System.Drawing.Size(848, 231);
            this.dbgrdDiary.TabIndex = 4;
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
            // PeopleString
            // 
            this.PeopleString.DataPropertyName = "PeopleString";
            this.PeopleString.HeaderText = "People";
            this.PeopleString.Name = "PeopleString";
            this.PeopleString.ReadOnly = true;
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
            // dbgrdPlaces
            // 
            this.dbgrdPlaces.AutoGenerateColumns = false;
            this.dbgrdPlaces.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dbgrdPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrdPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.continentDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.buildingDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.comment2DataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.DeletePlace});
            this.dbgrdPlaces.DataSource = this.placeBindingSource;
            this.dbgrdPlaces.Location = new System.Drawing.Point(21, 343);
            this.dbgrdPlaces.Name = "dbgrdPlaces";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrdPlaces.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dbgrdPlaces.Size = new System.Drawing.Size(981, 235);
            this.dbgrdPlaces.TabIndex = 0;
            this.dbgrdPlaces.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPlaces_CellClick);
            this.dbgrdPlaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPlaces_CellContentClick);
            this.dbgrdPlaces.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdPlaces_RowsAdded);
            this.dbgrdPlaces.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgrdPlaces_KeyDown);
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(MainForm.Place);
            // 
            // ucPicture1
            // 
            this.ucPicture1.Filename = null;
            this.ucPicture1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPicture1.Location = new System.Drawing.Point(939, 16);
            this.ucPicture1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPicture1.Name = "ucPicture1";
            this.ucPicture1.Size = new System.Drawing.Size(267, 305);
            this.ucPicture1.TabIndex = 7;
            // 
            // cbxFilterColumn
            // 
            this.cbxFilterColumn.FormattingEnabled = true;
            this.cbxFilterColumn.Items.AddRange(new object[] {
            "All",
            "Continent",
            "City",
            "District",
            "Building",
            "Name",
            "Comment",
            "Details"});
            this.cbxFilterColumn.Location = new System.Drawing.Point(224, 309);
            this.cbxFilterColumn.Name = "cbxFilterColumn";
            this.cbxFilterColumn.Size = new System.Drawing.Size(121, 28);
            this.cbxFilterColumn.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(351, 311);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 26);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            // DeletePlace
            // 
            this.DeletePlace.DataPropertyName = "ID";
            this.DeletePlace.HeaderText = "Delete";
            this.DeletePlace.Name = "DeletePlace";
            this.DeletePlace.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeletePlace.Text = "X";
            this.DeletePlace.UseColumnTextForButtonValue = true;
            this.DeletePlace.Width = 70;
            // 
            // ucPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxFilterColumn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ucPicture1);
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.lblDiaryEntries);
            this.Controls.Add(this.dbgrdDiary);
            this.Controls.Add(this.dbgrdPlaces);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "ucPlace";
            this.Size = new System.Drawing.Size(1246, 621);
            this.Load += new System.EventHandler(this.ucPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource questBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingameDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleString;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn questsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private ucPicture ucPicture1;
        private System.Windows.Forms.ComboBox cbxFilterColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn continentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeletePlace;
    }
}
