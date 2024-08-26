namespace Step_3_Components;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = new IComponents[]
        {
            new Cat(),
            new Dog(),
            new Robot(),
            new Robot_Dog()
        };

        foreach (var entity in entities)
            Walk_And_Sound(entity);
    }

    private static void Walk_And_Sound(IComponents components)
    {
        components.Get<IWalk_Component>().Walk();
        components.Get<ISound_Component>().Make_Sound();
    }
}