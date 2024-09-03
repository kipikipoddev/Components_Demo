
using System.ComponentModel;

namespace Components_Better_Solution;

public static class Components_Factory
{
    public static IComponents Create_Cat()
    {
        var comp = new IComponent[] { new Walk_Component(), new Meow_Component() };

        return new Components()
            .Add(new Name_Component("Cat"))
            .Add(new Injure_Component(comp))
            .Add(comp);
    }

    public static IComponents Create_Dog()
    {
        var comp = new IComponent[] { new Walk_Component(), new Swim_Component(), new Bark_Component() };

        return new Components()
            .Add(new Name_Component("Dog"))
            .Add(new Injure_Component(comp))
            .Add(comp);
    }
}