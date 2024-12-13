using GitExample.Model;

namespace GitExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ali", 24);

            Console.WriteLine($"Hello, my name is {p.Name} and i am {p.Age} years old!");
        }
    }
}
