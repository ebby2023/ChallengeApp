

namespace ChallengeApp
{
    internal class Supervisor : IEmployee

    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

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
                throw new Exception("Invalid great value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float newgrades))
                this.AddGrade(newgrades);
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "-6":
                case "6-":
                    this.grades.Add(95);
                    break;
                case "+5":
                case "5+":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;
                case "4+":
                case "+4":
                    this.grades.Add(70);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;
                case "+3":
                case "3+":
                    this.grades.Add(45);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "2+":
                case "+2":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;
                case "1+":
                case "+1":
                    this.grades.Add(5);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("""Please enter correct value from "1" to "6" thank you.""");
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

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
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

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.Average = 'E';
                    break;
            }

            return statistics;

        }


    }
}



