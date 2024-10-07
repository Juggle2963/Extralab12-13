using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Ovning12;

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();
        Person personMethods = new Person();



        bool exit = true;
        bool show = true;
        while (exit)
        {


            if (show)
                Console.WriteLine("Welcome - press 1 to show the list 2 to add and 3 to delete. Or 4 to sort list, 5 to replace 6 to exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    personMethods.ShowList(persons);
                    show = false;
                    break;
                case 2:
                    personMethods.AddPerson(persons);
                    Console.Clear();
                    show = true;
                    break;
                case 3:
                    personMethods.DeletePerson(persons);
                    Console.Clear();
                    show = true;
                    break;
                case 4:
                    personMethods.SortList(persons);
                    Console.Clear();
                    show = true;
                    break;
                case 5:
                    personMethods.RePlace(persons);
                    show = true;
                    break;
                case 6:
                    exit = false;
                    break;
                default:
                    break;
            }

        }
    }





}
