using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsUser
{
    class Account
    {
        [BsonId]
        public string login = null;
        public string password = null;
        public List<Сharacter> Person { get => person; set => person = value; }
        private List<Сharacter> person = new List<Сharacter>();


        public Account()
        {
            Console.WriteLine("Введите логин");
            string _login = "Tester" /*Console.ReadLine()*/;
            Console.WriteLine("Введите пароль");
            string _password = "qwert" /*Console.ReadLine()*/;

            login = _login;
            password = _password;
        }

        public void AddPers()
        {
            Console.WriteLine("Введите Рассу перса");
            string race = "Human" /*Console.ReadLine()*/;
            Console.WriteLine("Введите Name перса");
            string name = "Three" /*Console.ReadLine()*/;
            Сharacter a = new Сharacter(race, name);
            a.AddBuffs();
            a.AddBunkItem();
            a.AddItem();
            a.AddLeanedSkills();
            a.AddQuests();
            a.AddUsingSkills();
            Person.Add(a);
        }
    }
}
