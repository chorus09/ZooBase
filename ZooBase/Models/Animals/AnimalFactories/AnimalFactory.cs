using ZooBase.Data;
using ZooBase.Models.Animals.Entities;
using ZooBase.Models.Animals.Interfaces;

namespace ZooBase.Models.Animals.AnimalFactories; 
public static class AnimalFactory {
    public static IAnimal CreateAnimal(AnimalType type, int id, string species, string name) {
        switch (type) {
            case AnimalType.Mammal:
                return Mammal.Create(id, species, name);
            case AnimalType.Bird:
                return Bird.Create(id, species, name);
            case AnimalType.Amphibian:
                return Amphibian.Create(id, species, name);
            default:
                return UnknownAnimal.Create(id, species, name);
        }
    }
}
public enum AnimalType {
    Mammal,
    Bird,
    Amphibian,
    Unknown
}
