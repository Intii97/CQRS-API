using Domain.Models.Animal;

namespace Domain.Models
{
    public class Dog : AnimalModel
    {
        public override Guid Id { get; set; } = Guid.Empty;
        public override string Name { get; set; } = string.Empty;
        public override string TypeOfAnimal { get; set; } = string.Empty;
        public override string animalCanDo { get; set; } = string.Empty;
        public bool LikesToPlay { get; set; }
    }
}
