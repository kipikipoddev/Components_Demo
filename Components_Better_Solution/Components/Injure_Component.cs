
namespace Components_Better_Solution;

public class Injure_Component
    : Component, IInjure_Component, IHandler<Injure_Command>, IHandler<Heal_Command>
{
    private readonly Actions[] actions;

    public bool Is_Injured { get; private set; }

    public Injure_Component(params Actions[] actions)
    {
        this.actions = actions;
    }

    public void Handle(Injure_Command cmd)
    {
        Is_Injured = true;
        foreach (var component in disables)
            Parent.Remove(component);
        Parent.Remove<IHandler<Injure_Command>>(this);
    }

    public void Handle(Heal_Command cmd)
    {
        Is_Injured = false;
        foreach (var component in disables)
            Parent.Add(component);
        Parent.Remove<IHandler<Heal_Command>>(this);
    }
}