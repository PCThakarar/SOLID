namespace ISP_Applied
{
    public class Course
    {
        public int CourseId { get; set; }
        public string? Title { get; set; }
        public string? Type { get; set; }

        private Logger _logger = new Logger();

        public virtual void Subscribe(Student std)
        {
            _logger.Log("Starting Subscribe()");

            //subscribe to online course 

            // payment processing
            PaymentManager.ProcessPayment();

            //create CourseRepository class to save student and course into StudentCourse table  

            // send confirmation email
            EmailManager.SendEmail();

            _logger.Log("End Subscribe()");
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
