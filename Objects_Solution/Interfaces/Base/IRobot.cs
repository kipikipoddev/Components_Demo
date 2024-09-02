namespace Objects_Solution;

public interface IRobot : IEntity
{
    bool Is_Charged { get; }
    bool Can_Charge();
    void Charge();
}