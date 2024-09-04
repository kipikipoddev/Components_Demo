namespace Step_1_Objects;

public interface IRobot : IEntity
{
    bool Is_Charged { get; }
    bool Can_Charge();
    void Charge();
}