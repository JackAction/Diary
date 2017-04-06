using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

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
            return db.People.ToList();
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

        public List<Item> GetItems()
        {
            return db.Items.ToList();
        }

        public List<Quest> GetQuests()
        {
            return db.Quests.ToList();
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

        public void AddItemEntry(Item i)
        {
            if (i != null)
            {
                db.Items.Add(i);
            }
        }

        public void AddQuestEntry(Quest q)
        {
            if (q != null)
            {
                db.Quests.Add(q);
            }
        }

        public void DeleteDiaryEntry(Diary d)
        {
            if (d != null)
            {
                db.Diaries.Remove(d);
            }
        }

        public void DeleteClanEntry(Clan c)
        {
            if (c != null)
            {
                db.Clans.Remove(c);
            }
        }

        public void DeletePersonEntry(Person p)
        {
            if (p != null)
            {
                db.People.Remove(p);
            }
        }

        public void DeletePlaceEntry(Place p)
        {
            if (p != null)
            {
                db.Places.Remove(p);
            }
        }

        public void DeleteItemEntry(Item i)
        {
            if (i != null)
            {
                db.Items.Remove(i);
            }
        }

        public void DeleteQuestEntry(Quest q)
        {
            if (q != null)
            {
                db.Quests.Remove(q);
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
