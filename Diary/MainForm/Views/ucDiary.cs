﻿using System;
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
            ucAddNewPlace1.PlaceAdded += new EventHandler(ucPlaceAdded);
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
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
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
    }
}
