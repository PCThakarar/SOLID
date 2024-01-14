namespace ISP_Applied
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

        private ILogger _logger;
        private IStudentRepository _studentRepository;

        public Student(IStudentRepository studentRepository, ILogger logger)
        { 
            _logger = logger;
            _studentRepository = studentRepository;
        }
        public void Save()
        {
            _logger.Log("Starting Save()");
            _studentRepository.Save(this);
            _logger.Log("End Save()");
        }

        public void Delete()
        {
            _logger.Log("Starting Delete()");
            _studentRepository.Delete(StudentID);
            _logger.Log("End Delete()");
        }
    }
}
