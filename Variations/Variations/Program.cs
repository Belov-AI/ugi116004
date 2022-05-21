using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    class Program
    {
        delegate Dog DogHandler(Dog dog);

        static void Main()
        {
            DogHandler handler;

            var dog = new Dog("пудель", "Артемон", 3);
            Console.WriteLine(dog);

            handler = IncreaseAgeByOne;
            Console.WriteLine(handler(dog));

            handler = MakeHoundFromMammal;
            var hound = handler(dog);
            Console.WriteLine(hound);
            Console.WriteLine(hound.Breed);

            Console.ReadKey();
        }

        static Dog IncreaseAgeByOne(Dog dog)
        {
            dog.Age += 1;
            return dog;
        }

        static Hound MakeHoundFromMammal(Mammal mammal)
        {
            var hound = new Hound("без имени", mammal.Age, 0);

            if (mammal is Dog dog)
                hound.Name = dog.Name;

            return hound;
        }

    }
}
