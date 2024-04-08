using Task08._04.Models;

namespace Task08._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("salam", "netersiz");
            Console.WriteLine( student.Name);
            Console.WriteLine(student.Surname);
            Console.WriteLine(student.Id);
            Console.WriteLine(student.CodeEmail);



        }
    }
}
