namespace Step_4_Files;

public class Disabled_Component : Component, IDisabled_Component, IHandler<Set_Disabled_Command>
{
    public bool Is_Disabled { get; protected set; }

    public Disabled_Component(bool is_disabled)
    {
        Is_Disabled = is_disabled;
        Mediator.Add_Handler(this);
    }

    public void Handle(Set_Disabled_Command cmd)
    {
        Is_Disabled = cmd.Value;
    }
}