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
        components.Get_Or_Default<IWalk_Component>()?.Walk();
        components.Get_Or_Default<ISound_Component>()?.Make_Sound();
        components.Get_Or_Default<ISwim_Component>()?.Swim();
    }
}