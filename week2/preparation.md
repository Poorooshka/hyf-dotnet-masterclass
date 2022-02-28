# Week 2 - Preparation

Watch these videos:

- [Using objects and classes](https://docs.microsoft.com/en-us/shows/csharp-101/csharp-object-oriented-programming-objects-and-classes/)
- [Defining methods and members](https://docs.microsoft.com/en-us/shows/csharp-101/csharp-object-oriented-programming-methods-and-members/)

Try running the following code:

```csharp
// a single meal
Meal meal = new Meal();
meal.Name = "Pizza";
meal.Price = 100;

// list
List<Meal> meals = new List<Meal>();
meals.Add(new Meal
{
    Name = "Burrito",
    Price = 99
});

NicePrintMeal(meal);

foreach (var m in meals)
{
    NicePrintMeal(m);
    if (IsExpensive(meal))
    {
        Console.WriteLine("It's too expensive!");
    }
}


bool IsExpensive(Meal meal)
{
    return meal.Price > 99;
}

void NicePrintMeal(Meal meal)
{
    Console.WriteLine($"The meal {meal.Name} costs {meal.Price}");
}

class Meal
{
    public string Name { get; set; }
    public int Price { get; set; }
}
```
