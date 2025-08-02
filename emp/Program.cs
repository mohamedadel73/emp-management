namespace emp
{
    struct Employee
    {
        public int ID;
        public string Name;
        public double Salary;

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value <= 32)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine(" Invalid Age. Age must be between 18 and 32.\n");
                    

                }
            }
        }

        public bool AddEmployee()
        {
            Console.Write("Enter Employee ID: ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Employee Age: ");
            int inputAge = Convert.ToInt32(Console.ReadLine());

            if (inputAge >= 18 && inputAge <= 32)
            {
                Age = inputAge;
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Age. Emp NOT added.\n");
                return false;
            }
        }


        public void DisplayEmployee()
        {
            if (Age == 0)
            {
                Console.WriteLine("Skipping invalid employee record.");
                return;
            }

            Console.WriteLine("\n--- Emp Details ---");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Age: {Age}");
        }
    }


    internal class Program
        {
            static void Main(string[] args)
            {
            Console.Write("Enter the maximum number of emps: ");
            int max = Convert.ToInt16(Console.ReadLine());

            Employee[] employees = new Employee[max];
            int currentCount = 0;

            while (true)
            {
                Console.WriteLine("\n====== Emp Menu ======");
                Console.WriteLine("1 - Add New Emp");
                Console.WriteLine("2 - Display All Emp");
                Console.WriteLine("3 - Exit");
                Console.Write("plz Choose an option: ");
                int choice =Convert.ToInt16( Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (currentCount >= max)
                        {
                            Console.WriteLine("Cannot add more emps. Array is full.");
                            break;
                        }

                        Employee emp = new Employee();
                        bool added = emp.AddEmployee();

                        if (added)
                        {
                            employees[currentCount] = emp;
                            currentCount++;
                            Console.WriteLine("Emp added successfully.");
                        }
                        break;

                    case 2:
                        if (currentCount == 0)
                        {
                            Console.WriteLine("No emps to display.");
                            break;
                        }

                        Console.WriteLine("\n All Emps:");
                        for (int i = 0; i < currentCount; i++)
                        {
                            employees[i].DisplayEmployee();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting the program");
                        return;
                    default:
                        Console.WriteLine(" Invalid option,Plz choose 1, 2, or 3.");
                        break;

                
                }
            }
        }
    }
}
        
    


