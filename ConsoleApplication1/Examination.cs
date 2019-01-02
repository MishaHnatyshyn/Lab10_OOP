using System;

namespace ConsoleApplication1
{
    class Examination : IMarkName, IComparable
    {
        private int _semester;
        public int Semester
        {
            get { return _semester; }
            set
            {
                if (value > 0 && value < 13)
                    _semester = value;
            }
        }
        public int Rating { get; set; }
        public bool IsExam { get; set; }
        public string Subject { get; set; }
        public string LecturerName { get; set; }
        public DateTime CreditDate { get; set; }
        
        public override string ToString()
        {
            return $"{Semester}th semester, Subject: {Subject}, Lecturer: {LecturerName} - Rating: {Rating}.";
        }

        public string ECTSScaleName()
        {
            if (Rating <= 100 && Rating >= 95)
            {
                return "A";
            }

            if (Rating <= 94 && Rating >= 85) {
                return "B";
            }

            if (Rating <= 84 && Rating >= 75)
            {
                return "C";
            }

            if (Rating <= 74 && Rating >= 65)
            {
                return "D";
            }

            if (Rating <= 64 && Rating >= 60)
            {
                return "E";
            }

            if (Rating <= 59 && Rating >= 35)
            {
                return "Fx";
            }

            return "F";
        }

        public int CompareTo(object obj)
        {
            Examination exam = obj as Examination;
            if (obj is null)
                throw new ApplicationException("Compare To method: obj is null");

            return Subject.CompareTo(exam.Subject);
        }
        
        public string NationalScaleName()
        {
            if (Rating <= 100 && Rating >= 95)
            {
                return "Відмінно";
            }

            if (Rating <= 94 && Rating >= 85)
            {
                return "Дуже добре";
            }

            if (Rating <= 84 && Rating >= 75)
            {
                return "Добре";
            }

            if (Rating <= 74 && Rating >= 65)
            {
                return "Задовільно";
            }

            if (Rating <= 64 && Rating >= 60)
            {
                return "Достатньо";
            }

            if (Rating < 60 && Rating >= 35)
            {
                return "Немає допуску до екзамену";
            }

            return "Незадовільно";
        }

        public Examination()
        {
            Semester = 1;
            Subject = "Web technologies";
            LecturerName = "Ocheretianyj O.D.";
            Rating = 99;
            IsExam = true;
            CreditDate = new DateTime(2018, 11, 11);
        }
        public Examination(int semester, string subject, string lecturerName, int rating, bool isExam, DateTime creditDate)
        {
            Semester = semester;
            Subject = subject;
            LecturerName = lecturerName;
            Rating = rating;
            IsExam = isExam;
            CreditDate = creditDate;
        } 
    }
}