using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvarageGrade
{
    public class AvarageGrade
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();

                var studentName = input[0];

                var studentGrade = new List<double>();

                for (int j = 1; j < input.Count; j++)
                {
                    double grade = double.Parse(input[j]);
                    studentGrade.Add(grade);
                }

                var student = new Student();
                student.Name = studentName;
                student.Grades = studentGrade;

                students.Add(student);

            }

            foreach (var student in students.Where(x => x.AverageGrade() >= 5)
                .OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade()))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade():F2}");
            }

        }
    }
    public class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade()
        {
            var averageGrade = this.Grades.Average();

            return averageGrade;
        }
    }
}
