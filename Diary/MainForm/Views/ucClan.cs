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
    public partial class ucClan : UserControl
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

        [Description("Neue Zeile wurde zu Clan DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler ClanRowAdded;

        private void dbgrdClans_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ClanRowAdded?.Invoke(sender, e);
        }

        private void ShowMembers()
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

        private void ShowDiaryEntries()
        {
            if (personBindingSource.Count > 0)
            {
                Person obj = personBindingSource.List[0] as Person; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
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

        private void ucClan_Load(object sender, EventArgs e)
        {
            ShowMembers();
            ShowDiaryEntries();
        }

    }
}
