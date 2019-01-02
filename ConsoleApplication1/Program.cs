using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hnatyshyn Mykhailo, IP-72, Variant #5");

            
            Console.WriteLine();
            Student me = new Student("Mykhailo", "Hnatyshyn", new DateTime(1998, 06, 14), Student.Education.Bachelor, "IP-72", "IP-7207");
            Console.WriteLine(me.ToString());
            me.AddExams(new Examination[]
            {
                new Examination(3, "Object-oriented programming (OOP)", "Muha I.P.", 75, true, new DateTime(2018, 04, 11)),
                new Examination(1, "Mathematical analysis", "Bodnarchuk S.W.", 91, true, new DateTime(2017, 11, 25)),
                new Examination(2, "Discrete structures", "Halkin S.V.", 98, false, new DateTime(2019, 05, 02)),
                new Examination(4, "Web technologies", "Ocheretianyj O.D.", 100, false, new DateTime(2019, 10, 02)),
                new Examination(5, "Probability theory", "Harko I.D.", 85, true, new DateTime(2019, 10, 02)),
                new Examination(3, "Theory of algorithms", "Halus O.M.", 75, true, new DateTime(2017, 11, 05)),
                new Examination(2, "Philosophy", "Anapov O.D.", 68, false, new DateTime(2019, 10, 02)),
            });
            Console.WriteLine(me.ToString());
            me.PrintFullInfo();
            
            Console.WriteLine();
            
            Console.WriteLine("Task 1: ");
            Student student = new Student("Mykhailo", "Hnatyshyn", new DateTime(1999, 11, 11), Student.Education.Bachelor, "IP-72", "IP-7207");
            student.AddExams(new Examination[]
            {
                new Examination(3, "Object-oriented programming (OOP)", "Muha I.P.", 75, true, new DateTime(2018, 04, 11)),
                new Examination(1, "Mathematical analysis", "Bodnarchuk S.W.", 91, true, new DateTime(2017, 11, 25)),
            });
            Student clone = (Student) student.Clone();
            student.AddExam(new Examination(4, "Web technologies", "Ocheretianyj O.D.", 100, false, new DateTime(2019, 10, 02)));
            Console.WriteLine("Link to student != Link to clone : " + (student == clone));
            Console.WriteLine("student credits after adding one to it : ");
            student.GetCredits();
            Console.WriteLine("clone credits after adding one to student : ");
            clone.GetCredits();

            Console.WriteLine();

            Console.WriteLine("Task 2: ");
            Person person1 = new Person("Bohdan", "Kotenko", new DateTime(1999, 11, 11));
            Person person2 = new Person("Bohdan", "Kotenko", new DateTime(1999, 11, 11));
            Person person3 = new Person("Misha", "Afanasiuk", new DateTime(1996, 01, 27));
            Console.WriteLine("Bohdan Kotenko 11.11.1999 == Bohdan Kotenko 11.11.1999 : " + (person1 == person2));
            Console.WriteLine("Bohdan Kotenko 11.11.1999 == Misha Afanasiuk 27.01.1999 : " + (person1 == person3));
            Console.WriteLine("Bohdan Kotenko 11.11.1999 != Bohdan Kotenko 11.11.1999 : " + (person1 != person2));
            Console.WriteLine("Bohdan Kotenko 11.11.1999 != Misha Afanasiuk 27.01.1999 : " + (person1 != person3));
            Console.WriteLine();

            Console.WriteLine("Task 9: ");
            Console.WriteLine("Not differentiated credit: ");
             foreach (Examination exm in me.GetNotExaminations())
             {
                 Console.WriteLine(exm);
             }
            Console.WriteLine();

            Console.WriteLine("Task 12: ");
            Console.WriteLine("Exams sorted by subject name: ");
            me.GetCredits();
            Console.WriteLine();
            
            Console.Write("Press key to exit...");
            Console.ReadKey();
        }
    }
}