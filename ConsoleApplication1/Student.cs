using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     class Student : Person, ICloneable
    {
        public enum Education { Master, Bachelor, SecondEducation, PhD };
        public Education QualificationLevel { get; set; }
        public string Group { get; set; }
        public string MarkBook { get; set; }
        public List<Examination> FulfilledCredits { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Surname}, {Group}";
        }
        
        public IEnumerable GetNotExaminations()
        {
            foreach (var exam in FulfilledCredits)
                if (!exam.IsExam)
                    yield return exam;
        }
        public override void PrintFullInfo()
        {
            
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Date of birth: " + _dateOfBirth.ToShortDateString());
            Console.WriteLine("Qualification level: " + QualificationLevel);
            Console.WriteLine("Group: " + Group);
            Console.WriteLine("Markbook: " + MarkBook);
            
            for (int i = 0; i < FulfilledCredits.Count(); i++) {
                Console.WriteLine(FulfilledCredits[i]);
            }
            Console.WriteLine();
        }

       
        public object Clone()
        {
            Student clone = new Student(Name, Surname, _dateOfBirth, QualificationLevel, Group, MarkBook);
            foreach (var doneCredit in FulfilledCredits)
            {
                clone.AddExam(doneCredit);
            }

            return clone;
        }
        
        public void GetCredits()
        {
            FulfilledCredits.Sort();
            foreach (var c in FulfilledCredits)
            {
                Console.WriteLine(c);
            }
        }
       
        public void AddExams(Examination[] examList)
        {
            foreach (Examination exam in examList)
            {
                if (exam.Rating > 60)
                {
                    FulfilledCredits.Add(exam);
                }
            }
        }
        
        
        public void AddExam(Examination exam)
        {
                if (exam.Rating > 60)
                {
                    FulfilledCredits.Add(exam);
                }
        }
        
        public Student(string name, string surname, DateTime dateOfBirth, Education qualificationLevel, string group, string markbook)
        {
            Name = name;
            Surname = surname;
            QualificationLevel = qualificationLevel;
            _dateOfBirth = dateOfBirth;
            MarkBook = markbook;
            Group = group;
            FulfilledCredits = new List<Examination>();
        }
        public Student()
        {
            Name = "Sasha";
            Surname = "Petryk";
            QualificationLevel = Education.Bachelor;
            _dateOfBirth = new DateTime(2019, 10, 01);
            MarkBook = "IP-7313";
            Group = "IP-73";
            FulfilledCredits = new List<Examination>();
        }
    }
}