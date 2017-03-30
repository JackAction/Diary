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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxFilterColumn = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ucPicture1 = new MainForm.ucPicture();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.lblDiaryEntries = new System.Windows.Forms.Label();
            this.dbgrdDiary = new System.Windows.Forms.DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbgrdPlaces = new System.Windows.Forms.DataGridView();
            this.continentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletePlace = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingameDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.questsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(1588, 464);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(87, 29);
            this.lblDetails.TabIndex = 16;
            this.lblDetails.Text = "Details";
            // 
            // txtDetails
            // 
            this.txtDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.placeBindingSource, "Details", true));
            this.txtDetails.Location = new System.Drawing.Point(1594, 497);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(279, 349);
            this.txtDetails.TabIndex = 13;
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(MainForm.Place);
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
            this.cbxFilterColumn.Location = new System.Drawing.Point(348, 448);
            this.cbxFilterColumn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbxFilterColumn.Name = "cbxFilterColumn";
            this.cbxFilterColumn.Size = new System.Drawing.Size(186, 37);
            this.cbxFilterColumn.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(546, 451);
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
            this.ucPicture1.Location = new System.Drawing.Point(1461, 23);
            this.ucPicture1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucPicture1.Name = "ucPicture1";
            this.ucPicture1.Size = new System.Drawing.Size(415, 442);
            this.ucPicture1.TabIndex = 7;
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.Location = new System.Drawing.Point(26, 464);
            this.lblPlaces.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(86, 29);
            this.lblPlaces.TabIndex = 6;
            this.lblPlaces.Text = "Places";
            // 
            // lblDiaryEntries
            // 
            this.lblDiaryEntries.AutoSize = true;
            this.lblDiaryEntries.Location = new System.Drawing.Point(100, 58);
            this.lblDiaryEntries.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiaryEntries.Name = "lblDiaryEntries";
            this.lblDiaryEntries.Size = new System.Drawing.Size(149, 29);
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
            this.Delete});
            this.dbgrdDiary.DataSource = this.diaryBindingSource;
            this.dbgrdDiary.Location = new System.Drawing.Point(106, 94);
            this.dbgrdDiary.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dbgrdDiary.Name = "dbgrdDiary";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrdDiary.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dbgrdDiary.Size = new System.Drawing.Size(1319, 335);
            this.dbgrdDiary.TabIndex = 4;
            this.dbgrdDiary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdDiary_CellContentClick);
            this.dbgrdDiary.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dbgrdDiary_DataError);
            this.dbgrdDiary.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdDiary_RowsAdded);
            this.dbgrdDiary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgrdDiary_KeyDown);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(MainForm.Item);
            // 
            // questBindingSource
            // 
            this.questBindingSource.DataSource = typeof(MainForm.Quest);
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
            this.DeletePlace});
            this.dbgrdPlaces.DataSource = this.placeBindingSource;
            this.dbgrdPlaces.Location = new System.Drawing.Point(33, 497);
            this.dbgrdPlaces.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dbgrdPlaces.Name = "dbgrdPlaces";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgrdPlaces.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dbgrdPlaces.Size = new System.Drawing.Size(1526, 341);
            this.dbgrdPlaces.TabIndex = 0;
            this.dbgrdPlaces.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPlaces_CellClick);
            this.dbgrdPlaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdPlaces_CellContentClick);
            this.dbgrdPlaces.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdPlaces_RowsAdded);
            this.dbgrdPlaces.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgrdPlaces_KeyDown);
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
            this.comment2DataGridViewTextBoxColumn.HeaderText = "Comment";
            this.comment2DataGridViewTextBoxColumn.Name = "comment2DataGridViewTextBoxColumn";
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
            // sessionIDDataGridViewTextBoxColumn
            // 
            this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "SessionID";
            this.sessionIDDataGridViewTextBoxColumn.HeaderText = "S";
            this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            this.sessionIDDataGridViewTextBoxColumn.Width = 30;
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
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 70;
            // 
            // ucPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.cbxFilterColumn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ucPicture1);
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.lblDiaryEntries);
            this.Controls.Add(this.dbgrdDiary);
            this.Controls.Add(this.dbgrdPlaces);
            this.Margin = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.Name = "ucPlace";
            this.Size = new System.Drawing.Size(1938, 900);
            this.Load += new System.EventHandler(this.ucPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdPlaces)).EndInit();
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
        private ucPicture ucPicture1;
        private System.Windows.Forms.ComboBox cbxFilterColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn continentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeletePlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingameDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleString;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn questsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
