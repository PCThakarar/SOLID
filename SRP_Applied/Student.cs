namespace SOLID_Applied
{
    public class Student
    {
        public int StudentID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public void Save()
        {
            Logger.Log("Starting Save()");

            Logger.Log("End Save()");
        }

        public void Delete()
        {
            Logger.Log("Starting Delete()");

            Logger.Log("End Delete()");
        }
    }

    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class StudentRepository()
    {
        public void Save(Student std)
        {
            Logger.Log("Starting Save()");

            //use EF to add a new student or update existing student to db

            Logger.Log("Ending Saving()");
        }

        public void Delete()
        {
            Logger.Log("Starting Delete()");

            //use EF to delete a student 

            Logger.Log("Ending Delete()");
        }

        public void SaveCourse(Student std, Course cs)
        {
            Logger.Log("Starting SaveCourse()");

            //use EF to save a course for a student

            Logger.Log("Ending SaveCourse()");
        }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public string? Type { get; set; }

        public void Subscribe(Student std)
        {
            Logger.Log("Starting Subscribe()");

            //violating OCP here, if we add a new course type, we need to modify this method
            //apply business rules based on the course type live, online, offline, if any 
            if (Type == "online")
            {
                //subscribe to online course 
            }
            else if (Type == "live")
            {
                //subscribe to offline course 
            }

            // payment processing
            PaymentManager.ProcessPayment();

            //create CourseRepository class to save student and course into StudentCourse table  

            // send confirmation email
            EmailManager.SendEmail();

            Logger.Log("End Subscribe()");
        }
    }

    public class EmailManager
    {
        public static void SendEmail()
        {
            // smtp code here
        }
    }

    public class PaymentManager
    {
        public static void ProcessPayment()
        {
            //payment processing code here
        }
    }
}
