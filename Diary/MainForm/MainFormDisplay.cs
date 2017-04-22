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

            if (Environment.MachineName == "KLAPPI")
            {
                WindowState = FormWindowState.Maximized; 
            }

            // Delegate Eventhandlers von User Controls
            // Diary Handling
            ucDiary1.DiaryRowAdded += new EventHandler(Diary_RowsAdded);
            ucPersons1.DiaryRowAdded += new EventHandler(Diary_RowsAdded);
            ucPlace1.DiaryRowAdded += new EventHandler(Diary_RowsAdded);
            ucDiary1.DiaryRowDeleted += new EventHandler(Diary_RowsDeleted);
            ucPersons1.DiaryRowDeleted += new EventHandler(Diary_RowsDeleted);
            ucPlace1.DiaryRowDeleted += new EventHandler(Diary_RowsDeleted);
            // Person Handling
            ucPersons1.PersonRowAdded += new EventHandler(Person_RowsAdded);
            ucClan1.PersonRowAdded += new EventHandler(Person_RowsAdded);
            ucPersons1.PersonRowDeleted += new EventHandler(Person_RowsDeleted);
            ucClan1.PersonRowDeleted += new EventHandler(Person_RowsDeleted);
            // Place Handling
            ucPlace1.PlaceRowAdded += new EventHandler(Place_RowsAdded);
            ucPersons1.PlaceAdded += new EventHandler(Place_RowsAdded);
            ucDiary1.PlaceAdded += new EventHandler(Place_RowsAdded);
            ucPlace1.PlaceRowDeleted += new EventHandler(Place_RowsDeleted);
            // Clan Handling
            ucClan1.ClanRowAdded += new EventHandler(Clan_RowsAdded);
            ucClan1.ClanRowDeleted += new EventHandler(Clan_RowsDeleted);
            // Item Handling
            ucDiary1.ItemAdded += new EventHandler(Item_RowsAdded);
            // Quest Handling
            ucDiary1.QuestAdded += new EventHandler(Quest_RowsAdded);
            // Other
            ucDiary1.ChangePersonModeTo_DiaryDetailEdit += new EventHandler(ChangePersonModeTo_DiaryDetailEdit);

            applicationState = ApplicationState.Started;
        }

        private void setDatasourcess()
        {
            ucPersons1.DataSourcePerson.DataSource = entityManager.GetPersons();
            ucPersons1.DataSourcePlace.DataSource = entityManager.GetPlaces();
            ucDiary1.DataSourceDiary.DataSource = entityManager.GetDiaryEntries();
            ucDiary1.DataSourcePlace.DataSource = entityManager.GetPlaces();
            ucClan1.DataSourceClan.DataSource = entityManager.GetClans();
            ucPlace1.DataSourcePlace.DataSource = entityManager.GetPlaces();
            ucDiary1.DataSourceItem.DataSource = entityManager.GetItems();
            ucDiary1.DataSourceQuest.DataSource = entityManager.GetQuests();
            ucPersons1.DataSourceItem.DataSource = entityManager.GetItems();
            ucPersons1.DataSourceQuest.DataSource = entityManager.GetQuests();
            ucPlace1.DataSourceItem.DataSource = entityManager.GetItems();
            ucPlace1.DataSourceQuest.DataSource = entityManager.GetQuests();
        }

        #region Handle creation and deletion of Model Entries

        private void Diary_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                Diary newDiary;
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        newDiary = (Diary)ucDiary1.DataSourceDiary.Current;
                        break;
                    case "tabPerson":
                        newDiary = (Diary)ucPersons1.DataSourceDiary.Current;
                        break;
                    case "tabPlaces":
                        newDiary = (Diary)ucPlace1.DataSourceDiary.Current;
                        break;
                    default:
                        newDiary = null;
                        break;
                }
                // Überschreibe die SessionID mit dem entsprechenden Eingabefeldwert
                if (newDiary != null)
                {
                    newDiary.SessionID = (int)txtSessionID.Value;
                    entityManager.AddDiaryEntry(newDiary);
                }
            }
        }

        private void Diary_RowsDeleted(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                Diary deletedDiary;
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        deletedDiary = (Diary)ucDiary1.DataSourceDiary.Current;
                        break;
                    case "tabPerson":
                        deletedDiary = (Diary)ucPersons1.DataSourceDiary.Current;
                        break;
                    case "tabPlaces":
                        deletedDiary = (Diary)ucPlace1.DataSourceDiary.Current;
                        break;
                    default:
                        deletedDiary = new Diary();
                        break;
                }
                if (deletedDiary != null)
                {
                    entityManager.DeleteDiaryEntry(deletedDiary);
                }
            }
        }

        private void Clan_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabClans":
                        entityManager.AddClanEntry((Clan)ucClan1.DataSourceClan.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Clan_RowsDeleted(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabClans":
                        entityManager.DeleteClanEntry((Clan)ucClan1.DataSourceClan.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Person_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabPerson":
                        entityManager.AddPersonEntry((Person)ucPersons1.DataSourcePerson.Current);
                        break;
                    case "tabClans":
                        entityManager.AddPersonEntry((Person)ucClan1.DataSourcePerson.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Person_RowsDeleted(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabPerson":
                        entityManager.DeletePersonEntry((Person)ucPersons1.DataSourcePerson.Current);
                        break;
                    case "tabClans":
                        entityManager.DeletePersonEntry((Person)ucClan1.DataSourcePerson.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Place_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        entityManager.AddPlaceEntry(ucDiary1.NewPlace);
                        quickSaveToolStripMenuItem_Click(null, null);
                        break;
                    case "tabPerson":
                        entityManager.AddPlaceEntry(ucPersons1.NewPlace);
                        quickSaveToolStripMenuItem_Click(null, null);
                        break;
                    case "tabPlaces":
                        entityManager.AddPlaceEntry((Place)ucPlace1.DataSourcePlace.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Place_RowsDeleted(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabPlaces":
                        entityManager.DeletePlaceEntry((Place)ucPlace1.DataSourcePlace.Current);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Item_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        entityManager.AddItemEntry(ucDiary1.NewItem);
                        quickSaveToolStripMenuItem_Click(null, null);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Quest_RowsAdded(object sender, EventArgs e)
        {
            if (applicationState == ApplicationState.DBLoaded)
            {
                switch (mstControl.SelectedTab.Name)
                {
                    case "tabDiary":
                        entityManager.AddQuestEntry(ucDiary1.NewQuest);
                        quickSaveToolStripMenuItem_Click(null, null);
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region Change between DiaryDetailEdit and Normal Mode

        private BindingSource tmpStorage_PersonBindingSource;
        private Diary tmpStorage_currentDiary;

        private void ChangePersonModeTo_DiaryDetailEdit(object sender, EventArgs e)
        {
            mstControl.SelectTab("tabPerson");
            tmpStorage_PersonBindingSource = ucPersons1.DataSourceDiary;
            ucPersons1.DataSourceDiary = ucDiary1.DataSourceDiary;
            tmpStorage_currentDiary = ucDiary1.DataSourceDiary.Current as Diary;
            ucPersons1.ChangePersonModeTo_DiaryDetailEdit();
            btnUpdatePeopleForDiaryEntry.Visible = true;
            mstControl.TabPages.Remove(tabDiary);
            mstControl.TabPages.Remove(tabClans);
            mstControl.TabPages.Remove(tabPlaces);
        }

        private void btnAddPeopleToDiary_Click(object sender, EventArgs e)
        {
            ChangePersonModeTo_NormalMode();
        }

        private void ChangePersonModeTo_NormalMode()
        {
            if (tmpStorage_currentDiary != null)
            {
                tmpStorage_currentDiary.People = ucPersons1.GetCheckedPeople();
            }
            ucPersons1.DataSourceDiary = tmpStorage_PersonBindingSource;
            ucPersons1.ChangePersonModeTo_NormalMode();
            btnUpdatePeopleForDiaryEntry.Visible = false;
            mstControl.TabPages.Insert(0, tabDiary);
            mstControl.TabPages.Insert(2, tabClans);
            mstControl.TabPages.Insert(3, tabPlaces);
            mstControl.SelectTab("tabDiary");
        }

        #endregion

        #region MenuStrip functions
        /// <summary>
        /// Event Handler: Datenbankbackup von Dropbox laden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entityManager.RestoreDB();
            loadBackupFromLocalToolStripMenuItem_Click(null, null);
        }

        /// <summary>
        /// Event Handler: Lokale Datenbank laden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadBackupFromLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                applicationState = ApplicationState.DBInteraction;
                entityManager.LoadDatafromDB();
                setDatasourcess();
                mstControl_SelectedIndexChanged(null, null);
            }
            catch (Exception)
            {

                MessageBox.Show("Datenbankverbindung konnte nicht hergestellt werden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                applicationState = ApplicationState.DBLoaded;
            }
        }

        /// <summary>
        /// Event Handler: Datenbankbackup auf Dropbox speichern.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveDropboxBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entityManager.BackupDB();
        }

        /// <summary>
        /// Event Handler: Änderungen in lokale DB speichern.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quickSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSessionID.Focus();
            try
            {
                entityManager.SaveChangesToDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            setDatasourcess();
        }

        /// <summary>
        /// Event Handler: Änderungen seit letztem speichern verwerfen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quickDiscardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entityManager.DiscardChanges();
            setDatasourcess();
        }

        #endregion

        /// <summary>
        /// Event Handler bei Tab-wechsel: Benötigt um zusätzliche Datagrids zu aktualisieren aufgrund aktuell selektierter Zeile in Hauptdatagrid des Tabs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mstControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Damit alles in DB gespeichert wird und aktuell ist 
            if (applicationState == ApplicationState.DBLoaded)
            {
                quickSaveToolStripMenuItem_Click(null, null); 
            }

            switch (mstControl.SelectedTab.Name)
            {
                case "tabDiary":
                    // Zurzeit kein weiteres Datagrid, somit nicht benötigt.
                    break;
                case "tabPerson":
                    ucPersons1.ShowDiaryEntries();
                    ucPersons1.ShowPicture();
                    break;
                case "tabPlaces":
                    ucPlace1.ShowDiaryEntries();
                    ucPlace1.ShowPicture();
                    break;
                case "tabClans":
                    ucClan1.ShowMembers();
                    ucClan1.ShowDiaryEntries();
                    ucClan1.ShowPicture();
                    break;
                default:
                    break;
            }
        }

    }
}
