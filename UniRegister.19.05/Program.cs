namespace UniRegister._19._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            // var student1 = 
            students.Add(new Student("Jorge Jorgensen", 27 , "jj2726", "Law and Order"));
            // var student2 = 
            students.Add(new Student("Bjørn Bjørnsen", 28 , "bb2826", "CompSci"));
            // var student3 = 
            students.Add(new Student("Morten Mortensen", 29, "mm2926", "History"));
            
            // student1.PrintInfo();
            // student2.PrintInfo();
            // student3.PrintInfo();

            students[0].PrintInfo();
            students[1].PrintInfo();
            students[2].PrintInfo();

        }
    }
}