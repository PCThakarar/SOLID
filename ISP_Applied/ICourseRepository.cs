namespace ISP_Applied
{
    public interface ICourseRepository
    {
        void SaveCourse(Student std, Course cs);
        void DeleteCourse(Course cs);
        void UpdateCourse(Course cs);
        Course GetCourse(int courseId);
    }
}
