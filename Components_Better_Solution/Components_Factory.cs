namespace Components_Better_Solution;

public static class Components_Factory
{
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
}