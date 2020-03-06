using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsUser
{
    class Сharacter
    {
        string race = null;
        string name = null;
        int Hp = 100;
        int Mp = 100;
        int Lvl = 1;
        int exp = 0;
        int newLvlExp = 100;
        int force = 10;
        int agility = 10;
        int intelligence = 10;
        int armor = 100;
        int attack = 25;

        List<object> items = new List<object>();
        static List<object> bunkItems = new List<object>();
        List<object> buffs = new List<object>();
        List<object> quests = new List<object>();
        List<object> leanedSkills = new List<object>();
        List<object> usingSkills = new List<object>();

        public string Name { get => name; set => name = value; }
        public string Race { get => race; set => race = value; }
        public int Hp1 { get => Hp; set => Hp = value; }
        public int Mp1 { get => Mp; set => Mp = value; }
        public int Lvl1 { get => Lvl; set => Lvl = value; }
        public int Exp { get => exp; set => exp = value; }
        public int NewLvlExp { get => newLvlExp; set => newLvlExp = value; }
        public int Force { get => force; set => force = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Armor { get => armor; set => armor = value; }
        public int Attack { get => attack; set => attack = value; }
        public List<object> Items { get => items; set => items = value; }
        public static List<object> BunkItems { get => bunkItems; set => bunkItems = value; }
        public List<object> Buffs { get => buffs; set => buffs = value; }
        public List<object> Quests { get => quests; set => quests = value; }
        public List<object> LeanedSkills { get => leanedSkills; set => leanedSkills = value; }
        public List<object> UsingSkills { get => usingSkills; set => usingSkills = value; }

        public Сharacter(string _race, string _name)
        {
            Race = _race;
            Name = _name;
        }
        public void AddItem()
        {
            string item = "Item";
            Items.Add(item);
            Items.Add(item);
        }
        public void AddBunkItem()
        {
            string item = "BunkItem";
            BunkItems.Add(item);
            BunkItems.Add(item);
        }
        public void AddBuffs()
        {
            string item = "Buff";
            Buffs.Add(item);
            Buffs.Add(item);
        }
        public void AddQuests()
        {
            string item = "Quest";
            Quests.Add(item);
            Quests.Add(item);
        }
        public void AddLeanedSkills()
        {
            string item = "LeanedSkill";
            LeanedSkills.Add(item);
            LeanedSkills.Add(item);
        }
        public void AddUsingSkills()
        {
            string item = "UsingSkill";
            UsingSkills.Add(item);
            UsingSkills.Add(item);
        }

    }
}
