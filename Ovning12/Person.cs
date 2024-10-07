using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning12;
public class Person
{
    public string Name;
    public int PhoneNumber;
    public string Email;

    public Person(string name, int phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    public Person() : this(" ", 0, "@")
    {
        
    }


    public void ShowList(List<Person> names)
    {
        Console.WriteLine("---------------------------------");

        //names.ForEach(x => Console.WriteLine(x));
        foreach (Person person in names)
        {
            Console.WriteLine($"{person.Name} - " + person.PhoneNumber + $" - {person.Email}");
        }

        Console.WriteLine("---------------------------------");
    }

    public void AddPerson(List<Person> persons)
    {
        Console.WriteLine("Enter name");
        string name = Console.ReadLine();

        Console.WriteLine("age");
        int phone = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter email");
        string email = Console.ReadLine();

        persons.Add(new Person(name, phone, email));

    }

    public void DeletePerson(List<Person> persons)
    {
        Console.WriteLine("Enter name of people to remove");
        string? name = Console.ReadLine();

        Person personRemove = null;

        foreach (var item in persons)
        {
            if(item.Name == name)
                personRemove = item;
        }

        if (personRemove != null)
        {
            persons.Remove(personRemove);
            Console.WriteLine($"[{name}] is removed");
        }
        else
            Console.WriteLine($"Couldnt find [{name}] in list");
    }

    public void SortList(List<Person> persons)
    {
        List<Person> list = persons.OrderBy(p => p.Name).ToList();
        persons.Clear();
        persons.AddRange(list);
    }

    public void RePlace(List<Person> persons)
    {
        Console.WriteLine("Enter the name you want to edit");

        persons.ForEach(x => Console.WriteLine($"{x.Name} - " + x.PhoneNumber + $" - {x.Email}"));

        string edit = Console.ReadLine();

        int ind = 100;

        ind = persons.FindIndex(p=>p.Name.Equals(edit));

        if (ind != 100)
        {
            bool end = true;
            while (end)
            {
            Console.WriteLine("Press to edit -- [1] Name -- [2] Phonenumber -- [3] Email -- [4] exit menu");
               
                switch (int.Parse(char.ToString(Console.ReadKey().KeyChar)))
                {
                    case 1:
                        Console.WriteLine("Enter new name: ");
                        persons[ind].Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter new name: ");
                        persons[ind].PhoneNumber = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter new name: ");
                        persons[ind].Email = Console.ReadLine();
                        break;
                    case 4:
                        end = false;
                        break;
                    default:
                        break;
                }
            }
            
        }
        else if (ind == 100)
        {
            Console.WriteLine("Name not in list - returning to menu");
            Thread.Sleep(3000);
        }

    }


}
