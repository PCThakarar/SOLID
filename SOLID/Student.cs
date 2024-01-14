namespace SOLID
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

        public void Save(Student student)
        {
            Console.WriteLine("Starting Save");
            // EF code to save student in DB
            Console.WriteLine("Ending Save");
        }

        public void Delete(int StudentId)
        {
            Console.WriteLine("Starting delete");
            // EF code to delete student based on StudentId
            Console.WriteLine("Ending delete");
        }


        public void Subscribe(Course cs)
        {
            Console.WriteLine("Starting Subscribe()");
            var paymentMethod = string.Empty;
            //apply business rules based on the course type 
            if (cs.Type == "online")
            {
                //validate
            }
            else if (cs.Type == "live")
            {

            }

            //payment processing code

            //save course subscription to DB

            //send email confirmation code

            Console.WriteLine("End Subscribe()");
        }
    }

    public class Course
    {
        public string? Type { get; set; }
    }
}
