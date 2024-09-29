
namespace Step_2_Components;

public static class Components_Factory
{
    public static IComponents Create_Fish()
    {
        return new Components()
            .Add(new Name_Component("Fish"))
            .Add(new Disabled_Component(false))
            .Add(new Injure_Component())
            .Add(new Swim_Component());
    }

    public static IComponents Create_Cat()
    {
        return new Components()
            .Add(new Name_Component("Cat"))
            .Add(new Disabled_Component(false))
            .Add(new Injure_Component())
            .Add(new Meow_Component())
            .Add(new Walk_Component());
    }

    public static IComponents Create_Dog()
    {
        return new Components()
            .Add(new Name_Component("Dog"))
            .Add(new Disabled_Component(false))
            .Add(new Injure_Component())
            .Add(new Bark_Component())
            .Add(new Walk_Component())
            .Add(new Swim_Component());
    }

    public static IComponents Create_Robot_Fish()
    {
        return new Components()
            .Add(new Name_Component("Robot_Fish"))
            .Add(new Disabled_Component(true))
            .Add(new Charged_Component())
            .Add(new Swim_Component());
    }

    public static IComponents Create_Robot_Dog()
    {
        return new Components()
            .Add(new Name_Component("Robot_Dog"))
            .Add(new Disabled_Component(true))
            .Add(new Charged_Component())
            .Add(new Walk_Component())
            .Add(new Bark_Component());
    }
}