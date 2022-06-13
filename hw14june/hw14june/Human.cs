using System;
namespace hw14june
{
    public class Human
    {
        public Human(byte age, string name = null, string surname=null)
        {
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
        }
        public string Name;
        public string Surname;
        public byte Age;
    }
}
