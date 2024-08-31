namespace Step_2_OOP;

public interface IRobot : IWalker
{
    bool Is_Charged { get; }
    int Charges { get; }
    int Max_Charges { get; }
    void Charge(int charges);
}