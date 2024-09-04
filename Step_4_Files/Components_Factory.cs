namespace Step_4_Files;

public static class Components_Factory
{
    public static IComponents Create_Fish()
    {
        return new Components()
            .Add(new Name_Component("Fish"))
            .Add(new Injure_Component())
            .Add(new Swim_Component());
    }

    public static IComponents Create_Cat()
    {
        return new Components()
            .Add(new Name_Component("Cat"))
            .Add(new Injure_Component())
            .Add(new Meow_Component())
            .Add(new Walk_Component());
    }

    public static IComponents Create_Dog()
    {
        return new Components()
            .Add(new Name_Component("Dog"))
            .Add(new Injure_Component())
            .Add(new Walk_Component())
            .Add(new Swim_Component())
            .Add(new Bark_Component());
    }

    public static IComponents Create_Robot_Fish()
    {
        return new Components()
            .Add(new Name_Component("Robot_Fish"))
            .Add(new Charge_Component())
            .Add(new Swim_Component());
    }

    public static IComponents Create_Robot_Dog()
    {
        return new Components()
            .Add(new Name_Component("Robot_Dog"))
            .Add(new Charge_Component())
            .Add(new Walk_Component())
            .Add(new Bark_Component())
            .Add(new Swim_Component());
    }
}