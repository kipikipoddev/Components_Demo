namespace Step_3_Components;

public interface IRecharge_Component : IComponent
{
    bool Is_Charged { get; }

    void Recharge_If_Need();

    void Recharge();
}