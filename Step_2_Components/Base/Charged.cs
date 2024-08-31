namespace Components_Demo;

public class Charged : Entity, ICharged
{
    public bool Is_Charged => Charges > 0;

    public bool Is_Max_Charged => Charges == Max_Charges;

    public int Charges { get; set; }

    public int Max_Charges { get; }

    public Charged(int max_charges, string? name = null)
        : base(name)
    {
        Max_Charges = max_charges;
    }
}