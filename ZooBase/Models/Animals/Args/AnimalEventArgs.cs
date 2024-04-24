using ZooBase.Models.Animals.Interfaces;

namespace ZooBase.Models.Animals.Args;
public class AnimalEventArgs : EventArgs
{
    public IAnimal Animal { get; }
    public string Message { get; }

    public AnimalEventArgs(IAnimal animal, string message)
    {
        Animal = animal;
        Message = message;
    }
}

