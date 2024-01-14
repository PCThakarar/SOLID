namespace OCP_Applied
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
        private Logger _logger = new Logger();
        public void Save()
        {
            _logger.Log("Starting Save()");
            StudentRepository sr = new StudentRepository();
            sr.Save(this);
            _logger.Log("End Save()");
        }

        public void Delete()
        {
            _logger.Log("Starting Delete()");

            _logger.Log("End Delete()");
        }
    }

    public class StudentRepository()
    {
        private Logger _logger = new Logger();
        private DevLogger _devLogger = new DevLogger();

        public void Save(Student std)
        {
            _logger.Log("Starting Save()");

            //use EF to add a new student or update existing student to db

            _logger.Log("Ending Saving()");
        }

        public void Delete()
        {
            _logger.Log("Starting Delete()");

            //use EF to delete a student 

            _logger.Log("Ending Delete()");
        }

        public void SaveCourse(Student std, Course cs)
        {
            _logger.Log("Starting SaveCourse()");

            //use EF to save a course for a student
            _devLogger.Debug("EF operation successful");

            _logger.Log("Ending SaveCourse()");
        }
    }
}
