using AlmazMethods;

namespace Almazmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            int choice;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Isci elave et");
                Console.WriteLine("2.Butun iscilere bax");
                Console.WriteLine("3.Maas araligina gore filtrele");
                Console.WriteLine("0.Proqrami bitir");
                Console.WriteLine("secim edin->");
                choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                 case 1:
                Employee newEmployee= new Employee();
                Console.Write("Name:");
                newEmployee.Name = Console.ReadLine();
                Console.Write("Surname:");
                newEmployee.Surname = Console.ReadLine();
                Console.Write("Age:");
                newEmployee.Age = Convert.ToByte(Console.ReadLine());
                Console.Write("DepartmentNo:");
                newEmployee.DepartmentNo = Convert.ToByte(Console.ReadLine());
                Console.Write("Salary:");
                newEmployee.Salary= Convert.ToDecimal(Console.ReadLine());
                department.AddEmployee(newEmployee);
                   break;
                 
                 case 2:
                        Console.WriteLine( "butun iscilerin siyahisi:");
                        department.ShowEmployeeInfo();
                        break;
                case 3:
                        Console.Write("minimim maas:");
                        decimal minSalary=Convert.ToDecimal(Console.ReadLine());
                        Console.Write("maksimum maas:");
                        decimal maxSalary=Convert.ToDecimal(Console.ReadLine());
                        Employee[] result=department.GetAllEmployeesBySalary(minSalary, maxSalary);
                        Console.WriteLine("maasa gore filtrelenen iscilerin melumatlari:");
                        foreach(  var employee in result)
                        {
                            Console.WriteLine($"{employee.Name},{employee.Surname},{employee.Age},{employee.DepartmentNo},{employee.Salary}");
                            
                        }
                        break;
                    case 0:
                        Console.WriteLine( "Proqam islemir");
                        break;
                    default:
                        Console.WriteLine("duzgun reqem secin");
                        break;


                }
            }
            while (choice != 0);
            
        }
    }
}
