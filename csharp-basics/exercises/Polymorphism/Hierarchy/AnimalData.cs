namespace Hierarchy;

public static class AnimalData
{
    public static string CreateAnimal(string animal, string food)
    {
        var animalData = animal.Split(" ");
        var foodData = food.Split(" ");
        var animals = new List<Animal>();

        switch (animalData[0])
        {
            case "Mouse":
                animals.Add(new Mouse(animalData[0], animalData[1], double.Parse(animalData[2]), animalData[3]));
                break;
            case "Zebra":
                animals.Add(new Zebra(animalData[0], animalData[1], double.Parse(animalData[2]), animalData[3]));
                break;
            case "Tiger":
                animals.Add(new Tiger(animalData[0], animalData[1], double.Parse(animalData[2]), animalData[3]));
                break;
            case "Cat":
                animals.Add(new Cat(animalData[0], animalData[1], double.Parse(animalData[2]), animalData[3], animalData[4]));
                break;
        }
        
        var currentAnimal = animals[^1];

        switch (foodData[0])
        {
            case "Meat":
                currentAnimal.Eat(new Meat(int.Parse(foodData[1])));
                break;
            case "Vegetable":
                currentAnimal.Eat(new Vegetable(int.Parse(foodData[1])));
                break;
        }

        return currentAnimal.ToString();
    }
}