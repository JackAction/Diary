namespace MainForm
{
    partial class ucDiary
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
            this.cbxFilterColumn = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblDiaryEntries = new System.Windows.Forms.Label();
            this.dbgrdDiary = new System.Windows.Forms.DataGridView();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucAddNewQuest = new MainForm.ucNewSingleItem();
            this.ucAddNewItem = new MainForm.ucNewSingleItem();
            this.ucAddNewPlace = new MainForm.ucAddNewPlace();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingameDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeopleString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.questsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxFilterColumn
            // 
            this.cbxFilterColumn.FormattingEnabled = true;
            this.cbxFilterColumn.Items.AddRange(new object[] {
            "All",
            "SessionID",
            "IngameDay",
            "Entry",
            "People",
            "Place",
            "Item",
            "Quest"});
            this.cbxFilterColumn.Location = new System.Drawing.Point(232, 790);
            this.cbxFilterColumn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbxFilterColumn.Name = "cbxFilterColumn";
            this.cbxFilterColumn.Size = new System.Drawing.Size(186, 37);
            this.cbxFilterColumn.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(429, 793);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(418, 35);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblDiaryEntries
            // 
            this.lblDiaryEntries.AutoSize = true;
            this.lblDiaryEntries.Location = new System.Drawing.Point(5, 44);
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
            this.placeIDDataGridViewTextBoxColumn,
            this.itemsIDDataGridViewTextBoxColumn,
            this.questsIDDataGridViewTextBoxColumn,
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
            this.dbgrdDiary.Location = new System.Drawing.Point(0, 80);
            this.dbgrdDiary.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dbgrdDiary.Name = "dbgrdDiary";
            this.dbgrdDiary.Size = new System.Drawing.Size(1927, 484);
            this.dbgrdDiary.TabIndex = 0;
            this.dbgrdDiary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdDiary_CellClick);
            this.dbgrdDiary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgrdDiary_CellContentClick);
            this.dbgrdDiary.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dbgrdDiary_DataError);
            this.dbgrdDiary.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbgrdDiary_RowsAdded);
            this.dbgrdDiary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dbgrdDiary_KeyDown);
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataSource = typeof(MainForm.Place);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Place";
            this.dataGridViewTextBoxColumn1.HeaderText = "Place";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // ucAddNewQuest
            // 
            this.ucAddNewQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAddNewQuest.Location = new System.Drawing.Point(1454, 793);
            this.ucAddNewQuest.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucAddNewQuest.Name = "ucAddNewQuest";
            this.ucAddNewQuest.Size = new System.Drawing.Size(473, 87);
            this.ucAddNewQuest.TabIndex = 11;
            this.ucAddNewQuest.Type = null;
            // 
            // ucAddNewItem
            // 
            this.ucAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAddNewItem.Location = new System.Drawing.Point(1454, 692);
            this.ucAddNewItem.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucAddNewItem.Name = "ucAddNewItem";
            this.ucAddNewItem.Size = new System.Drawing.Size(473, 87);
            this.ucAddNewItem.TabIndex = 10;
            this.ucAddNewItem.Type = null;
            // 
            // ucAddNewPlace
            // 
            this.ucAddNewPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAddNewPlace.Location = new System.Drawing.Point(358, 597);
            this.ucAddNewPlace.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ucAddNewPlace.Name = "ucAddNewPlace";
            this.ucAddNewPlace.Size = new System.Drawing.Size(1570, 80);
            this.ucAddNewPlace.TabIndex = 7;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(MainForm.Person);
            // 
            // clanBindingSource
            // 
            this.clanBindingSource.DataSource = typeof(MainForm.Clan);
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
            this.ingameDayDataGridViewTextBoxColumn.Width = 170;
            // 
            // entryDataGridViewTextBoxColumn
            // 
            this.entryDataGridViewTextBoxColumn.DataPropertyName = "Entry";
            this.entryDataGridViewTextBoxColumn.HeaderText = "Entry";
            this.entryDataGridViewTextBoxColumn.Name = "entryDataGridViewTextBoxColumn";
            this.entryDataGridViewTextBoxColumn.Width = 370;
            // 
            // PeopleString
            // 
            this.PeopleString.DataPropertyName = "PeopleString";
            this.PeopleString.HeaderText = "People";
            this.PeopleString.Name = "PeopleString";
            this.PeopleString.ReadOnly = true;
            this.PeopleString.Width = 200;
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
            this.itemsIDDataGridViewTextBoxColumn.Width = 130;
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
            this.questsIDDataGridViewTextBoxColumn.Width = 130;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 70;
            // 
            // ucDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucAddNewQuest);
            this.Controls.Add(this.ucAddNewItem);
            this.Controls.Add(this.cbxFilterColumn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ucAddNewPlace);
            this.Controls.Add(this.lblDiaryEntries);
            this.Controls.Add(this.dbgrdDiary);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ucDiary";
            this.Size = new System.Drawing.Size(2077, 1092);
            ((System.ComponentModel.ISupportInitialize)(this.dbgrdDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgrdDiary;
        private System.Windows.Forms.BindingSource diaryBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Label lblDiaryEntries;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private ucAddNewPlace ucAddNewPlace;
        private System.Windows.Forms.BindingSource clanBindingSource;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbxFilterColumn;
        private ucNewSingleItem ucAddNewItem;
        private ucNewSingleItem ucAddNewQuest;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource questBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingameDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeopleString;
        private System.Windows.Forms.DataGridViewComboBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn questsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
