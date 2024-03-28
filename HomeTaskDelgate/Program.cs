namespace HomeTaskDelgate
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //    List<Person> persons = new List<Person>
            //{
            //    new Person { Name = "Rauf", Surname = "Memmedov", Address = "Bakı", Salary = 1200 },
            //    new Person { Name = "Nergiz", Surname = "Eliyeva", Address = "Gence", Salary = 9000 },
            //    new Person { Name = "Vusal", Surname = "Quliyev", Address = "Sumqayıt", Salary = 1500 },
            //    new Person { Name = "Ayşe", Surname = "Hüseynova", Address = "Lenkeran", Salary = 800 }
            //};


            //    List<Person> filteredPersons = FilterPersons(persons, p => p.Salary > 1000);


            //    foreach (var person in filteredPersons)
            //    {
            //        Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Ünvan: {person.Address}");
            //    }

            //    static List<Person> FilterPersons(List<Person> persons, Predicate<Person> predicate)
            //    {
            //        List<Person> filteredPersons = new List<Person>();

            //        foreach (var person in persons)
            //        {
            //            if (predicate(person))
            //            {
            //                filteredPersons.Add(person);
            //            }
            //        }

            //        return filteredPersons;
            //    }

            #endregion

            #region Task2


            #endregion

            #region Task3

            List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Ali", Age = 25, Salary = 2500 },
            new Employee { Name = "Nigar", Age = 30, Salary = 3000 },
            new Employee { Name = "Vasif", Age = 22, Salary = 2000 },
            new Employee { Name = "Ayten", Age = 35, Salary = 3500 },
            new Employee { Name = "Elvin", Age = 40, Salary = 4000 }
        };

            double averageSalary = EmployeeHelper.CalculateAverageSalary(employees, 20, 40);
            Console.WriteLine($"20-40 yaş arasındaki işçilerin maaşlarının ortalaması: {averageSalary}");

            #endregion


        }


    }

}
