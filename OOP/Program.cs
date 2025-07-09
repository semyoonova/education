namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student Boris = new Student("Борис", 23)
            //{
            //    TypeOfStudy = TypeOfStudy.Courses
            //};
            //Boris.Study();
            //Console.WriteLine(Boris.Name);
            //Console.WriteLine(Boris.Age);
            //Console.WriteLine(Boris.StudyLvl);
            //Student Vasya = new Student("Вася", 23)
            //{
            //    TypeOfStudy = TypeOfStudy.Shcool
            //};

            BankUser Victor = new BankUser()
            {Email = "qwery@mail.com" };

            Victor.FullName = "Иванов Виктор Иванович";
            Victor.UpdatePhone("89076431234");
            Console.WriteLine(Victor.PhoneNumber);
            Victor.Deposit(12345m);
            Console.WriteLine(Victor.Balance);
        }
    }
}
