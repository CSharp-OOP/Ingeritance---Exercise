using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input!="Beast!")
            {
                string type = input;
                string[] tokens = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string gender = tokens[2];

                    switch (type)
                    {
                        case "Cat":
                            Cat cat = new Cat(name,age,gender);
                            Console.WriteLine(cat);
                            break;
                        case "Dog":
                            Dog dog = new Dog(name,age,gender);
                            Console.WriteLine(dog);
                            break;
                        case "Frog":
                            Frog frog = new Frog(name,age,gender);
                            Console.WriteLine(frog);
                            break;
                        case "Tomcat":
                            TomCat tomCat = new TomCat(name,age);
                            Console.WriteLine(tomCat);
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(name,age);
                            Console.WriteLine(kitten);
                            break;
                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
