using Access_Modifires_Encupsulation.Models;

namespace Access_Modifires_Encupsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "TEST";
            Console.WriteLine(student);

        }
    }
}

