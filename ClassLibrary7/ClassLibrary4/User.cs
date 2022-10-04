namespace  ClassLibarary4
{
    class User
    {
        private string login = "SavchukLera";
        private string name = "Lera";
        private string surname = "Savchuk";
        private int age = 18;
        private const string date = "04.10.2022";

        public void Vivod()
        {
            Console.WriteLine($"Login: {login};\nName: {name};\nSurname: {surname};\nAge: {age};\nDate: {date};");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User solution\n");

            User ezUser = new User();

            ezUser.Vivod();

            Console.ReadKey();
        }
    }
}