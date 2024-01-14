namespace OCP_Applied
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // subscribe code specific to Online Course type
        }

        public override bool CheckCourseAvailability(Course course, string studentState)
        {
            throw new NotImplementedException();
        }
    }
}
