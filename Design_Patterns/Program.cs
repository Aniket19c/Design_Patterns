using System;

class Computer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }
    public string GraphicsCard { get; set; }

    public void ShowSpecifications()
    {
        Console.WriteLine($"Computer Specifications: \n CPU: {CPU} \n RAM: {RAM} \n Storage: {Storage} \n Graphics Card: {GraphicsCard}");
    }
}

interface IComputerBuilder
{
    void BuildCPU();
    void BuildRAM();
    void BuildStorage();
    void BuildGraphicsCard();
    Computer GetComputer();
}

class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU() => _computer.CPU = "Intel i9";
    public void BuildRAM() => _computer.RAM = "32GB DDR5";
    public void BuildStorage() => _computer.Storage = "1TB SSD";
    public void BuildGraphicsCard() => _computer.GraphicsCard = "NVIDIA RTX 4090";

    public Computer GetComputer() => _computer;
}

class OfficeComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU() => _computer.CPU = "Intel i5";
    public void BuildRAM() => _computer.RAM = "16GB DDR4";
    public void BuildStorage() => _computer.Storage = "512GB SSD";
    public void BuildGraphicsCard() => _computer.GraphicsCard = "Integrated Graphics";

    public Computer GetComputer() => _computer;
}

class ComputerDirector
{
    public void Construct(IComputerBuilder builder)
    {
        builder.BuildCPU();
        builder.BuildRAM();
        builder.BuildStorage();
        builder.BuildGraphicsCard();
    }
}

class Program
{
    static void Main()
    {
        ComputerDirector director = new ComputerDirector();

        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        director.Construct(gamingBuilder);
        Computer gamingComputer = gamingBuilder.GetComputer();
        gamingComputer.ShowSpecifications();

        Console.WriteLine("\n------------------------\n");

        IComputerBuilder officeBuilder = new OfficeComputerBuilder();
        director.Construct(officeBuilder);
        Computer officeComputer = officeBuilder.GetComputer();
        officeComputer.ShowSpecifications();
        Console.ReadKey();
    }
}
