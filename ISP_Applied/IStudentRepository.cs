namespace ISP_Applied
{
    public interface IStudentRepository
    {
        void Save(Student std);
        void Update(Student std);
        void Delete(int studentId);
        void SubscribeCourse(Course cs);
        void UnSubscribeCourse(Course cs);
        Student GetStudent(int studentId);
    }
}
