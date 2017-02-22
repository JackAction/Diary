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
        private ApplicationState applicationState;
        EntityManager entityManager;

        public MainFormDisplay()
        {
            applicationState = ApplicationState.Starting;
            InitializeComponent();
        }

        private void MainFormDisplay_Load(object sender, EventArgs e)
        {
            entityManager = new EntityManager();

            // Eventhandlers
            ucDiary1.DiaryRowAdded += new EventHandler(ucDiary1_dbgrdDiary_RowsAdded);
            ucClan1.ClanRowAdded += new EventHandler(ucClan1_dbgrdClan_RowsAdded);
            ucPersons1.PersonRowAdded += new EventHandler(ucPersons1_dbgrdPerson_RowsAdded);
            applicationState = ApplicationState.Started;
        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            entityManager.BackupDB();
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            try
            {
                applicationState = ApplicationState.DBInteraction;
                entityManager.LoadDatafromDB();
                setDatasourcess();
            }
            catch (Exception)
            {

                MessageBox.Show("Datenbankverbindung konnte nicht hergestellt werden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                applicationState = ApplicationState.Started;
            }
        }

        private void setDatasourcess()
        {
            ucPersons1.DataSourcePerson.DataSource = entityManager.GetPersons();
            ucDiary1.DataSourceDiary.DataSource = entityManager.GetDiaryEntries();
            ucClan1.DataSourceClan.DataSource = entityManager.GetClans();
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

        private void ucDiary1_dbgrdDiary_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.Started)
            {
                entityManager.AddDiaryEntry((Diary)ucDiary1.DataSourceDiary.Current);
            }
        }

        private void ucClan1_dbgrdClan_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.Started)
            {
                entityManager.AddClanEntry((Clan)ucClan1.DataSourceClan.Current);
            }
        }

        private void ucPersons1_dbgrdPerson_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.Started)
            {
                entityManager.AddPersonEntry((Person)ucPersons1.DataSourcePerson.Current);
            }
        }
    }
}
