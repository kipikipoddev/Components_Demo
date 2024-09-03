
namespace Components_Better_Solution;

public static class Components_Factory
{
    public static IComponents Create_Cat()
    {
        return new Components()
            .Add(new Name_Component("Cat"))
            .Add(new Meow_Component());
    }

    public static IComponents Create_Dog()
    {
        return new Components()
            .Add(new Name_Component("Dog"))
            .Add(new Bark_Component());
    }
}