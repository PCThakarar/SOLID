namespace DIP_Applied
{
    public interface IStudentRepository
    {
        void Save(Student std);
        void Update(Student std);
        void Delete(int studentId);
        void SubscribeCourse(Course cs);
        void UnSubscribeCourse(Course cs);
        Student GetStudent(int studentId);
        void SaveCourse(Student std, Course cs);
        void DeleteCourse(Course cs);
        void UpdateCourse(Course cs);
        Course GetCourse(int courseId);
    }
}
