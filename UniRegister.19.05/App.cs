using UniRegister._19._05;

internal class App
{
    private List<Student> students = new List<Student>();


        
    public void Start()
    {
        bool isRunning = true;
        
        students.Add(new Student("Jorge Jorgensen", 27 , "jj2726", "Law and Order", 1, 943162, 60));
        students.Add(new Student("Bjørn Bjørnsen", 28 , "bb2826", "CompSci", 2, 243160, 90));
        students.Add(new Student("Morten Mortensen", 29, "mm2926", "History", 1, 073195, 30));

        while (isRunning)
        {
            Console.WriteLine("--- UniRegister ---");
            Console.WriteLine("1 - Show students");
            Console.WriteLine("2 - Exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                foreach (Student student in students)
                {
                    student.PrintInfo();
                
                    // if (student.IsRepeating())
                    // {
                    //     Console.WriteLine("[REPEATING]\n");
                    // }
                }

            }
            
            else if (input == "2")
            {
                isRunning = false;
            }
        }
    }

}