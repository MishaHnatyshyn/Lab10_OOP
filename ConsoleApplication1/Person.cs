using System;

namespace ConsoleApplication1
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        protected DateTime _dateOfBirth;
        public int DateOfBirth
        {
            get
            {
                return _dateOfBirth.Year;
            }
            set
            {
                if (value <= DateTime.Now.Year && value > 1900)
                {
                    int day = _dateOfBirth.Day;
                    int month = _dateOfBirth.Month;
                    _dateOfBirth = new DateTime(value, month, day);
                }
            }
        }
        
        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            if (!(person is null))
            {
                if (Name == person.Name &&
                    Surname == person.Surname &&
                    _dateOfBirth == person._dateOfBirth)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public static bool operator !=(Person person1, Person person2)
        {
            return !person1.Equals(person2);
        }
        public static bool operator ==(Person person1, Person person2)
        {
            return person1.Equals(person2);
        }
        
        public virtual void PrintFullInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Date of birth: " + _dateOfBirth.ToShortDateString());
        }
        public Person()
        {
            Name = "Misha";
            Surname = "Hnatyshyn";
            _dateOfBirth = new DateTime(1999, 11, 11);
        }
        public Person(string name, string surname, DateTime dateOfBirth)
        {
            Name = name;
            Surname = surname;
            _dateOfBirth = dateOfBirth;
        }
       
    }
}