using Xunit;
    public class Test
{


    [Fact]
    public void testSumOfUnitThis() 
    {
        Student student1 = new Student("Shayan", "Shafaghi", 1);
        Lesson lesson1 = new Lesson(3, 18);
        Lesson lesson2 = new Lesson(3, 20);
        Lesson lesson3 = new Lesson(2, 11);
        Lesson lesson4 = new Lesson(4, 20);
        student1.thisTermLessons.Add(lesson1);
        student1.thisTermLessons.Add(lesson2);
        student1.thisTermLessons.Add(lesson3);
        student1.thisTermLessons.Add(lesson4);
        Assert.Equal(12,Student.calculateSumOfUnitsThis(student1));
    }

    [Fact]
    public void testSumOfUnitThat() 
    {
        Student student1 = new Student("Shayan", "Shafaghi", 1);
        Lesson lesson1 = new Lesson(3, 18);
        Lesson lesson2 = new Lesson(3, 20);
        Lesson lesson3 = new Lesson(2, 11);
        Lesson lesson4 = new Lesson(4, 20);
        student1.nextTermLesson.Add(lesson1);
        student1.nextTermLesson.Add(lesson2);
        student1.nextTermLesson.Add(lesson3);
        student1.nextTermLesson.Add(lesson4);
        Assert.Equal(12,Student.calculateSumOfUnitsThat(student1));
    }

    [Fact]
    public void testAverage() 
    {
        Student student1 = new Student("Shayan", "Shafaghi", 1);
        Lesson lesson1 = new Lesson(3, 18);
        Lesson lesson2 = new Lesson(3, 20);
        Lesson lesson3 = new Lesson(2, 11);
        Lesson lesson4 = new Lesson(4, 20);
        student1.thisTermLessons.Add(lesson1);
        student1.thisTermLessons.Add(lesson2);
        student1.thisTermLessons.Add(lesson3);
        student1.thisTermLessons.Add(lesson4);
        Assert.Equal(18,Student.calculateAverage(student1));
    }

    [Fact]
    public void testGetUnit() 
    {
        Student student1 = new Student("Shayan", "Shafaghi", 1);
        Lesson lesson1 = new Lesson(3, 18);
        Lesson lesson2 = new Lesson(3, 20);
        Lesson lesson3 = new Lesson(2, 11);
        Lesson lesson4 = new Lesson(4, 20);
        Lesson lesson5 = new Lesson(3, 0);
        student1.thisTermLessons.Add(lesson1);
        student1.thisTermLessons.Add(lesson2);
        student1.thisTermLessons.Add(lesson3);
        student1.thisTermLessons.Add(lesson4);
        Assert.Equal(true,University.getUnit(student1, lesson5));
    }

    [Fact]
    public void testMashrooted() 
    {
        Student student1 = new Student("Shayan", "Shafaghi", 1);
        Lesson lesson1 = new Lesson(3, 18);
        Lesson lesson2 = new Lesson(3, 20);
        Lesson lesson3 = new Lesson(2, 11);
        Lesson lesson4 = new Lesson(4, 20);
        Lesson lesson5 = new Lesson(3, 0);
        student1.thisTermLessons.Add(lesson1);
        student1.thisTermLessons.Add(lesson2);
        student1.thisTermLessons.Add(lesson3);
        student1.thisTermLessons.Add(lesson4);
        Assert.Equal(false,University.mashrooted(student1));
    }

}
