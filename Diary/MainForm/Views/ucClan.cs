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
        }

        [Description("Binding Source für Clan."), Category("Data")]
        public BindingSource DataSourceClan
        {
            get { return clanBindingSource; }
            set { clanBindingSource = value; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Binding Source für Person."), Category("Data")]
        public BindingSource DataSourcePerson
        {
            get { return personBindingSource; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
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
            if (e.RowIndex > personBindingSource.Count - 1)
            {
                Clan obj = clanBindingSource.Current as Clan; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
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

        private void dbgrdClans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowMembers();
                ShowDiaryEntries();
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
        }

        private void dbgrdPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbgrdPersons.Columns[e.ColumnIndex].Name == "DeletePerson")
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
    }
}
