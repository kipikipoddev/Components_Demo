namespace Components_Demo;

public interface IRobot : IEntity
{
    bool Is_Charged { get; }
    int Charges { get; }
    int Max_Charges { get; }
    bool Can_Recharge { get; }
    void Recharge();
}