using ZooBase.Models.Animals.Args;

namespace ZooBase.Models.Animals.Interfaces;
public interface IAnimal
{
    string Species { get; }
    string Name { get; }
    DateOnly DateCreated { get; }
    bool IsActive { get; }
    void Move();

    event EventHandler<AnimalEventArgs> AnimalCreated;
    event EventHandler<AnimalEventArgs> AnimalModified;
}
