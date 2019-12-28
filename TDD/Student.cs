using System.Collections.Generic;

public class Student
{
    public string name { get; set; }
    public string family { get; set; }
    public int id { get; set; }
    public List<Lesson> thisTermLessons { get; set; }
    public List<Lesson> nextTermLesson { get; set; }
    public Student(string name, string family, int id)
    {
        this.name = name;
        this.family = family;
        this.id = id;
        thisTermLessons = new List<Lesson>();
        nextTermLesson = new List<Lesson>();
    }

    public static float calculateAverage(Student student)
    {
        float sum = 0;
        foreach (var lesson in student.thisTermLessons)
        {
            sum += lesson.grade * lesson.unit;
        }
        return sum / Student.calculateSumOfUnitsThis(student);
    }

    public static int calculateSumOfUnitsThat(Student student)
    {
        int units = 0;
        foreach (var lesson in student.nextTermLesson)
        {
            units += lesson.unit;
        }
        return units;
    }

    public static int calculateSumOfUnitsThis(Student student)
    {
        int units = 0;
        foreach (var lesson in student.thisTermLessons)
        {
            units += lesson.unit;
        }
        return units;
    }
}
