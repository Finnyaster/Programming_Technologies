using ConsoleApp5.ValidDators;
using System;
namespace ConsoleApp5
{
    class Person
    {
        public Person(int height, double weight, DateTime BirthDay, string FirstName, string Lastname)
        {

        }
        // Рост
        public int height { get; private set; }
        // Вес
        public double weight { get; private set; }
        // Дата
        public DateTime BirthDay { get; }
        // Имя
        public string FirstName { get; private set; }
        // Фамилия
        public string LastName { get; private set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public bool ChangeHeight(int height)
        {
            bool flag = intvalidator.ValidDate(height);
            if (flag)
            {
                this.height = height;
            }
            return flag;
        }
        public bool ChangeWeight(int weight)
        {
            bool flag = stringvalidator.ValidDate(weight);
            if (flag)
            {
                this.weight = weight;
            }
            return flag;
        }
    }
}
