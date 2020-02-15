using System;

namespace ConsoleAppMAl
{
   
    class Program
    {
        private class Account
        {
            public string Login;
            private string Password;
        }

        public class Person : Properties
        {
            public string Nickname;
            public int Level
            {
                get
                {
                    return Level;
                }

                set
                {
                    Level = value;
                }
            }
            public string Weapon;
        }

        public class Properties
        {
            public int Rost;
            public int Speed
            {
                get
                {
                    return Speed;
                }

                set
                {
                    Speed = value;
                }
            } 
            public int Ves;
        }

        public class Transport : Location
        {
            public string Car;
            public string Helicopter;
            public string Airplane;
            public string bike;
        }

        public class Location : Mission
        {
            public string City;
            public string Street;
            public string TownNumber;
        }

        public class Mission
        {
            public string Misssion1;
            public string Misssion2;
            public string Misssion3;
        }

        static void Main(string[] args)
        {

        }
    }
}
