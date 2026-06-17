namespace UniRegister._19._05
{
    internal class Student
    {
        
        private string name;
        private int age;
        private string studentId;
        private string course;
        
        // for the method
        private int repeating;
        private int pnummer;
        private int credits;
        
        public Student(string name, int age, string studentId, string course, int repeating, int pnummer, int credits)
        {
            this.name = name;
            this.age = age;
            this.studentId = studentId;
            this.course = course;
            
            this.repeating = repeating;
            this.pnummer = pnummer;
            this.credits = credits;
        }
        
        // let's try a method for more students info... a card
        // public bool IsRepeating()
        // {
        //     return repeating > 1;
        // }

        public void PrintInfo()
        {
            Console.WriteLine($"--- Student Info ---\n \nStudent: {name}\nAge: {age}\nID: {studentId}\nCourse: {course}\n");
        }

        public void StudentCard()
        {
            Console.WriteLine($"--- {name} Private Card ---\nPersonal Number: {pnummer}\nCredits: {credits}\nNumber of course attempts: {repeating}\n");
        }
    }
}