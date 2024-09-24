
using Step_1_Objects;

namespace Step_2_Components;

public static class Model_Factory
{
    public static IFish_Model Create_Fish()
    {
        return new Components()
            .Add(new Name_Component("Fish"))
            .Add(new Disabled_Model(false))
            .Add(new Injure_Component())
            .Add(new Swim_Component());
    }

    public static IComponents Create_Cat()
    {
        return new Components()
            .Add(new Name_Component("Cat"))
            .Add(new Disabled_Model(false))
            .Add(new Injure_Component())
            .Add(new Meow_Component())
            .Add(new Walk_Component());
    }

    public static IComponents Create_Dog()
    {
        return new Components()
            .Add(new Name_Component("Dog"))
            .Add(new Disabled_Model(false))
            .Add(new Injure_Component())
            .Add(new Bark_Model())
            .Add(new Walk_Component())
            .Add(new Swim_Component());
    }

    public static IComponents Create_Robot_Fish()
    {
        return new Components()
            .Add(new Name_Component("Robot_Fish"))
            .Add(new Disabled_Model(true))
            .Add(new Charged_Component())
            .Add(new Swim_Component());
    }

    public static IComponents Create_Robot_Dog()
    {
        return new Components()
            .Add(new Name_Component("Robot_Dog"))
            .Add(new Disabled_Model(true))
            .Add(new Charged_Component())
            .Add(new Swim_Component())
            .Add(new Walk_Component())
            .Add(new Bark_Model());
    }
}