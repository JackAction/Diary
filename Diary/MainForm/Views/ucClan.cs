using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MainForm
{
    public partial class ucClan : ucBase
    {
        private List<Clan> ClanList;

        public ucClan()
        {
            InitializeComponent();
            ucPicture1.PictureAdded += new EventHandler(PictureAdded);
            cbxFilterColumn.SelectedIndex = 1; // Initialfeld für Filter
        }

        #region DataSources

        [Description("Binding Source für ClanGrid."), Category("Data")]
        public BindingSource DataSourceClan
        {
            get { return clanBindingSource; }
        }

        [Description("Binding Source für PersonGrid."), Category("Data")]
        public BindingSource DataSourcePerson
        {
            get { return personBindingSource; }
        }

        #endregion

        #region Handle creation of new Model Entries

        [Description("Neue Zeile wurde zu Clan DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler ClanRowAdded;

        private void dbgrdClans_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            bool newRowAddedByUser = e.RowIndex > clanBindingSource.Count - 1 ? true : false;
            if (newRowAddedByUser)
            {
                ClanRowAdded?.Invoke(sender, e);
            }
        }

        [Description("Neue Zeile wurde zu Person DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler PersonRowAdded;

        private void dbgrdPersons_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            LinkNewlyAddedPersonRowToCurrentClan(sender, e);
        }

        private void LinkNewlyAddedPersonRowToCurrentClan(object sender, DataGridViewRowsAddedEventArgs e)
        {
            bool newRowAddedByUser = e.RowIndex > personBindingSource.Count - 1 ? true : false;
            if (newRowAddedByUser)
            {
                Clan obj = clanBindingSource.Current as Clan;
                if (obj != null)
                {
                    if (personBindingSource.Current != null)
                    {
                        ((Person)personBindingSource.Current).Clan = obj;
                    }
                }
                PersonRowAdded?.Invoke(sender, e);
            }
        }

        #endregion

        #region Handle deletion of Model Entries

        private void dbgrdPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgrdPersons.Columns[e.ColumnIndex].Name == "DeletePerson" && e.RowIndex >= 0)
            {
                personRowDeleted(sender, e);
            }
        }

        private void dbgrdPersons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                personRowDeleted(sender, e);
            }
        }

        [Description("Zeile wurde aus Person DataGrid gelöscht."), Category("Data")]
        public event EventHandler PersonRowDeleted;

        private void personRowDeleted(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wirklich löschen?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PersonRowDeleted?.Invoke(sender, e);
                personBindingSource.RemoveCurrent();
                ShowDiaryEntries();
            }
        }

        private void dbgrdClans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgrdClans.Columns[e.ColumnIndex].Name == "DeleteClan" && e.RowIndex >= 0)
            {
                clanRowDeleted(sender, e);
            }
        }

        private void dbgrdClans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                clanRowDeleted(sender, e);
            }
        }

        [Description("Zeile wurde aus Clan DataGrid gelöscht."), Category("Data")]
        public event EventHandler ClanRowDeleted;

        private void clanRowDeleted(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wirklich löschen?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClanRowDeleted?.Invoke(sender, e);
                clanBindingSource.RemoveCurrent();
                ShowMembers();
                ShowDiaryEntries();
            }
        }

        #endregion

        #region Search and filter functions

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (ClanList == null)
            {
                ClanList = DataSourceClan.DataSource as List<Clan>;
            }

            if (string.IsNullOrEmpty((sender as TextBox).Text))
            {
                DataSourceClan.DataSource = ClanList;
                foreach (DataGridViewRow row in dbgrdClans.Rows)
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
                    List<Clan> query =
                        ClanList.FindAll(delegate (Clan obj)
                        {
                            switch (cbxFilterColumn.SelectedItem.ToString())
                            {
                                case "Name":
                                    if (obj.Name == null)
                                    {
                                        return false;
                                    }
                                    return obj.Name.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                case "Details":
                                    if (obj.Details == null)
                                    {
                                        return false;
                                    }
                                    return obj.Details.IndexOf((sender as TextBox).Text, StringComparison.OrdinalIgnoreCase) >= 0;
                                default:
                                    return false;
                            }
                        });
                    DataSourceClan.DataSource = query;
                }
            }
        }

        private void FullTextSearch(string searchText)
        {
            dbgrdClans.CurrentCell = dbgrdClans[0, dbgrdClans.RowCount - 1]; //Benötigt, damit CurrencyMangerfehler nicht auftritt (aktuelle row kann nicht ausgeblendet werrden).
            foreach (DataGridViewRow row in dbgrdClans.Rows)
            {
                if (row.Index != dbgrdClans.RowCount - 1)
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

        #region Refresh data dependant of primary DGV selection

        private void dbgrdClans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowMembers();
                ShowDiaryEntries();
                ShowPicture();
            }
        }

        private void dbgrdPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowDiaryEntries();
            }
        }

        public void ShowMembers()
        {
            Clan obj = clanBindingSource.Current as Clan;
            if (obj != null)
            {
                if (obj.People != null)
                {
                    personBindingSource.DataSource = obj.People.ToList();
                }
            }
            else
            {
                personBindingSource.DataSource = null;
            }
        }

        public void ShowDiaryEntries()
        {
            if (personBindingSource.Count > 0)
            {
                Person obj = personBindingSource.Current as Person;
                if (obj.Diaries != null)
                {
                    diaryBindingSource.DataSource = obj.Diaries.ToList();
                }
            }
            else
            {
                diaryBindingSource.DataSource = null;
            }
        }

        public void ShowPicture()
        {
            Clan obj = clanBindingSource.Current as Clan;
            if (obj != null)
            {
                ucPicture1.Image = obj.Picture;
            }
        }

        #endregion

        private void ucClan_Load(object sender, EventArgs e)
        {
            ShowMembers();
            ShowDiaryEntries();
            ShowPicture();
        }

        private void PictureAdded(object sender, EventArgs e)
        {
            (clanBindingSource.Current as Clan).Picture = ucPicture1.Image;
        }
    }
}
