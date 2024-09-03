
namespace Components_Basic_Solution;

public static class Components_Factory
{
    public static IComponents Create_Fish()
    {
        return new Components()
            .Add(new Name_Component("Fish"))
            .Add(new Injure_Component())
            .Add(new Injured_Swim_Component());
    }

    public static IComponents Create_Cat()
    {
        return new Components()
            .Add(new Name_Component("Cat"))
            .Add(new Injure_Component())
            .Add(new Injured_Meow_Component())
            .Add(new Injured_Walk_Component());
    }

    public static IComponents Create_Dog()
    {
        return new Components()
            .Add(new Name_Component("Dog"))
            .Add(new Injure_Component())
            .Add(new Injured_Bark_Component())
            .Add(new Injured_Walk_Component())
            .Add(new Injured_Swim_Component());
    }

    public static IComponents Create_Robot_Fish()
    {
        return new Components()
            .Add(new Name_Component("Robot_Fish"))
            .Add(new Charged_Component())
            .Add(new Charged_Swim_Component());
    }

    public static IComponents Create_Robot_Dog()
    {
        return new Components()
            .Add(new Name_Component("Robot_Dog"))
            .Add(new Charged_Component())
            .Add(new Charged_Swim_Component())
            .Add(new Charged_Walk_Component())
            .Add(new Charged_Bark_Component());
    }
}