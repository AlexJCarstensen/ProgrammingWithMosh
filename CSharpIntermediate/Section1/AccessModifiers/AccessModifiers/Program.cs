
using System;

namespace AccessModifiers
{
    public class Person
    {
        public DateTime BirthDate { get; set; }
        //private DateTime _birthdate;

        //public void SetBirthdate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}

        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.BirthDate = new DateTime(1992,1,1);
            Console.WriteLine(person.BirthDate);

        }
    }
}
