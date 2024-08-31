using Components_Demo;

namespace Step_1_OOP_Tests;

public static class Creator
{
    private static Test_Printer printer = new Test_Printer();

    public static int Max_Charges = 2;
    public static Test_Printer Printer => printer;

    public static T Create<T>(Speed speed = Speed.Normal, int? charges = null)
        where T : class, IEntity
    {
        if (typeof(T) == typeof(ICat))
            return new Cat(printer, speed) as T;
        if (typeof(T) == typeof(IDog))
            return new Dog(printer, speed) as T;
        if (typeof(T) == typeof(IFIsh))
            return new Fish(printer, speed) as T;
        if (typeof(T) == typeof(IRobot_Dog))
            return new Robot_Dog(printer, charges ?? Max_Charges, speed) as T;
        if (typeof(T) == typeof(IRobot))
            return new Robot(printer, charges ?? Max_Charges, speed) as T;
        return null;
    }
}
