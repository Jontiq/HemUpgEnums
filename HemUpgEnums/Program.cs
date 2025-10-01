namespace HemUpgEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Adam", "Larsson", 34);

            string fullNamePerson1 = person1.GetFullName();
            Console.WriteLine(fullNamePerson1);
        }
    }
}
