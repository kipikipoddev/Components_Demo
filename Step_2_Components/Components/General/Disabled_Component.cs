namespace Step_2_Components;

public class Disabled_Component : Component, IDisabled_Component
{
    public bool Is_Disabled { get; set; }

    public Disabled_Component(bool is_disabled)
    {
        Is_Disabled = is_disabled;
    }
}