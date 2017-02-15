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
                setDatasourcess();
            }
            catch (Exception)
            {

                MessageBox.Show("Datenbankverbindung konnte nicht hergestellt werden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setDatasourcess()
        {
            ucPersons1.DataSourcePerson = db.People.ToList(); //Wird include benötitg? .Include("Clan")
            ucDiary1.DataSourceDiary = db.Diaries.ToList();
            ucClan1.DataSourceClan = db.Clans.ToList();
        }

        private void btnLoadDBBackup_Click(object sender, EventArgs e)
        {
            dbHelper.RestoreDB();
            btnLoadDB_Click(null,null);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync(); // Führt die änderungen auf dem db c# objekt effektiv auf der DB aus

                MessageBox.Show("Save success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            foreach (var entity in db.ChangeTracker.Entries())
            {
                entity.Reload();
                setDatasourcess();
            }

        }
    }
}
