using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ucDiary : ucBase
    {
        private List<Diary> diaryList;

        public ucDiary()
        {
            InitializeComponent();
            ucAddNewPlace.PlaceAdded += new EventHandler(ucPlaceAdded);
            ucAddNewItem.SingleItemAdded += new EventHandler(ucItemAdded);
            ucAddNewQuest.SingleItemAdded += new EventHandler(ucQuestAdded);
            cbxFilterColumn.SelectedIndex = 3; // Initialfeld für Filter
        }

        #region DataSources

        [Description("Binding Source für DiaryGrid."), Category("Data")]
        public BindingSource DataSourceDiary
        {
            get { return diaryBindingSource; }
        }

        [Description("Binding Source für PlaceColumn."), Category("Data")]
        public BindingSource DataSourcePlace
        {
            get { return placeBindingSource; }
        }

        [Description("Binding Source für ItemColumn."), Category("Data")]
        public BindingSource DataSourceItem
        {
            get { return itemBindingSource; }
        }

        [Description("Binding Source für QuestColumn."), Category("Data")]
        public BindingSource DataSourceQuest
        {
            get { return questBindingSource; }
        }

        #endregion

        #region Handle creation of new Model Entries 

        [Description("Neue Zeile wurde zu Diary DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler DiaryRowAdded;

        private void dbgrdDiary_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex > diaryBindingSource.Count - 1)
            {
                DiaryRowAdded?.Invoke(sender, e);
            }
        }

        [Description("New Place."), Category("Data")]
        public Place NewPlace
        {
            get
            {
                return ucAddNewPlace.NewPlace;
            }
        }

        [Description("Neuer Place wird hinzugefügt."), Category("Data")]
        public event EventHandler PlaceAdded;

        private void ucPlaceAdded(object sender, EventArgs e)
        {
            PlaceAdded?.Invoke(sender, e);
        }

        [Description("New Item."), Category("Data")]
        public Item NewItem
        {
            get
            {
                return ucAddNewItem.NewSingleItem as Item;
            }
        }

        [Description("Neues Item wird hinzugefügt."), Category("Data")]
        public event EventHandler ItemAdded;

        private void ucItemAdded(object sender, EventArgs e)
        {
            ItemAdded?.Invoke(sender, e);
        }

        [Description("New Quest."), Category("Data")]
        public Quest NewQuest
        {
            get
            {
                return ucAddNewQuest.NewSingleItem as Quest;
            }
        }

        [Description("Neuer Quest wird hinzugefügt."), Category("Data")]
        public event EventHandler QuestAdded;

        private void ucQuestAdded(object sender, EventArgs e)
        {
            QuestAdded?.Invoke(sender, e);
        }

        #endregion

        #region Handle deletion of Model Entries

        private void dbgrdDiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgrdDiary.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                diaryRowDeleted(sender, e);
            }
        }

        private void dbgrdDiary_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                diaryRowDeleted(sender, e);
            }
        }

        [Description("Zeile wurde aus Diary DataGrid gelöscht."), Category("Data")]
        public event EventHandler DiaryRowDeleted;

        private void diaryRowDeleted(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wirklich löschen?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DiaryRowDeleted?.Invoke(sender, e);
                diaryBindingSource.RemoveCurrent();
            }
        }

        #endregion

        #region Search and filter functions

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (diaryList == null)
            {
                diaryList = DataSourceDiary.DataSource as List<Diary>;
            }

            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                DataSourceDiary.DataSource = diaryList;
                foreach (DataGridViewRow row in dbgrdDiary.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                if (cbxFilterColumn.SelectedItem.ToString() == "All")
                {
                    FullTextSearch((sender as TextBox).Text);
                }
                else
                {
                    List<Diary> query =
                        diaryList.FindAll(delegate (Diary obj)
                        {
                            switch (cbxFilterColumn.SelectedItem.ToString())
                            {
                                case "SessionID":
                                    if (obj.SessionID == null)
                                    {
                                        return false;
                                    }
                                    return obj.SessionID.ToString().IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "IngameDay":
                                    if (obj.IngameDay == null)
                                    {
                                        return false;
                                    }
                                    return obj.IngameDay.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Entry":
                                    if (obj.Entry == null)
                                    {
                                        return false;
                                    }
                                    return obj.Entry.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "People":
                                    if (obj.PeopleString == null)
                                    {
                                        return false;
                                    }
                                    return obj.PeopleString.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Place":
                                    if (obj.Place == null)
                                    {
                                        return false;
                                    }
                                    return obj.Place.Name.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Item":
                                    if (obj.Item == null)
                                    {
                                        return false;
                                    }
                                    return obj.Item.Name.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Quest":
                                    if (obj.Quest == null)
                                    {
                                        return false;
                                    }
                                    return obj.Quest.Name.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                default:
                                    return false;
                            }
                        });
                    DataSourceDiary.DataSource = query;
                }
            }
        }

        private void FullTextSearch(string searchText)
        {
            dbgrdDiary.CurrentCell = dbgrdDiary[0, dbgrdDiary.RowCount - 1]; //Benötigt, damit CurrencyMangerfehler nicht auftritt (aktuelle row kann nicht ausgeblendet werrden).
            foreach (DataGridViewRow row in dbgrdDiary.Rows)
            {
                if (row.Index != dbgrdDiary.RowCount - 1)
                {
                    row.Visible = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if ((cell.Value ?? "").ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            row.Visible = true;
                        }
                    }
                }
            }
        }

        #endregion


        private void dbgrdDiary_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            RaiseErrorMessageForSessionID(sender, e);
        }

        [Description("Personen zu einem Diary Eintrag ändern/hinzufügen."), Category("Data")]
        public event EventHandler ChangePersonModeTo_DiaryDetailEdit;

        private void dbgrdDiary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (dbgrdDiary.Columns[e.ColumnIndex].Name == "PeopleString" && e.RowIndex >= 0)
                {
                    ChangePersonModeTo_DiaryDetailEdit?.Invoke(sender, e);
                } 
            }
        }

        private void dbgrdDiary_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ActivateComboBoxOnFirstClick(sender, e);
        }

    }
}
