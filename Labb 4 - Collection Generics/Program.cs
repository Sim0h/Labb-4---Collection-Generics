namespace Labb_4___Collection_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Del 1: 

            Employee employee1 = new Employee();
            employee1.Name = "Adam";
            employee1.Gender = "Male";
            employee1.ID = 101;
            employee1.Salary = 25000;

            Employee employee2 = new Employee();
            employee2.Name = "Sara";
            employee2.Gender = "Female";
            employee2.ID = 102;
            employee2.Salary = 28000;


            Employee employee3 = new Employee();
            employee3.Name = "Johan";
            employee3.Gender = "Male";
            employee3.ID = 103;
            employee3.Salary = 28350;


            Employee employee4 = new Employee();
            employee4.Name = "Alice";
            employee4.Gender = "Female";
            employee4.ID = 104;
            employee4.Salary = 30500;

            Employee employee5 = new Employee();
            employee5.Name = "Simon";
            employee5.Gender = "Male";
            employee5.ID = 105;
            employee5.Salary = 41800;


            Stack<Employee> Employeestack = new Stack<Employee>();
            Employeestack.Push(employee1);
            Employeestack.Push(employee2);
            Employeestack.Push(employee3);
            Employeestack.Push(employee4);
            Employeestack.Push(employee5);

            foreach (Employee emp in Employeestack)
            {
                Console.WriteLine($"ID: {emp.ID} - Name: {emp.Name} - Gender: {emp.Gender} - Salary: {emp.Salary}");
                Console.WriteLine("Items left in the Stack = {0}", Employeestack.Count);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Retrieve using Pop Method:");
            while (Employeestack.Count > 0)
            {
                Employee itemStack = Employeestack.Pop();
                Console.WriteLine($"ID: {itemStack.ID} - Name: {itemStack.Name} - Gender: {itemStack.Gender} - Salary: {itemStack.Salary}");
                Console.WriteLine("Items left in the Stack = {0}", Employeestack.Count);
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Retrieve using Peek Method:");

            Employeestack.Push(employee1);
            Employeestack.Push(employee2);
            Employeestack.Push(employee3);
            Employeestack.Push(employee4);
            Employeestack.Push(employee5);


            Employee itemPeek = Employeestack.Peek();
            Console.WriteLine($"ID: {itemPeek.ID} - Name: {itemPeek.Name} - Gender: {itemPeek.Gender} - Salary: {itemPeek.Salary}");
            Console.WriteLine("Items left in the Stack = {0}", Employeestack.Count);

            Employee itemPeek2 = Employeestack.Peek();
            Console.WriteLine($"ID: {itemPeek2.ID} - Name: {itemPeek2.Name} - Gender: {itemPeek2.Gender} - Salary: {itemPeek2.Salary}");
            Console.WriteLine("Items left in the Stack = {0}", Employeestack.Count);

            Console.WriteLine("-----------------------------------------");


            // Del 2: 
            Console.WriteLine("Contains method:");
            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);

            if (employees.Contains(employee2))
            {
                Console.WriteLine("Employee2 exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 does not exist in the list.");
            }

            Console.WriteLine("-----------------------------------------");


            Console.WriteLine("Find male method:");
            Employee MaleEmployee = employees.Find(e => e.Gender == "Male");
            Console.WriteLine($"ID: {MaleEmployee.ID} - Name: {MaleEmployee.Name} - Gender: {MaleEmployee.Gender} - Salary: {MaleEmployee.Salary}");


            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Find All males method");
            List<Employee> AllMaleEmployees = employees.FindAll(e => e.Gender == "Male");
            foreach (Employee emp in AllMaleEmployees)
            {
                Console.WriteLine($"ID: {emp.ID} - Name: {emp.Name} - Gender: {emp.Gender} - Salary: {emp.Salary}");
            }

            Console.ReadKey();
        }

    }
}