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
    public partial class ucPersons : UserControl
    {
        public ucPersons()
        {
            InitializeComponent();
        }

        public object DataSourcePerson
        {
            get { return personBindingSource.DataSource; }
            set { personBindingSource.DataSource = value; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        private void ShowDiaryEntries()
        {
            Person obj = personBindingSource.Current as Person; // Erstellt ein Kundenobjekt mit den Daten der selektierten Reihe im KundenGrid
            if (obj != null)
            {
                if (obj.Diaries != null)
                {
                    diaryBindingSource.DataSource = obj.Diaries.ToList();
                }
            }
        }

        private void dbgrdPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowDiaryEntries();
            }
        }
    }
}
