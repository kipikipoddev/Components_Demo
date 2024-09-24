namespace Step_2_Components;

public class Disabled_Model : IDisabled_Model
{
    public bool Is_Disabled { get; set; }

    public Disabled_Model(bool is_disabled)
    {
        Is_Disabled = is_disabled;
    }
}