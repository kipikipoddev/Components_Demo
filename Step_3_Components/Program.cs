namespace Step_3_Components;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = new IComponents[]
        {
            new Cat(),
            new Dog(),
            new Fish(),
            new Robot(),
            new Robot_Dog(),
            new Fish_Robot()
        };

        foreach (var entity in entities)
            Do_Actions(entity);
    }

    private static void Do_Actions(IComponents components)
    {
        components.Walk_If_Can();
        components.Make_Sound_If_Can();
        components.Swim_If_Can();
    }
}