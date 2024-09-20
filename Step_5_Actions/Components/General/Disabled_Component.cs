namespace Step_5_Actions;

public class Disabled_Component : Component, IDisabled_Component, IHandler<Set_Disabled_Command>
{
    public bool Is_Disabled { get; protected set; }

    public Disabled_Component()
    {
        Mediator.Add_Handler(this);
    }

    public void Handle(Set_Disabled_Command cmd)
    {
        Is_Disabled = cmd.Value;
    }
}