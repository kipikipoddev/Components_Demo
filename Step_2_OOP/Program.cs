namespace Step_2_OOP;

public class Program
{
    private static void Main(string[] args)
    {
        var entities = new IEntity[]
        {
            new Cat(),
            new Dog(),
            new Fish(),
            new Robot(),
            new Robot_Dog(),
            new Fish_Robot(),
        };

        foreach (var entity in entities)
            Do_Actions(entity);
    }

    private static void Do_Actions(IEntity entity)
    {
        if (entity.Can_Walk)
            entity.Walk(Speed.Slow);

        if (entity.Can_Make_Sound)
            entity.Make_Sound();

        if (entity.Can_Swim)
            entity.Swim();
    }
}