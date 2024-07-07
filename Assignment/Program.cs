namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "doaa", SecurityLevel.DBA, new HiringDate(15, 6, 2018), 50000, "F");
            EmpArr[1] = new Employee(2, "ahmed", SecurityLevel.Guest, new HiringDate(1, 1, 2020), 20000, "M");
            EmpArr[2] = new Employee(3, "mohamed", SecurityLevel.Secretary, new HiringDate(7, 7, 2024), 35000, "M");
            Array.Sort(EmpArr);
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }
            int Boxing = 0;
            int Unboxing = 0;

            foreach (var emp in EmpArr)
            {
                object obj = emp.Id;
                Boxing++;
                int id = (int)obj;
                Unboxing++;
            }

            Console.WriteLine($"Boxing = {Boxing}");
            Console.WriteLine($"Unboxing = {Unboxing}");
        }
    }
}
