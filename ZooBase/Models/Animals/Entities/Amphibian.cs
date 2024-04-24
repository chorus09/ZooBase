
using System.ComponentModel.DataAnnotations;
using ZooBase.Models.Animals.Args;
using ZooBase.Models.Animals.Interfaces;

namespace ZooBase.Models.Animals.Entities;
public class Amphibian : IAnimal {

    public int Id { get; set; }
    public string Species { get; set; }
    public string Name { get; set; }
    public DateOnly DateCreated { get; set; }
    public bool IsActive { get; set; }

    public event EventHandler<AnimalEventArgs>? AnimalCreated;
    public event EventHandler<AnimalEventArgs>? AnimalModified;
    public Amphibian() { }
    protected Amphibian(int id, string species, string name) {
        Id = id;
        Species = species;
        Name = name;
        DateCreated = DateOnly.FromDateTime(DateTime.Now);
        IsActive = true;
    }
    public static Amphibian Create(int id, string species, string name) {
        return new Amphibian(id, species, name);
    }
    public void Move() {
        OnAnimalModified("swimming or hopping");
    }

    protected virtual void OnAnimalCreated() {
        AnimalCreated?.Invoke(this, new AnimalEventArgs(this, $"{Species} '{Name}' created."));
    }

    protected virtual void OnAnimalModified(string message) {
        AnimalModified?.Invoke(this, new AnimalEventArgs(this, $"{Species} '{Name}' modified: {message}"));
    }
}