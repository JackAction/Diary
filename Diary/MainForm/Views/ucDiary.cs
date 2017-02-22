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
        }

        [Description("Binding Source für Diary."), Category("Data")]
        public BindingSource DataSourceDiary
        {
            get { return diaryBindingSource; }
            set { diaryBindingSource = value; }
            // Anstelle von personBindingSource geht auch dbgrdPersons. Was ist unterschied von direkt auf Datagrid binden oder auf bindingsource?
        }

        [Description("Neue Zeile wurde zu Diary DataGrid hinzugefügt."), Category("Data")]
        public event EventHandler DiaryRowAdded;

        private void dbgrdDiary_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DiaryRowAdded?.Invoke(sender, e);
        }
    }
}
