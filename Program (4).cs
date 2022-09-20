namespace UserProject
{
    class User
    {
        public string Login, Name, Surname;
        public int Age;
        public readonly string Date;

        public User(string login, string name, string surname,
                    int age, string date)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            Date = date;
        }
    }

    class Program
    {
        static void Main()
        {
            User user = new User("login", "testuser", "Shevchuk", 33, "2022-09-01");
            Console.WriteLine("Login: " + user.Login);
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Surname: " + user.Surname);
            Console.WriteLine("Age: " + user.Age);
            Console.WriteLine("Date: " + user.Date);
        }
    }
}
