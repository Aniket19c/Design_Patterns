using System;

interface IButton
{
    void Render();
}

interface ICheckBox
{
    void Check();
}

class WindowsButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Windows Button");
}


class WindowsCheckBox : ICheckBox
{
    public void Check() => Console.WriteLine("Checking Windows CheckBox");
}


class MacButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Mac Button");
}

class MacCheckBox : ICheckBox
{
    public void Check() => Console.WriteLine("Checking Mac CheckBox");
}

interface IUIFactory
{
    IButton CreateButton();
    ICheckBox CreateCheckBox();
}

class WindowsFactory : IUIFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ICheckBox CreateCheckBox() => new WindowsCheckBox();
}

class MacFactory : IUIFactory
{
    public IButton CreateButton() => new MacButton();
    public ICheckBox CreateCheckBox() => new MacCheckBox();
}

class Application
{
    private readonly IButton _button;
    private readonly ICheckBox _checkBox;

    public Application(IUIFactory factory)
    {
        _button = factory.CreateButton();
        _checkBox = factory.CreateCheckBox();
    }

    public void RenderUI()
    {
        _button.Render();
        _checkBox.Check();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter UI Type (Windows/Mac): ");
        string uiType = Console.ReadLine();

        IUIFactory factory;

        if (uiType.Equals("Windows", StringComparison.OrdinalIgnoreCase))
            factory = new WindowsFactory();
        else if (uiType.Equals("Mac", StringComparison.OrdinalIgnoreCase))
            factory = new MacFactory();
        else
            throw new ArgumentException("Invalid UI Type");

       
        Application app = new Application(factory);
        app.RenderUI();
        Console.ReadLine(); 
    }
}
