namespace Components_Demo;

public class Charga_Data
{
    public bool Is_Charged => Charges > 0;
    public bool Is_Max_Charged => Charges == Max_Charges;
    public int Charges { get; private set; }
    public int Max_Charges { get; }

    public Charga_Data(int max_charges)
    {
        Max_Charges = max_charges;
    }

    public void Reduce()
    {
        Charges--;
    }

    public void Charge()
    {
        Charges = Max_Charges;
    }
}