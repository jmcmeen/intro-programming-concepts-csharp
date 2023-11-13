using DataModels;

namespace _13_1_DataModelling
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();

            Console.WriteLine("Rolling a d6 10 times");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dice.NextRoll());
            }

            dice = new Dice(20);

            Console.WriteLine("Rolling a d20 10 times");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dice.NextRoll());
            }

            //Create a Person object using default constructor
            Person personA = new Person();

            //Create a Person object using parameterized constructor
            Person personB = new Person("Snerfle", "Burf", 20);

            //The Person object gives public access to its fields through
            //automatic properties so we can get (access) and set (mutate) them directly
            Console.WriteLine($"a = {personA.GivenName} {personA.FamilyName} {personA.Age}");
            Console.WriteLine($"b = {personB.GivenName} {personB.FamilyName} {personB.Age}");

            //Since the object reference a was set up with default values,
            //we might want to change them later
            personA.GivenName = "Lucy";
            personA.FamilyName = "Goosey";
            personA.Age = 42;

            //Print the Person object again, noting the changes to the object
            Console.WriteLine($"a = {personA.GivenName} {personA.FamilyName} {personA.Age}");


            //We must use the parameterized constructor defined
            Car car = new Car("red", "ford", "taurus", 1299.99);

            //Car has private fields, so we must use the public properties defined to get (access) or set (mutate) values
            //a.color will not work because color is private, but a.Color is public
            Console.WriteLine($"{car.Color} {car.Make} {car.Model} ${car.Price}");

            //The public properties for Car define both get (access) and set (mutate) properties
            //Here was can use the properties to set the values in a Car
            car.Color = "black";
            car.Price = 1199.99;

            //Notice the color and price of the Car changed
            Console.WriteLine($"{car.Color} {car.Make} {car.Model} ${car.Price}");

            //Create a new Television object using default constructor
            Television tv = new Television();

            Console.WriteLine("Setting the channel to 42\n");

            tv.SetChannel(42);

            Console.WriteLine(tv + "\n");

            Console.WriteLine("Setting the channel to 1000\n");

            //The SetChannel method and Channel property are both designed to prevent the
            //programmer from setting an invalid channel value (here 1000 > MAX_CHANNEL in Television)
            tv.Channel = 1000;

            Console.WriteLine(tv + "\n");

            //Television also has some methods for incrementing and decrementing channels
            //Here we will demo them in a loop to call each method a given number of times
            Console.WriteLine("Calling ChannelUp() twelve times");
            for (int i = 0; i < 12; i++)
            {
                tv.ChannelUp();
                Console.WriteLine(tv);
            }

            Console.WriteLine("\nCalling ChannelDown() five times");
            for (int i = 0; i < 5; i++)
            {
                tv.ChannelDown();
                Console.WriteLine(tv.ToString());
            }

            //Create a Book using default constructor
            Book book = new Book();

            //Notice Books default constructor just sets some default values for a Book
            Console.WriteLine($"{book.Title} {book.Author} {book.Pages} {book.ISBN}");

            //We would use the default constructor if we wanted to create memory for a Book and then alter it later
            //Since we have some public properties that allow us to get (access) and set (mutate) values in a Book,
            //we can make some changes and then use them 
            book.Title = "A Super Cool Book";
            book.Author = "McMeen, John";
            book.Pages = 5398;
            book.ISBN = "9385938201";

            //Notice the Book objects' values changed
            Console.WriteLine($"{book.Title} {book.Author} {book.Pages} {book.ISBN}\n");

            //If we already have some values for a Book, such as in some variables entered by a user,
            //We can use those with a paramterized constructor to set up the memory and values in that memory
            //when the object is created
            string someTitle = "Another Super Awesome Book";
            string someAuthor = "McMeen, John";
            ushort somePages = 2349;
            string someISBN = "937293004";

            //Create Book using paramterized constructor
            Book book2 = new Book(someTitle, someAuthor, somePages, someISBN);

            //Book also has a ToString method that bundles up all the values in a Book, and anything else we want in
            //a string representation of a Book, and returns a string
            Console.WriteLine(personB.ToString());


            Console.WriteLine(personB);

        }
    }
}