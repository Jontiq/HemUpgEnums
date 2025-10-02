using System.Drawing;

namespace HemUpgEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Adam", "Larsson", 34);

            string fullNamePerson1 = person1.GetFullName();
            Console.WriteLine(fullNamePerson1);

            Book book1 = new Book("Mio min mio", "Astrid Lindgren", 144);
            string book1Info = book1.GetBookInfo();
            Console.WriteLine(book1Info);

            Rectangle rectangle1 = new Rectangle(100, 500);

            double rectangle1Area = rectangle1.Area;
            Console.WriteLine($"Area of rectangle: {rectangle1Area}m2");

            Task task = new Task(Task.Colors.red, Task.Priorities.high);
            task.GetTaskInfo();
        }
    }
}
