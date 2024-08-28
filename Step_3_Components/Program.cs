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
        if (components.Has<IWalk_Component>())
            components.Get<IWalk_Component>().Walk();

        if (components.Has<ISound_Component>())
            components.Get<ISound_Component>().Make_Sound();

        if (components.Has<ISwim_Component>())
            components.Get<ISwim_Component>().Swim();
    }
}