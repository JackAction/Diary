using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ucDiary : ucBase
    {
        public ucDiary()
        {
            InitializeComponent();
            ucAddNewItem.Type = "Item";
            ucAddNewQuest.Type = "Quest";
            ucAddNewPlace1.PlaceAdded += new EventHandler(ucPlaceAdded);
            ucAddNewItem.SingleItemAdded += new EventHandler(ucItemAdded);
            ucAddNewQuest.SingleItemAdded += new EventHandler(ucQuestAdded);
            cbxFilterColumn.SelectedIndex = 2;
        }

        [Description("Binding Source für Diary."), Category("Data")]
        public BindingSource DataSourceDiary
        {
            get { return diaryBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Binding Source für Place."), Category("Data")]
        public BindingSource DataSourcePlace
        {
            get { return placeBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Binding Source für Item."), Category("Data")]
        public BindingSource DataSourceItem
        {
            get { return itemBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Binding Source für Quest."), Category("Data")]
        public BindingSource DataSourceQuest
        {
            get { return questBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

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
                return ucAddNewPlace1.NewPlace;
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





        private void button1_Click(object sender, EventArgs e)
        {
            dbgrdDiary.ClearSelection();
            dbgrdDiary.Rows[1].Selected = false;
            dbgrdDiary.Rows[2].Selected = true;
            dbgrdDiary.CurrentCell = dbgrdDiary[0, 0];
            dbgrdDiary.Rows[1].Visible = false;
        }

        private void dbgrdDiary_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Session ID muss eine Nummer sein.", "Parse error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [Description("Personen zu einem Diary Eintrag ändern."), Category("Data")]
        public event EventHandler ChangePeopleOfDiaryEntry;

        private void dbgrdDiary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgrdDiary.Columns[e.ColumnIndex].Name == "PeopleString" && e.RowIndex >= 0)
            {
                ChangePeopleOfDiaryEntry?.Invoke(sender, e);
            }
        }

        private List<Diary> diaryList;

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
            dbgrdDiary.CurrentCell = dbgrdDiary[0, dbgrdDiary.RowCount-1]; //Benötigt, damit CurrencyMangerfehler nicht auftritt (aktuelle row kann nicht ausgeblendet werrden).
            foreach (DataGridViewRow row in dbgrdDiary.Rows)
            {
                if (row.Index != dbgrdDiary.RowCount - 1)
                {
                    row.Visible = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if ((cell.Value ?? "").ToString().Contains(searchText))
                        {
                            row.Visible = true;
                        }
                    }
                }
            }
        }

        private void dbgrdDiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgrdDiary.Columns[e.ColumnIndex].Name == "Delete")
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
    }
}
