namespace Step_2_OOP;

public class Program
{
    private static IAction_Printer printer;

    private static void Main(string[] args)
    {
        printer = new Console_Printer();
        var entities = new IEntity[]
        {
            new Cat(printer,Speed.Fast),
            new Dog(printer,Speed.Normal),
            new Fish(printer,Speed.Fast),
            new Robot(printer,Speed.Slow),
            new Robot_Dog(printer,Speed.Normal)
        };
    }

}