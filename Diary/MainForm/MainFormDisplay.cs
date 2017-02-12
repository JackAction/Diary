using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainFormDisplay : Form
    {
        dnd_hotdqEntities db;
        DBHelper dbHelper;
        public MainFormDisplay()
        {
            InitializeComponent();
        }

        private void MainFormDisplay_Load(object sender, EventArgs e)
        {
            dbHelper = new DBHelper();

        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            dbHelper.BackupDB();
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            try
            {
                db = new dnd_hotdqEntities(dbHelper.BuildConnectionString());
                ucPersons1.DataSourcePerson = db.People.ToList(); //Wird include benötitg? .Include("Clan")
                ucDiary1.DataSourceDiary = db.Diaries.ToList();
                ucClan1.DataSourceClan = db.Clans.ToList();
            }
            catch (Exception)
            {

                MessageBox.Show("Datenbankverbindung konnte nicht hergestellt werden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadDBBackup_Click(object sender, EventArgs e)
        {
            dbHelper.RestoreDB();
            btnLoadDB_Click(null,null);
        }
    }
}
