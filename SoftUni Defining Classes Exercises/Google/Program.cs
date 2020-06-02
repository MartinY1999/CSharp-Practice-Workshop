using System;
using System.Collections.Generic;
using System.Linq;

namespace Google
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") break;
                else
                {
                    string[] parts = input.Split(' ');
                    switch (parts[1])
                    {
                        case "company":
                            if (people.Any(x => x.Name == parts[0]) == false)
                            {
                                Person current = new Person(parts[0], new Company(parts[2], parts[3], parts[4]),
                                    new List<Pokemon>(), new List<Parent>(), new List<Children>(),  new Car());
                                people.Add(current);
                            }
                            else
                            {
                                int index = people.FindIndex(x => x.Name == parts[0]);
                                people[index].Company.Name = parts[2];
                                people[index].Company.Department = parts[3];
                                people[index].Company.Salary = parts[4];
                            }
                            break;
                        case "pokemon":
                            if (people.Any(x => x.Name == parts[0]) == false)
                            {
                                Person current = new Person(parts[0], new Company(), new List<Pokemon>(),
                                    new List<Parent>(), new List<Children>(),  new Car());
                                Pokemon currentPokemon = new Pokemon(parts[2], parts[3]);
                                current.Pokemons.Add(currentPokemon);
                                people.Add(current);
                            }
                            else
                            {
                                int index = people.FindIndex(x => x.Name == parts[0]);
                                people[index].Pokemons.Add(new Pokemon(parts[2], parts[3]));
                            }
                            break;
                        case "parents":
                            if (people.Any(x => x.Name == parts[0]) == false)
                            {
                                Person current = new Person(parts[0], new Company(), new List<Pokemon>(),
                                    new List<Parent>(), new List<Children>(),  new Car());
                                Parent currentParent = new Parent(parts[2], parts[3]);
                                current.Parents.Add(currentParent);
                                people.Add(current);
                            }
                            else
                            {
                                int index = people.FindIndex(x => x.Name == parts[0]);
                                people[index].Parents.Add(new Parent(parts[2], parts[3]));
                            }
                            break;
                        case "children":
                            if (people.Any(x => x.Name == parts[0]) == false)
                            {
                                Person current = new Person(parts[0], new Company(), new List<Pokemon>(),
                                    new List<Parent>(), new List<Children>(), new Car());
                                Children currentChildren = new Children(parts[2], parts[3]);
                                current.Childrens.Add(currentChildren);
                                people.Add(current);
                            }
                            else
                            {
                                int index = people.FindIndex(x => x.Name == parts[0]);
                                people[index].Childrens.Add(new Children(parts[2], parts[3]));
                            }
                            break;
                        case "car":
                            if (people.Any(x => x.Name == parts[0]) == false)
                            {
                                Person current = new Person(parts[0], new Company(),
                                    new List<Pokemon>(), new List<Parent>(), new List<Children>(),
                                    new Car(parts[2], double.Parse(parts[3])));
                                people.Add(current);
                            }
                            else
                            {
                                int index = people.FindIndex(x => x.Name == parts[0]);
                                people[index].Car.Model = parts[2];
                                people[index].Car.Speed = double.Parse(parts[3]);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            string name = Console.ReadLine();
            int i = people.FindIndex(x => x.Name == name);
            Person.PrintPerson(people[i]);
            Console.ReadLine();
        }
    }
}
