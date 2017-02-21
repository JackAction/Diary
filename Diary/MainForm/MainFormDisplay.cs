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
        EntityManager entityManager;

        public MainFormDisplay()
        {
            InitializeComponent();
        }

        private void MainFormDisplay_Load(object sender, EventArgs e)
        {
            entityManager = new EntityManager();
        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            entityManager.BackupDB();
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            try
            {
                entityManager.LoadDatafromDB();
                setDatasourcess();
            }
            catch (Exception)
            {

                MessageBox.Show("Datenbankverbindung konnte nicht hergestellt werden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setDatasourcess()
        {
            ucPersons1.DataSourcePerson = entityManager.GetPersons();
            ucDiary1.DataSourceDiary = entityManager.GetDiaryEntries();
            ucClan1.DataSourceClan = entityManager.GetClans();
        }

        private void btnLoadDBBackup_Click(object sender, EventArgs e)
        {
            entityManager.RestoreDB();
            btnLoadDB_Click(null,null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                entityManager.SaveChangesToDB(); // Führt die änderungen auf dem db c# objekt effektiv auf der DB aus

                MessageBox.Show("Save success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            entityManager.DiscardChanges();
            setDatasourcess();
        }
    }
}
