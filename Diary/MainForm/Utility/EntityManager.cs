using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class EntityManager
    {
        DBHelper dbHelper;
        dnd_hotdqEntities db;

        public EntityManager()
        {
            dbHelper = new DBHelper();
        }

        public void BackupDB()
        {
            dbHelper.BackupDB();
        }
        public void RestoreDB()
        {
            dbHelper.RestoreDB();
        }

        public void LoadDatafromDB()
        {
            db = new dnd_hotdqEntities(dbHelper.BuildConnectionString());
        }

        public void SaveChangesToDB()
        {
            if (db.ChangeTracker.HasChanges())
            {
                db.SaveChanges(); 
            }
        }

        public void DiscardChanges()
        {
            foreach (DbEntityEntry entry in db.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        public List<Person> GetPersons()
        {
            return db.People.ToList(); //Wird include benötitg? .Include("Clan")
        }

        public List<Diary> GetDiaryEntries()
        {
            return db.Diaries.ToList();
        }

        public List<Place> GetPlaces()
        {
            return db.Places.ToList();
        }

        public List<Clan> GetClans()
        {
            return db.Clans.ToList();
        }

        public void AddDiaryEntry(Diary d)
        {
            if (d != null)
            {
                db.Diaries.Add(d); 
            }
        }

        public void AddClanEntry(Clan c)
        {
            if (c != null)
            {
                db.Clans.Add(c); 
            }
        }

        public void AddPersonEntry(Person p)
        {
            if (p != null)
            {
                db.People.Add(p); 
            }
        }

        public void AddPlaceEntry(Place p)
        {
            if (p != null)
            {
                db.Places.Add(p);
            }
        }

        public void ChangeDiary(Diary d)
        {
            if (d != null)
            {
                db.Diaries.Attach(d);
            }
        }

    }


    /// <summary>
    /// Fügt einen Konstruktor zu Model.Context.cs hinzu, welchem ein ConnectionString übergeben werden kann
    /// </summary>
    public partial class dnd_hotdqEntities : DbContext
    {
        public dnd_hotdqEntities(String connString)
            : base(connString)
        {
        }
    }
}
