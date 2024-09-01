namespace Components_Demo;

public interface IRobot : IEntity
{
    bool Is_Charged { get; }
    void Charge();
}