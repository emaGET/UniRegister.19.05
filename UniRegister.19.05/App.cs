using UniRegister._19._05;
internal class App
{
    private List<Student> students = new List<Student>();


        
    public void Start()
    {
        bool isRunning = true;
        // students.Add(new Student("Jorge Jorgensen", 27 , "jj2726", "Law and Order", 1, 943162, 60));
        // students.Add(new Student("Bjørn Bjørnsen", 28 , "bb2826", "CompSci", 2, 243160, 90));
        // students.Add(new Student("Morten Mortensen", 29, "mm2926", "History", 1, 073195, 30));


        while (isRunning)
        {
            Console.WriteLine("--- UniRegister ---");
            Console.WriteLine("1 - Show students");
            Console.WriteLine("2 - Add new student");
            Console.WriteLine("3 - Exit");

            string input = Console.ReadLine();

            // if (input == "1")
            // {
                // foreach (Student student in students)
                // {
                    // student.PrintInfo();
                
                    // if (student.IsRepeating())
                    // {
                    //     Console.WriteLine("[REPEATING]\n");
                    // }
                // }

            // }

            if (input == "1") PrintInfo();

            else if (input == "2") AddNewStudent();

            else if (input == "3")
            {
                isRunning = false;
            }
        }
    }

    private void AddNewStudent()
    {
        Console.WriteLine("What is the student's name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is the student's age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the student's Id?");
        string studentId = Console.ReadLine();

        Console.WriteLine("What is the course's name?");
        string course = Console.ReadLine();

        Console.WriteLine("How many times has the student partaken in the course?");
        int repeating = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the student's personal number?");
        int pnummer = int.Parse(Console.ReadLine());

        Console.WriteLine("How many credits has the student collected so far?");
        int credits = int.Parse(Console.ReadLine());

        students.Add(new Student(name, age, studentId, course, repeating, pnummer, credits));


    }

    private void StudentsList()
    {
        foreach (Student students in students)
        {
            Student.PrintInfo();
        }
    }
    

}