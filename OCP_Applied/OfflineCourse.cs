namespace OCP_Applied
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            // subscribe code specific to Offline Course type
        }

        public override bool CheckCourseAvailability(Course course, string studentState)
        {
            var result = false;
            // code to check course availability in student state
            result = true; // just for simplicity (in actual there should be a DB call to get the result)
            return result;
        }
    }
}
