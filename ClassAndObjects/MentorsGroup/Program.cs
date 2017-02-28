using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorsGroup
{
    class Program
    {


        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var students = new List<Student>();

            while (!input.Equals("end of dates"))
            {
                var studenInfo = input.Split(' ', ',');

                var studentName = studenInfo[0];
                var student = new Student();
                student.Date = new List<string>();
                student.Comments = new List<string>();

                student.Name = studentName;

                if (students.Any(x => x.Name == studentName))
                {
                    student = students.First(x => x.Name == studentName);

                    for (int i = 1; i < studenInfo.Length; i++)
                    {
                        student.Date.Add(studenInfo[i]);
                    }
                }
                else
                {
                    for (int i = 1; i < studenInfo.Length; i++)
                    {
                        student.Date.Add(studenInfo[i]);
                    }
                    
                    students.Add(student);
                }
                
                student.Date.Sort();
                input = Console.ReadLine();

            }

            input = Console.ReadLine();

            while (!input.Equals("end of comments"))
            {
                var studentInfo = input.Split('-');

                var studentName = studentInfo[0];
                var studentComment = studentInfo[1];

                var student = new Student();
                

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Name.Equals(studentName))
                    {
                        students[i].Comments.Add(studentComment);
                        break;
                    }
                }

                input = Console.ReadLine();

            }
            
            foreach (var student in students.OrderBy((x => x.Name)))
            {

                Console.WriteLine($"{student.Name}");
                Console.WriteLine("Comments:");
                for (int i = 0; i < student.Comments.Count; i++)
                {
                    Console.WriteLine("- {0}", student.Comments[i]);
                }

                Console.WriteLine("Dates attended:");
                for (int i = 0; i < student.Date.Count; i++)
                {
                    Console.WriteLine("-- {0}", student.Date[i]);
                }

            }

        }
    }
    class Student
    {
        public List<string> Comments { get; set; }

        public List<string> Date { get; set; }

        public string Name { get; set; }
    }
}
