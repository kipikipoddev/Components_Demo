namespace Step_4_Commands;

public class Proxy_Component<T> : Component
    where T : IComponent
{
    protected readonly T Component;

    public Proxy_Component(T component)
    {
        Component = component;
    }

    protected override void Parent_Set()
    {
        Component.Parent = Parent;
    }
}