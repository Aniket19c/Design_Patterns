using System;


interface IPizza
{
    void Prepare();
}


class VegPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Veg Pizza is being prepared...");
    }
}

class ChickenPizza : IPizza
{
    public void Prepare()
    {
        Console.WriteLine("Chicken Pizza is being prepared...");
    }
}

class PizzaFactory
{
    public static IPizza CreatePizza(string type)
    {
        if (type.Equals("Veg", StringComparison.OrdinalIgnoreCase))
        {
            return new VegPizza();
        }
        else if (type.Equals("Chicken", StringComparison.OrdinalIgnoreCase))
        {
            return new ChickenPizza();
        }
        else
        {
            throw new ArgumentException("Invalid Pizza Type");
        }
    }
}

class Program
{
    static void Main()
    {
        IPizza pizza1 = PizzaFactory.CreatePizza("Veg");
        pizza1.Prepare();

        IPizza pizza2 = PizzaFactory.CreatePizza("Chicken");
        pizza2.Prepare();
        Console.ReadLine();
    }
}
