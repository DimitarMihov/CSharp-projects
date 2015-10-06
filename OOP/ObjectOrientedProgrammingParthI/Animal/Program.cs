/*Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
 * Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
 * Kittens and tomcats are cats. All animals are described by age, name and sex.
 * Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
 * Create arrays of different kinds of animals and calculate the average age of each kind of animal
 * using a static method (you may use LINQ).
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog(5, "Sharo", "male");
            dog.ToString();

            Frog frog = new Frog(1, "Kiki", "female");
            frog.ToString();

            Cat cat = new Cat(2, "Kate", "female");
            cat.ToString();

            Kitten kitten = new Kitten(1, "Kiti");
            kitten.ToString();

            Tomcat tomkat = new Tomcat(2, "Oliver");
            tomkat.ToString();

            //For average age calculation other parameters except age are not needed
            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog(4);
            dogs[1] = new Dog(8);
            dogs[2] = new Dog(12);

            Frog[] frogs = new Frog[3];
            frogs[0] = new Frog(1);
            frogs[1] = new Frog(3);
            frogs[2] = new Frog(5);

            Cat[] cats = new Cat[3];
            cats[0] = new Cat(2);
            cats[1] = new Cat(3);
            cats[2] = new Cat(6);

            Animal.Average(dogs);
            Animal.Average(frogs);
            Animal.Average(cats);
        }
    }
}
