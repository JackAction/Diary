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
    public partial class ucClan : ucBase
    {
        public ucClan()
        {
            InitializeComponent();
            ucPicture1.PictureAdded += new EventHandler(PictureAdded);
            cbxFilterColumn.SelectedIndex = 1; // Initialfeld für Filter
        }

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

        [Description("Neue Zeile wurde zu Clan DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler ClanRowAdded;

        private void dbgrdClans_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex > clanBindingSource.Count - 1)
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
            if (e.RowIndex > personBindingSource.Count - 1)
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

        public void ShowMembers()
        {
            Clan obj = clanBindingSource.Current as Clan; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
            if (obj != null)
            {
                if (obj.People != null)
                {
                    personBindingSource.DataSource = obj.People.ToList();
                }
            }
        }

        public void ShowDiaryEntries()
        {
            if (personBindingSource.Count > 0)
            {
                Person obj = personBindingSource.Current as Person; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
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
            Clan obj = clanBindingSource.Current as Clan; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
            if (obj != null)
            {
                ucPicture1.Image = obj.Picture;
            }
        }

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

        private void ucClan_Load(object sender, EventArgs e)
        {
            ShowMembers();
            ShowDiaryEntries();
            ShowPicture();
        }

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
            }
        }

        private void PictureAdded(object sender, EventArgs e)
        {
            (clanBindingSource.Current as Clan).Picture = ucPicture1.Image;
        }

        private List<Clan> ClanList;

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
    }
}
