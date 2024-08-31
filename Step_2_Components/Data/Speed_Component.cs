namespace Components_Demo;

public class Speed_Component(Speed speed) : Component
{
    public Speed Speed { get; } = speed;
}


public static class Speed_Component_Ext
{
    public static Speed Speed(this IComponents components)
    {
        return components.Get<Speed_Component>().Speed;
    }
}