using Objects_Solution;

namespace Step_1_OOP_Tests;

public static class Creator
{
    private static Test_Printer printer = new Test_Printer();
    public static Test_Printer Printer => printer;

    public static T Create<T>()
        where T : class, IEntity
    {
        if (typeof(T) == typeof(IAnimal) || typeof(T) == typeof(IFIsh))
            return new Fish(printer) as T;

        if (typeof(T) == typeof(ICat))
            return new Cat(printer) as T;

        if (typeof(T) == typeof(IDog))
            return new Dog(printer) as T;

        if (typeof(T) == typeof(IRobot) || typeof(T) == typeof(IRobot_Dog))
            return new Robot_Dog(printer) as T;

        if (typeof(T) == typeof(IRobot_Fish))
            return new Robot_Fish(printer) as T;

        return null;
    }
}
