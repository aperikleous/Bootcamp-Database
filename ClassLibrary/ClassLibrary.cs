using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Course
    {
        public Course(string title, string stream, string type, DateTime start_Date, DateTime end_Date)
        {
            Title = title;
            Stream = stream;
            Type = type;
            Start_Date = start_Date;
            End_Date = end_Date;
        }

        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"The course {Title} {Stream} {Type} starts at {Start_Date.Date} and ends at {End_Date.Date}");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
        }
        public void DisplayStudents()
        {
            Console.WriteLine(Title);
            foreach (var item in Students)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
        }
        public void DisplayAssignments()
        {
            Console.WriteLine(Title);
            foreach (var item in Assignments)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
        }
        public void DisplayTrainers()
        {
            Console.WriteLine(Title);
            foreach (var item in Trainers)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
        }
    }
    public class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        string subject;
        public List<Course> Courses { get; set; } = new List<Course>();
        public Trainer(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            this.subject = subject;
        }
        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"The trainer {FirstName} {LastName} teaches {subject}");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, DateTime dateOfBirth, int tuitionFees)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Info for the student {FirstName} {LastName}");
            Console.WriteLine($"Date of Birth : {DateOfBirth.Date}");
            Console.WriteLine($"Tuition Fees : {TuitionFees}");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
        }
        public void DisplayAssignments()
        {
            Console.WriteLine($"The student {FirstName} {LastName} has the following assignments under each course");
            Console.WriteLine();
            foreach (var item in Courses)
            {
                Console.WriteLine(item.Title);
                foreach (var elem in item.Assignments)
                {
                    elem.ShowInfo();
                }

            }
            Console.WriteLine();
        }
        public void DisplayCourses()
        {
            Console.WriteLine($"The student {FirstName} {LastName} attends the following courses");
            foreach (var item in Courses)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
        }
    }
    public class Assignment
    {
        public Assignment(string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public Course Course { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Info for the assignment {Title}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Submission Date : {SubDateTime.Date}");
            Console.WriteLine($"Oral Mark : {OralMark}");
            Console.WriteLine($"Total Mark : {TotalMark}");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
    /// <summary>
    /// Many-to-many relationship. Multiple students can attend multiple courses
    /// </summary>
    public class StudentCourse
    {
        Course Course;
        Student Student;
        public StudentCourse(Student student, Course course)
        {
            Course = course;
            Student = student;
            Course.Students.Add(student);
            Student.Courses.Add(course);
        }
        public void DisplayStudents()
        {
            Console.WriteLine(Course.Title);
            foreach (var item in Course.Students)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
        }
        public void DisplayCourses()
        {
            Console.WriteLine(Student.FirstName);
            foreach (var item in Student.Courses)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
        }
    }
    /// <summary>
    /// Many-to-many relationship. Multiple students can have multiple assignments
    /// </summary>
    public class StudentAssignment
    {
        Assignment Assignment;
        Student Student;
        public StudentAssignment(Student student, Assignment assignment)
        {
            Assignment = assignment;
            Student = student;
            Assignment.Students.Add(student);
            Student.Assignments.Add(assignment);
        }
        public void DisplayStudents()
        {
            Console.WriteLine(Assignment.Title);
            foreach (var item in Assignment.Students)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
        }
        public void DisplayAssignments()
        {
            Console.WriteLine(Student.FirstName);
            foreach (var item in Student.Assignments)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
        }
    }
    /// <summary>
    /// Many-to-many relationship. Multiple trainers can teach multiple courses
    /// </summary>
    public class TrainerCourse
    {
        Course Course;
        Trainer Trainer;
        public TrainerCourse(Trainer trainer, Course course)
        {
            Course = course;
            Trainer = trainer;
            Course.Trainers.Add(trainer);
            Trainer.Courses.Add(course);
        }
        public void DisplayTrainers()
        {
            Console.WriteLine(Course.Title);
            foreach (var item in Course.Trainers)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
        }
        public void DisplayCourses()
        {
            Console.WriteLine(Trainer.FirstName);
            foreach (var item in Trainer.Courses)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
        }
    }
    /// <summary>
    /// One-to-many relationship. One course can have multiple assignments
    /// </summary>
    public class AssignmentsPerCourse
    {
        Course Course;
        public AssignmentsPerCourse(Course course, List<Assignment> assignments)
        {
            Course = course;
            Course.Assignments = assignments;
            foreach (var item in assignments)
            {
                item.Course = course;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine(Course.Title);
            foreach (var item in Course.Assignments)
            {
                Console.Write("\t");
                Console.WriteLine(item.Title);
            }
        }
    }
}
