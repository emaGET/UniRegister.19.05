namespace UniRegister._19._05
{
    internal class Student
    {
        
        private string name;
        private int age;
        private string studentId;
        private string course;
        
        public Student(string name, int age, string studentId, string course)
        {
            this.name = name;
            this.age = age;
            this.studentId = studentId;
            this.course = course;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student: {name},\nAge: {age},\nID: {studentId}\nCourse: {course}");
        }
    }
}