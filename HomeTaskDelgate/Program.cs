namespace HomeTaskDelgate
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> persons = new List<Person>
        {
            new Person { Name = "Rauf", Surname = "Memmedov", Address = "Bakı", Salary = 1200 },
            new Person { Name = "Nergiz", Surname = "Eliyeva", Address = "Gence", Salary = 9000 },
            new Person { Name = "Vusal", Surname = "Quliyev", Address = "Sumqayıt", Salary = 1500 },
            new Person { Name = "Ayşe", Surname = "Hüseynova", Address = "Lenkeran", Salary = 800 }
        };

         
            List<Person> filteredPersons = FilterPersons(persons, p => p.Salary > 1000);

         
            foreach (var person in filteredPersons)
            {
                Console.WriteLine($"Ad: {person.Name}, Soyad: {person.Surname}, Ünvan: {person.Address}");
            }
        }

        static List<Person> FilterPersons(List<Person> persons, Predicate<Person> predicate)
        {
            List<Person> filteredPersons = new List<Person>();

            foreach (var person in persons)
            {
                if (predicate(person))
                {
                    filteredPersons.Add(person);
                }
            }

            return filteredPersons;
        }
    }

}
