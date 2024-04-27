using System;
using System.Collections.Generic;
using System.Linq;

namespace EFApp.Linq
{
    internal class Program
    {
        //Dictionary<anahtarTipi, SklanacakVerininTipi>

        //Dictionary<anahtardeğerinTipi_UniqeBirdeğerOlmali, Anahtarin_içerisindeki_VerininTipi>
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 12, 21, 21, 12, 12, 12, 12, 1, 3, 3, 5 };
            var uniquesNumber = numbers.Distinct().OrderBy(x => x);//12,21,1,2,5
            var uniquesNumber2 = uniquesNumber.Reverse().ToList();

            new List<string>() { "Esra", "Esra", "Tuğçe", "Onur", "Hamdi", "Hamdi", "Esra" }.Distinct();


            List<Employee> employees = EmployeeBusiness.GetEmployees();
            var names_ = employees.Select(emp => emp.Name); //select Name from TableName
            var departments = employees.Select(emp => emp.Department);
            var uniqueDepartments = departments.Distinct();

            var eployeeByCountry = employees.Select(emp => emp.Country)
                                            .Distinct()
                                            .ToList();


        }

        private static void NewMethod3()
        {
            List<Employee> employees = EmployeeBusiness.GetEmployees();

            var dictionaryEmployess = employees.ToDictionary(e => e.Name);
            //Dictionary<string, Employee> dic = new Dictionary<string, Employee>();

            Employee valurAdriana = dictionaryEmployess["Adriana"];
            Employee valueozle = dictionaryEmployess["Özlem"];
        }

        private static void NewMethod2()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Esra");
            dic.Add(2, "Ozan");
            dic.Add(3, "Burak");

            foreach (KeyValuePair<int, string> keyValueItem in dic)
            {
                int key = keyValueItem.Key;

                string value = keyValueItem.Value;
            }


            //Key value çifti fakat : 
            Dictionary<string, string> countryKeyValuepairs = new Dictionary<string, string>();
            countryKeyValuepairs.Add("Tr-ozan", "Ozan");
            countryKeyValuepairs.Add("Tr-tug", "Tuğçe");
            countryKeyValuepairs.Add("Tr-bek", "Bekir");
            countryKeyValuepairs.Add("Br-Adria", "Adriana");
            countryKeyValuepairs.Add("Br-Al", "Alex");
            countryKeyValuepairs.Add("Br-Al2", "Hande");


            foreach (KeyValuePair<string, string> keyValueItem in countryKeyValuepairs)
            {
                string key = keyValueItem.Key;

                string values = keyValueItem.Value;
            }

            //countryKeyValuepairs.Count - 1;
            var results = countryKeyValuepairs["Br-Adria"];

            string name = "sdsakdşlak-dlasşldkadşşdlşasld";
        }

        private static void NewMethod1()
        {
            //Personellerimizin toplam yaşı 
            /*
            List<Employee> employees = EmployeeBusiness.GetEmployees();
            int totalAges = employees.Sum(e => (DateTime.Now.Year - e.BirthDate.Year));
            double average = totalAges / employees.Count();
            double average2 = employees.Average(e => (DateTime.Now.Year - e.BirthDate.Year));
            */
            List<Employee> employees = EmployeeBusiness.GetEmployees();
            var persons = employees.OrderBy(e => e.Department);
            var personsDescending = employees.OrderByDescending(e => e.Department);

            var orders = employees.OrderBy(e => e.Department).ThenBy(e => e.Name);
            var orders2 = employees.OrderBy(e => e.Department).ThenByDescending(e => e.Name);
            //IT can
            //IT ali
            //IT ali IT can  
        }

        private static void Ex6()
        {
            List<Employee> employees = EmployeeBusiness.GetEmployees();
            var grouppingDatas = employees.ToLookup(e => e.Gender);

            foreach (var itemKeyAndValue in grouppingDatas)
            {
                Console.WriteLine(itemKeyAndValue.Key);

                foreach (var value in itemKeyAndValue)
                {
                    Console.WriteLine(value.GetEmployeeInfo());
                }
            }
        }

        private static void Ex5()
        {
            List<Employee> employees = EmployeeBusiness.GetEmployees();
            var grouppingDatas = employees.ToLookup(e => e.Gender).ToList();
            var firstGroup = grouppingDatas[0];
            var firstGroupKeyName = grouppingDatas[0].Key;

            Console.WriteLine($"Cisniyeti {firstGroupKeyName} olanların listesi ");
            foreach (Employee item in firstGroup)
            {
                Console.WriteLine(item.GetEmployeeInfo());
            }

            Console.WriteLine($"Cisniyeti {grouppingDatas[1].Key} olanların listesi ");
            foreach (Employee item in grouppingDatas[1])
            {
                Console.WriteLine(item.GetEmployeeInfo());
            }

            Console.WriteLine($"Cisniyeti {grouppingDatas[2].Key} olanların listesi ");
            foreach (Employee item in grouppingDatas[2])
            {
                Console.WriteLine(item.GetEmployeeInfo());
            }
        }

        private static void Ex4()
        {
            List<Employee> employees = EmployeeBusiness.GetEmployees();
            var models = employees.Where(employee => employee.Department == "Model").ToList();

            var models2 = (from e in employees
                           where e.Department == "Model"
                           select e).ToList();


            var modelofTurkey = employees.Where(employee => employee.Department == "Model" && employee.Country == "Turkey").ToList();
            var modelofTurkeyWithAge = employees.Where(employee => employee.Department == "Model"
                                                && employee.Country == "Turkey"
                                                && (DateTime.Now.Year - employee.BirthDate.Year > 30)
                                                ).ToList();


            var models2_ = (from e in employees
                            where e.Department == "Model" && e.Country == "Turkey" && (DateTime.Now.Year - e.BirthDate.Year > 30)
                            select e).ToList();


            var modelofTurkeyWithAgeUnder30 = employees.Where(employee => employee.Department == "Model"
                                                && employee.Country == "Turkey"
                                                && (DateTime.Now.Year - employee.BirthDate.Year <= 30)
                                                ).ToList();
        }

        private static void NewMethod()
        {
            //Lamda expression 
            List<Employee> employees = EmployeeBusiness.GetEmployees();

            //e=>e.Country =="Turkey"
            //Employee e2 = new Employee();
            //IEnumerable<Employee> turkeyEmployess = employees.Where(e => e.Country == "Turkey");
            List<Employee> turkeyEmployessList = employees.Where(e => e.Country == "Turkey").ToList();

            foreach (Employee employee in turkeyEmployessList)
            {
                //Console.WriteLine(employee.GetEmployeeInfo());
                Console.WriteLine(employee.Name);
            }


            /*
              foreach (Employee employee in employees)
            {
                List<Employee> employessOfTurkey = new List<Employee>();
                if (employee.Country=="Turkey")
                {
                    employessOfTurkey.Add(employee);
                }
            }
             */
        }
    }

    public class EmployeeBusiness
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, Name = "Onuralp", Country = "Turkey", Department = "IT", BirthDate = new DateTime(1980, 10, 10), Gender = Gender.Male });
            employees.Add(new Employee() { Id = 2, Name = "Tuğçe", Country = "Turkey", Department = "IT", BirthDate = new DateTime(1970, 10, 10), Gender = Gender.Female });
            employees.Add(new Employee() { Id = 3, Name = "Adriana", Country = "Brazil", Department = "Model", BirthDate = new DateTime(1974, 10, 10), Gender = Gender.Female });
            employees.Add(new Employee() { Id = 4, Name = "Sevda", Country = "Turkey", Department = "Model", BirthDate = new DateTime(1995, 10, 10), Gender = Gender.Female });
            employees.Add(new Employee() { Id = 111, Name = "Alex", Country = "Brazil", Department = "Footbol", BirthDate = new DateTime(1970, 10, 10), Gender = Gender.Male });
            employees.Add(new Employee() { Id = 11, Name = "Germinho", Country = "Brazil", Department = "Footbol", BirthDate = new DateTime(1992, 12, 12), Gender = Gender.Female });
            employees.Add(new Employee() { Id = 14, Name = "Arda", Country = "Turkey", Department = "Footbol", BirthDate = new DateTime(1999, 10, 10), Gender = Gender.Male });
            employees.Add(new Employee() { Id = 15, Name = "Hande", Country = "Turkey", Department = "Model", BirthDate = new DateTime(1970, 10, 10), Gender = Gender.Female });
            employees.Add(new Employee() { Id = 9, Name = "Bionce", Country = "Abd", Department = "Model", BirthDate = new DateTime(2000, 10, 10), Gender = Gender.Female });
            employees.Add(new Employee() { Id = 8, Name = "Stewe", Country = "Abd", Department = "IT", BirthDate = new DateTime(1970, 10, 10), Gender = Gender.Male });
            employees.Add(new Employee() { Id = 7, Name = "Özlem", Country = "Turkey", Department = "IT", BirthDate = new DateTime(1970, 10, 10), Gender = Gender.Male });
            employees.Add(new Employee() { Id = 117, Name = "Bekiros", Country = "Rusia", Department = "ECommerce", BirthDate = new DateTime(1970, 10, 10), Gender = Gender.Male });
            employees.Add(new Employee() { Id = 15, Name = "Ozanoski", Country = "Rusia", Department = "ECommerce", BirthDate = new DateTime(1998, 10, 10), Gender = Gender.Male });
            employees.Add(new Employee() { Id = 167, Name = "jale", Country = "Turkey", Department = "IT", BirthDate = new DateTime(1950, 12, 12), Gender = Gender.Female });
            employees.Add(new Employee() { Id = 111, Name = "Ramiz", Country = "Turkey", Department = "ECommerce", BirthDate = new DateTime(2000, 11, 10), Gender = Gender.Male });
            employees.Add(new Employee() { Id = 133, Name = "Yuşa", Country = "Turkey", Department = "Model", BirthDate = new DateTime(1960, 12, 12), Gender = Gender.Male });
            employees.Add(new Employee() { Id = 1555, Name = "Feraye", Country = "Turkey", Department = "Model", BirthDate = new DateTime(1960, 12, 12), Gender = Gender.Other });

            return employees;
        }
    }
    public partial class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }

        public string GetEmployeeInfo()
        {
            string employeeData = $"{Name}-{Department} departmanı-{Country}";
            return employeeData;
        }
    }

    public partial class Employee
    {
        public DateTime BirthDate { get; set; } = DateTime.Now.AddYears(-35);

        public Gender Gender { get; set; }
        public int Id { get; set; }

    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
