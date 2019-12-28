public class University
{
    public static bool getUnit(Student student, Lesson lesson)
    {
        if (Student.calculateAverage(student) > 17 && Student.calculateSumOfUnitsThat(student) + lesson.unit < 24)
        {
            student.thisTermLessons.Add(lesson);
            return true;
        }
        else if (Student.calculateAverage(student) < 17 && Student.calculateSumOfUnitsThat(student) + lesson.unit < 14)
        {
            student.thisTermLessons.Add(lesson);
            return true;
        }
        return false;
    }

    public static bool mashrooted(Student student) {
        if (Student.calculateAverage(student) < 12)
        {
            return true;
        }
        return false;
    }

}
