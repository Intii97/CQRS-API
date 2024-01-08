using Domain.Models;

namespace Infrastructure.Database
{
    public class MockDatabase
    {
        public List<Dog> Dogs
        {
            get { return allDogs; }
            set { allDogs = value; }
        }

        private static List<Dog> allDogs = new()
        {
            new Dog { Id = Guid.NewGuid(), Name = "Björn", TypeOfAnimal = "Dog", animalCanDo = "Can bark", LikesToPlay = true},
            new Dog { Id = Guid.NewGuid(), Name = "Patrik", TypeOfAnimal = "Dog", animalCanDo = "Can bark", LikesToPlay = true},
            new Dog {Id = Guid.NewGuid(), Name = "Alfred", TypeOfAnimal = "Dog", animalCanDo = "Can bark", LikesToPlay = true},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345678"), Name = "TestDogForUnitTests", TypeOfAnimal = "Dog", animalCanDo = "Can bark", LikesToPlay = true},
            new Dog { Id = new Guid("12345678-1234-5678-1234-567812345670"), Name = "TestDogForUnitTests", TypeOfAnimal = "Dog", animalCanDo = "Can bark", LikesToPlay = true}
        };

        public object Clone()
        {
            MockDatabase clone = new MockDatabase
            {
                Dogs = new List<Dog>(Dogs)
            };

            return clone;
        }
    }
}
