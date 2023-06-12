

namespace ChallengeApp

{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }


        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public void AddGrade(float grade)

        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else

            {
                Console.WriteLine("Ivalid grade value");
            }


        }
        public void AddGrade(string grade)

        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(int grade)
        {
            float intGrade = grade;
            this.grades.Add(intGrade);
        }
        public void AddGrade(double grade)
        {
            float doubleGrade = (float)grade;
            this.grades.Add(doubleGrade);

        }

        public void AddGrade(long grade)
        {
            float longGrade = (float)grade;
            this.grades.Add(longGrade);
        }



        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;

            }
            statistics.Average /= this.grades.Count;



            return statistics;

        }
        public Statistics GetStatistickWithLoopFor()
        {
            var statistick = new Statistics();
            statistick.Max = float.MinValue;
            statistick.Min = float.MaxValue;
            statistick.Average = 0;
            var index = 0;

            for (index = 0; index > this.grades.Count; index++)
            {
                statistick.Max = Math.Max(statistick.Max, index);
                statistick.Min = Math.Min(statistick.Min, index);
                statistick.Average += index;
            }
            statistick.Average /= this.grades.Count;
            return statistick;
        }

        public Statistics GetStatistickWithLoopForeach()
        {
            var statistick = new Statistics();
            statistick.Max = float.MinValue;
            statistick.Min = float.MaxValue;
            statistick.Average = 0;
            var index = 0;

            foreach (var grade in this.grades)
            {
                statistick.Max = Math.Max(statistick.Max, grade);
                statistick.Min = Math.Min(statistick.Min, grade);
                statistick.Average += grade;

            }
            statistick.Average /= this.grades.Count;
            return statistick;
        }
        public Statistics GetStatistickWithDoWhile()
        {
            var statistick = new Statistics();
            statistick.Max = float.MinValue;
            statistick.Min = float.MaxValue;
            statistick.Average = 0;
            var index = 0;

            do
            {
                statistick.Max = Math.Max(statistick.Max, index);
                statistick.Min = Math.Min(statistick.Min, index);
                statistick.Average = this.grades[index];
                index++;
            }
            while (index < this.grades.Count);

            statistick.Average /= this.grades.Count;
            return statistick;

        }
        public Statistics GetStatistickWithWhile()
        {
            var statistick = new Statistics();
            statistick.Max = float.MinValue;
            statistick.Min = float.MaxValue;
            statistick.Average = 0;
            var index = 0;

            while (index < this.grades.Count)
            {
                statistick.Max = Math.Max(statistick.Max, index);
                statistick.Min = Math.Min(statistick.Min, index);
                statistick.Average = this.grades[index];
                index++;


            }
            statistick.Average /= this.grades.Count;
            return statistick;
        }













    }
}