
using ZooBase.Models.Animals.Args;
using ZooBase.Models.Animals.Interfaces;

namespace ZooBase.Models.Animals.Entities;

public class UnknownAnimal : IAnimal {
    public event EventHandler<AnimalEventArgs>? AnimalCreated;
    public event EventHandler<AnimalEventArgs>? AnimalModified;

    public int Id { get; set; }
    public string Species { get; set; }
    public string Name { get; set; }
    public DateOnly DateCreated { get; set; }
    public bool IsActive { get; set; }
    public UnknownAnimal() { }
    protected UnknownAnimal(int id, string species, string name) {
        Id = id;
        Species = species;
        Name = name;
        DateCreated = DateOnly.FromDateTime(DateTime.Now);
        OnAnimalCreated();
    }
    public static UnknownAnimal Create(int id, string species, string name) {
        return new UnknownAnimal(id, species, name);
    }
    public void Move() {
        OnAnimalModified("moves in an unknown way");
    }

    protected virtual void OnAnimalCreated() {
        AnimalCreated?.Invoke(this, new AnimalEventArgs(this, $"{Species} '{Name}' created."));
    }

    protected virtual void OnAnimalModified(string message) {
        AnimalModified?.Invoke(this, new AnimalEventArgs(this, $"{Species} '{Name}' modified: {message}"));
    }
}
