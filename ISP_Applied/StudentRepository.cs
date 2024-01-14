namespace ISP_Applied
{
    public class StudentRepository : IStudentRepository
    {
        private ILogger _logger;

        public StudentRepository(ILogger logger)
        {
            _logger = logger;
        }

        public void Save(Student std)
        {
            _logger.Log("Starting Save()");

            //use EF to add a new student or update existing student to db

            _logger.Log("Ending Saving()");
        }

        public void Delete(int studentId)
        {
            _logger.Log("Starting Delete()");

            //use EF to delete a student 

            _logger.Log("Ending Delete()");
        }

        public void Update(Student std)
        {
            _logger.Log("Starting Update");

            // use EF code to update student

            _logger.Log("Ending Update");
        }

        public Student GetStudent(int studentId) { return null; }

        public void SubscribeCourse(Course cs) { }

        public void UnSubscribeCourse(Course cs) { }

    }
}
