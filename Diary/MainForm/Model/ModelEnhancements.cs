﻿namespace MainForm
{
    class ModelEnhancements
    {
    }

    public partial class Diary
    {
        public string PeopleString
        {
            get
            {
                return string.Join(", ", People);
            }
        }
        public override string ToString()
        {
            return Entry ?? "Not Set";
        }
    }

    public partial class Clan
    {
        public override string ToString()
        {
            return Name ?? "Not Set";
        }
    }

    public partial class Item
    {
        public override string ToString()
        {
            return Name ?? "Not Set";
        }
    }

    public partial class Person
    {
        public override string ToString()
        {
            return Name ?? "Not Set";
        }
    }

    public partial class Place
    {
        public override string ToString()
        {
            return DisplayName ?? "Not Set";
        }
        public string DisplayName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(City) && string.IsNullOrWhiteSpace(Building))
                {
                    return Name;
                }
                return $"{City} {Building} {Name}";
            }
        }
    }

    public partial class Quest
    {
        public override string ToString()
        {
            return Name ?? "Not Set";
        }
    }
}
