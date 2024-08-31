namespace Step_3_Components;

public class Robot_Swim_Component : Component, ISwim_Component
{
    private readonly ISwim_Component component;

    public Robot_Swim_Component(ISwim_Component component)
    {
        this.component = component;
    }

    public void Swim()
    {
        if (Parent.Has<Repiar_Component>())
            Parent.Get<Repiar_Component>().Repiar();

        if (Parent.Has<Recharge_Component>())
            Parent.Get<Recharge_Component>().Recharge();

        component.Swim();
    }
}