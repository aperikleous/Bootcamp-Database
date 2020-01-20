using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace DatabaseLibrary
{
    public class Database
    {
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();
        List<Assignment> assignments = new List<Assignment>();
        List<Trainer> trainers = new List<Trainer>();
        List<StudentCourse> studentCourses = new List<StudentCourse>();
        List<TrainerCourse> trainerCourses = new List<TrainerCourse>();
        List<AssignmentsPerCourse> assignmentsPerCourse = new List<AssignmentsPerCourse>();
        List<StudentAssignment> studentAssignments = new List<StudentAssignment>();
        /// <summary>
        /// The database constructor where all entities are constructed and connected accordingly in the database
        /// </summary>
        public Database()
        {
            Student s1 = new Student("Alex", "Perikleous", new DateTime(1993, 12, 06), 2500);
            Student s2 = new Student("Xenofon", "Vlachogiannis", new DateTime(1989, 06, 01), 2200);
            Student s3 = new Student("Zack", "Drimiskianakis", new DateTime(1993, 12, 11), 3000);
            Student s4 = new Student("Eleni", "Parisi", new DateTime(1989, 06, 03), 2400);
            Student s5 = new Student("Panagiotis", "Rizos", new DateTime(1993, 07, 02), 2600);
            Student s6 = new Student("Alexandros", "Nomikos", new DateTime(1973, 04, 25), 2700);
            Student s7 = new Student("Konstantinos", "Argyropoulos", new DateTime(1990, 08, 01), 2800);
            Student s8 = new Student("Chris", "Vasilakis", new DateTime(1989, 04, 09), 2900);
            Student s9 = new Student("Thanasis", "Kontodimas", new DateTime(1991, 08, 03), 2000);
            Student s10 = new Student("Thanos", "Katrakis", new DateTime(1988, 02, 01), 3000);

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);
            students.Add(s10);

            Course c1 = new Course("CB9", "C#", "Full-Time", new DateTime(2019, 11, 11), new DateTime(2020, 03, 01));
            Course c2 = new Course("CB8", "C#", "Part-Time", new DateTime(2019, 11, 18), new DateTime(2020, 06, 01));
            Course c3 = new Course("JB9", "Java", "Full-Time", new DateTime(2019, 11, 11), new DateTime(2020, 06, 03));
            Course c4 = new Course("JB8", "Java", "Part-Time", new DateTime(2019, 11, 18), new DateTime(2020, 06, 01));

            courses.Add(c1);
            courses.Add(c2);
            courses.Add(c3);
            courses.Add(c4);

            Assignment a1 = new Assignment("ChessMaster", "Assign random pieces to chessboard", new DateTime(2020, 03, 06), 30, 100);
            Assignment a2 = new Assignment("Databases", "Connect to database", new DateTime(2020, 02, 01), 20, 100);
            Assignment a3 = new Assignment("String assignment", "Randomize string inputs", new DateTime(2020, 04, 01), 15, 100);
            Assignment a4 = new Assignment("C#", "Fundamentals of OOP", new DateTime(2020, 05, 20), 30, 100);
            Assignment a5 = new Assignment("Headfirst", "Advanced abstract classes", new DateTime(2020, 04, 22), 30, 100);

            assignments.Add(a1);
            assignments.Add(a2);
            assignments.Add(a3);
            assignments.Add(a4);
            assignments.Add(a5);

            Trainer t1 = new Trainer("Panagiotis", "Bozas", "OOP");
            Trainer t2 = new Trainer("Kostas", "Zitis", "SQL");
            Trainer t3 = new Trainer("George", "Pasparakis", "Databases");
            Trainer t4 = new Trainer("Ektoras", "Gantzos", "C#");

            trainers.Add(t1);
            trainers.Add(t2);
            trainers.Add(t3);
            trainers.Add(t4);

            StudentCourse SC1 = new StudentCourse(students[0], courses[0]);
            StudentCourse SC2 = new StudentCourse(students[1], courses[0]);
            StudentCourse SC3 = new StudentCourse(students[2], courses[0]);
            StudentCourse SC4 = new StudentCourse(students[3], courses[0]);
            StudentCourse SC5 = new StudentCourse(students[3], courses[1]);
            StudentCourse SC6 = new StudentCourse(students[4], courses[1]);
            StudentCourse SC7 = new StudentCourse(students[5], courses[1]);
            StudentCourse SC8 = new StudentCourse(students[6], courses[2]);
            StudentCourse SC9 = new StudentCourse(students[7], courses[2]);
            StudentCourse SC10 = new StudentCourse(students[8], courses[3]);
            StudentCourse SC11 = new StudentCourse(students[9], courses[3]);

            studentCourses.Add(SC1);
            studentCourses.Add(SC2);
            studentCourses.Add(SC3);
            studentCourses.Add(SC4);
            studentCourses.Add(SC5);
            studentCourses.Add(SC6);
            studentCourses.Add(SC7);
            studentCourses.Add(SC8);
            studentCourses.Add(SC9);
            studentCourses.Add(SC10);
            studentCourses.Add(SC11);

            TrainerCourse TC1 = new TrainerCourse(trainers[0], courses[0]);
            TrainerCourse TC2 = new TrainerCourse(trainers[1], courses[0]);
            TrainerCourse TC3 = new TrainerCourse(trainers[1], courses[1]);
            TrainerCourse TC4 = new TrainerCourse(trainers[2], courses[1]);
            TrainerCourse TC5 = new TrainerCourse(trainers[2], courses[2]);
            TrainerCourse TC6 = new TrainerCourse(trainers[3], courses[3]);

            trainerCourses.Add(TC1);
            trainerCourses.Add(TC2);
            trainerCourses.Add(TC3);
            trainerCourses.Add(TC4);
            trainerCourses.Add(TC5);
            trainerCourses.Add(TC6);

            List<Assignment> assignments1 = new List<Assignment> { assignments[0], assignments[1] };
            AssignmentsPerCourse APC1 = new AssignmentsPerCourse(courses[0], assignments1);

            List<Assignment> assignments2 = new List<Assignment> { assignments[2] };
            AssignmentsPerCourse APC2 = new AssignmentsPerCourse(courses[1], assignments2);

            List<Assignment> assignments3 = new List<Assignment> { assignments[3] };
            AssignmentsPerCourse APC3 = new AssignmentsPerCourse(courses[2], assignments3);

            List<Assignment> assignments4 = new List<Assignment> { assignments[4] };
            AssignmentsPerCourse APC4 = new AssignmentsPerCourse(courses[3], assignments4);

            assignmentsPerCourse.Add(APC1);
            assignmentsPerCourse.Add(APC2);
            assignmentsPerCourse.Add(APC3);
            assignmentsPerCourse.Add(APC4);

            StudentAssignment SA1 = new StudentAssignment(students[0], assignments[0]);
            StudentAssignment SA2 = new StudentAssignment(students[0], assignments[1]);
            StudentAssignment SA3 = new StudentAssignment(students[1], assignments[0]);
            StudentAssignment SA4 = new StudentAssignment(students[1], assignments[1]);
            StudentAssignment SA5 = new StudentAssignment(students[2], assignments[0]);
            StudentAssignment SA6 = new StudentAssignment(students[2], assignments[1]);
            StudentAssignment SA7 = new StudentAssignment(students[3], assignments[0]);
            StudentAssignment SA8 = new StudentAssignment(students[3], assignments[1]);
            StudentAssignment SA9 = new StudentAssignment(students[3], assignments[2]);
            StudentAssignment SA10 = new StudentAssignment(students[4], assignments[2]);
            StudentAssignment SA11 = new StudentAssignment(students[5], assignments[2]);
            StudentAssignment SA12 = new StudentAssignment(students[6], assignments[3]);
            StudentAssignment SA13 = new StudentAssignment(students[7], assignments[3]);
            StudentAssignment SA14 = new StudentAssignment(students[8], assignments[4]);
            StudentAssignment SA15 = new StudentAssignment(students[9], assignments[4]);

            studentAssignments.Add(SA1);
            studentAssignments.Add(SA2);
            studentAssignments.Add(SA3);
            studentAssignments.Add(SA4);
            studentAssignments.Add(SA5);
            studentAssignments.Add(SA6);
            studentAssignments.Add(SA7);
            studentAssignments.Add(SA8);
            studentAssignments.Add(SA9);
            studentAssignments.Add(SA10);
            studentAssignments.Add(SA11);
            studentAssignments.Add(SA12);
            studentAssignments.Add(SA13);
            studentAssignments.Add(SA14);
            studentAssignments.Add(SA15);

        }
        /// <summary>
        /// This function prints the database letters. It is what the user sees when they start the application and when they close it
        /// </summary>
        /// <param name="color">If color is green, the database letters are displayed in green. This is the initial database screen. 
        /// If color is red, the database letters are displayed in red. This is the ending database screen.</param>
        public void DisplayDatabaseScreen(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("****************************************************************************************************************************************");
            Console.WriteLine("****************************************************************************************************************************************");
            Console.WriteLine("*****                                                                                                                              *****");
            Console.WriteLine("*****  *********            ****         **********         ****           *******            ****         *********    *********  *****");
            Console.WriteLine("*****  **********          ******        **********        ******          ********          ******        *********    *********  *****");
            Console.WriteLine("*****  ***    ****        ***  ***          ****          ***  ***         **    ***        ***  ***       ***          ***        *****");
            Console.WriteLine("*****  ***    *****      ***    ***         ****         ***    ***        ********        ***    ***      *********    *********  *****");
            Console.WriteLine("*****  ***    *****     ************        ****        ************       ********       ************     *********    *********  *****");
            Console.WriteLine("*****  ***    ****     **************       ****       **************      **    ***     **************          ***    ***        *****");
            Console.WriteLine("*****  **********     ***          ***      ****      ***          ***     ********     ***          ***   *********    *********  *****");
            Console.WriteLine("*****  *********     ***            ***     ****     ***            ***    *******     ***            ***  *********    *********  *****");
            Console.WriteLine("*****                                                                                                                              *****");
            Console.WriteLine("****************************************************************************************************************************************");
            Console.WriteLine("****************************************************************************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// This is the main menu that is initially displayed on screen. The user may choose whether they want to work with synthetic data or type in their own entities
        /// </summary>
        public void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Welcome to the school database! Would you like to work with the preexisting data in the database or would you rather create your own?");
            Console.WriteLine("Press:");
            Console.WriteLine("\t 1 - to work with synthetic data");
            Console.WriteLine("\t 2 - to provide your own input");
            Console.WriteLine("\t 3 - to exit the program");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please Enter a valid numerical value between 1 and 3!");
            }
            if (input == 1)
            {
                SyntheticData();
            }
            else if (input == 2)
            {
                UserInput();
            }
            else if (input == 3)
            {
                DisplayDatabaseScreen(ConsoleColor.Red);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid number. Maybe you would like to take a look at the options again?");
                MainMenu();
            }
        }
        /// <summary>
        /// This is the menu that provides the main functionality for the database.At any point, the user may return to the main menu or exit the program
        /// </summary>
        public void ServicesMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("The database offers the following services:");
            Console.WriteLine("\t 1 - to get all students");
            Console.WriteLine("\t 2 - to get all trainers");
            Console.WriteLine("\t 3 - to get all assignments");
            Console.WriteLine("\t 4 - to get all courses");
            Console.WriteLine("\t 5 - to get all students per course");
            Console.WriteLine("\t 6 - to get all trainers per course");
            Console.WriteLine("\t 7 - to get all assignments per course");
            Console.WriteLine("\t 8 - to get all assignments per student");
            Console.WriteLine("\t 9 - to get a list of students that belong to more than one courses");
            Console.WriteLine("\t 10 - to input a date and get a list of students that need to submit an assignment on the same calendar week");
            Console.WriteLine("\t 11 - to return to the main menu");
            Console.WriteLine("\t 12 - to exit the program");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please Enter a valid numerical value between 1 and 12!");
            }
            if (input == 1)
            {
                students.ForEach(student => student.ShowInfo());
                ServicesMenu();
            }
            else if (input == 2)
            {
                trainers.ForEach(trainer => trainer.ShowInfo());
                ServicesMenu();
            }
            else if (input == 3)
            {
                assignments.ForEach(assignment => assignment.ShowInfo());
                ServicesMenu();
            }
            else if (input == 4)
            {
                courses.ForEach(course => course.ShowInfo());
                ServicesMenu();
            }
            else if (input == 5)
            {
                courses.ForEach(course => course.DisplayStudents());
                ServicesMenu();
            }
            else if (input == 6)
            {
                courses.ForEach(course => course.DisplayTrainers());
                ServicesMenu();
            }
            else if (input == 7)
            {
                courses.ForEach(course => course.DisplayAssignments());
                ServicesMenu();
            }
            else if (input == 8)
            {
                students.ForEach(student => student.DisplayAssignments());
                ServicesMenu();
            }
            else if (input == 9)
            {
                studentsInMultipleCourses(students);
                ServicesMenu();
            }
            else if (input == 10)
            {
                detectDeadlines(students);
                ServicesMenu();
            }
            else if (input == 11)
            {
                MainMenu();
            }
            else if (input == 12)
            {
                DisplayDatabaseScreen(ConsoleColor.Red);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid number. Maybe you would like to take a look at the options again?");
                ServicesMenu();
            }
        }
        /// <summary>
        /// This function displays the message that confirms that the user is going to work with synthetic data and displays the services menu for the database
        /// </summary>
        public void SyntheticData()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You have chosen to work with synthetic data");
            Console.WriteLine("We have automatically created all the necessary entities and filled the database for you!");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            ServicesMenu();
        }
        /// <summary>
        /// This function is responsible for retrieving a valid int value
        /// </summary>
        /// <returns></returns>
        public int IntegerInput()
        {
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
            }
            return input;
        }
        /// <summary>
        /// This function is responsible for retrieving a string by the user
        /// </summary>
        /// <returns></returns>
        public string StringInput()
        {
            string input = Console.ReadLine();
            return input;
        }
        /// <summary>
        /// This function is responsible for retrieving a DateTime value by the user in the correct format
        /// </summary>
        /// <returns></returns>
        public DateTime DateInput()
        {
            DateTime input = new DateTime();
            while (!DateTime.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please Enter a valid date!");
            }
            return input;
        }
        /// <summary>
        /// This function creates students submitted by the user and adds them to the list of students in the database.
        /// Once the user has no more students to submit, they are returned to the input menu.
        /// </summary>
        public void StudentInput()
        {
            string input;
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please type in the first name of the student");
                string firstname = StringInput();
                Console.WriteLine("Please type in the last name of the student");
                string lastname = StringInput();
                Console.WriteLine("Please type in the student's date of birth (format : dd/mm/yyyy)");
                DateTime dateofbirth = DateInput();
                Console.WriteLine("Please type in the student's tuition fees");
                int tuitionfees = IntegerInput();
                Student s = new Student(firstname, lastname, dateofbirth, tuitionfees);
                students.Add(s);
                Console.WriteLine();
                Console.WriteLine("Great work! A new student has been added to the database.");
                Console.WriteLine("Do you want to continue adding students? Type N or n if you want to return to the previous menu or any other button to continue adding");
                input = Console.ReadLine().ToUpper();
            } while (input != "N");
            InputMenu();
        }
        /// <summary>
        /// This function creates trainers submitted by the user and adds them to the list of trainers in the database.
        /// Once the user has no more trainers to submit, they are returned to the input menu.
        /// </summary>
        public void TrainerInput()
        {
            string input;
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please type in the first name of the trainer");
                string firstname = StringInput();
                Console.WriteLine("Please type in the last name of the trainer");
                string lastname = StringInput();
                Console.WriteLine("Please type in the trainer's subject");
                string subject = StringInput();
                Trainer t = new Trainer(firstname, lastname, subject);
                trainers.Add(t);
                Console.WriteLine();
                Console.WriteLine("Great work! A new trainer has been added to the database.");
                Console.WriteLine("Do you want to continue adding trainers? Type N or n if you want to return to the previous menu or any other button to continue adding");
                input = Console.ReadLine().ToUpper();
            } while (input != "N");
            InputMenu();
        }
        /// <summary>
        /// This function creates assignments submitted by the user and adds them to the list of assignments in the database.
        /// Once the user has no more assignments to submit, they are returned to the input menu.
        /// </summary>
        public void AssignmentInput()
        {
            string input;
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please type in the title of the assignment");
                string title = StringInput();
                Console.WriteLine("Please type in the description of the assignment");
                string description = StringInput();
                Console.WriteLine("Please type in the submission date of the assignment (format : dd/mm/yyyy)");
                DateTime subdate = DateInput();
                Console.WriteLine("Please type in the oral mark of the assignment");
                int oralmark = IntegerInput();
                Console.WriteLine("Please type in the total mark of the assignment");
                int totalmark = IntegerInput();
                Assignment a = new Assignment(title, description, subdate, oralmark, totalmark);
                assignments.Add(a);
                Console.WriteLine();
                Console.WriteLine("Great work! A new assignment has been added to the database.");
                Console.WriteLine("Do you want to continue adding assignments? Type N or n if you want to return to the previous menu or any other button to continue adding");
                input = Console.ReadLine().ToUpper();
            } while (input != "N");
            InputMenu();
        }
        /// <summary>
        /// This function creates courses submitted by the user and adds them to the list of courses in the database.
        /// Once the user has no more courses to submit, they are returned to the input menu.
        /// </summary>
        public void CourseInput()
        {
            string input;
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please type in the title of the course");
                string title = StringInput();
                Console.WriteLine("Please type in the stream of the course");
                string stream = StringInput();
                Console.WriteLine("Please type in the type of the course");
                string type = StringInput();
                Console.WriteLine("Please type in the starting date of the course");
                DateTime startdate = DateInput();
                Console.WriteLine("Please type in the end date of the course");
                DateTime enddate = DateInput();
                Course c = new Course(title, stream, type, startdate, enddate);
                courses.Add(c);
                Console.WriteLine();
                Console.WriteLine("Great work! A new course has been added to the database.");
                Console.WriteLine("Do you want to continue adding courses? Type N or n if you want to return to the previous menu or any other button to continue adding");
                input = Console.ReadLine().ToUpper();
            } while (input != "N");
            InputMenu();
        }
        /// <summary>
        /// This is the menu that allows the user to choose which type of entity they are going to submit.
        /// They can also move on to the database itself and access its services directly from this menu(Option 5)
        /// Finally, they can return to the main menu (Option 6) or exit the program itself(Option 7)
        /// </summary>
        public void InputMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Choose the entity you want to create from the list below:");
            Console.WriteLine("\t 1 - to add a new student");
            Console.WriteLine("\t 2 - to add a new trainer");
            Console.WriteLine("\t 3 - to add a new assignment");
            Console.WriteLine("\t 4 - to add a new course");
            Console.WriteLine("\t 5 - to access the database");
            Console.WriteLine("\t 6 - to return to the main menu");
            Console.WriteLine("\t 7 - to exit the program");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            int input = 0;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please Enter a valid numerical value between 1 and 6!");
            }
            if (input == 1)
            {
                StudentInput();
            }
            else if (input == 2)
            {
                TrainerInput();
            }
            else if (input == 3)
            {
                AssignmentInput();
            }
            else if (input == 4)
            {
                CourseInput();
            }
            else if (input == 5)
            {
                ServicesMenu();
            }
            else if (input == 6)
            {
                MainMenu();
            }
            else if (input == 7)
            {
                DisplayDatabaseScreen(ConsoleColor.Red);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid number. Maybe you would like to take a look at the options again?");
                InputMenu();
            }
        }
        /// <summary>
        /// This function prints the message confirming that the user can now submit their own entities and displays the input menu
        /// </summary>
        public void UserInput()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("You have chosen to type in your own data");
            Console.WriteLine("We have automatically created all the necessary entities and filled the database for you!");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");
            InputMenu();
        }

        public void Start()
        {
            DisplayDatabaseScreen(ConsoleColor.Green);
            MainMenu();

        }
        /// <summary>
        /// This function scans the entire list of students, looks at their number of courses and prints the students that attend more than one course
        /// </summary>
        /// <param name="students"></param>
        public void studentsInMultipleCourses(List<Student> students)
        {
            foreach (Student s in students)
            {
                if (s.Courses.Count > 1)
                {
                    s.DisplayCourses();
                }
            }
        }
        /// <summary>
        /// This function scans the entire list of students and looks for the assignments that have a submission date in the same calendar week as the input date
        /// </summary>
        /// <param name="students"></param>
        public void detectDeadlines(List<Student> students)
        {
            Console.WriteLine("Give me a date and i will print a list of all the students that need to submit one or more assignments on the same calendar week");
            DateTime submittedDate = DateInput();
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            analyzeDate(submittedDate, ref startDate, ref endDate);
            foreach (Student s in students)
            {
                foreach (Assignment a in s.Assignments)
                {
                    if ((startDate <= a.SubDateTime) && (a.SubDateTime <= endDate))
                    {
                        Console.WriteLine("The following student");
                        s.ShowInfo();
                        Console.WriteLine($"needs to submit the following assignment for the course {a.Course.Title} on this calendar week");
                        a.ShowInfo();
                    }
                }
            }
        }
        /// <summary>
        /// Given a submitted date, this function calculates the start and end date of the calendar week
        /// </summary>
        /// <param name="submittedDate"> This is the date that is typed in by the user</param>
        /// <param name="startDate"> This will be the first day of the calendar week of the submittedDate</param>
        /// <param name="endDate"> This will be the last day of the calendar week of the submittedDate</param>
        public void analyzeDate(DateTime submittedDate, ref DateTime startDate, ref DateTime endDate)
        {
            if (submittedDate.DayOfWeek == DayOfWeek.Saturday)
            {
                startDate = submittedDate.AddDays(-5);
                endDate = submittedDate.AddDays(-1);
            }
            else if (submittedDate.DayOfWeek == DayOfWeek.Sunday)
            {
                startDate = submittedDate.AddDays(-6);
                endDate = submittedDate.AddDays(-2);
            }
            else if (submittedDate.DayOfWeek == DayOfWeek.Friday)
            {
                startDate = submittedDate.AddDays(-4);
                endDate = submittedDate;
            }
            else if (submittedDate.DayOfWeek == DayOfWeek.Thursday)
            {
                startDate = submittedDate.AddDays(-3);
                endDate = submittedDate.AddDays(1);
            }
            else if (submittedDate.DayOfWeek == DayOfWeek.Wednesday)
            {
                startDate = submittedDate.AddDays(-2);
                endDate = submittedDate.AddDays(2);
            }
            else if (submittedDate.DayOfWeek == DayOfWeek.Tuesday)
            {
                startDate = submittedDate.AddDays(-1);
                endDate = submittedDate.AddDays(3);
            }
            else if (submittedDate.DayOfWeek == DayOfWeek.Monday)
            {
                startDate = submittedDate;
                endDate = submittedDate.AddDays(4);
            }
        }
    }
}
