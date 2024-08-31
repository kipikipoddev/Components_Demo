namespace Step_2_OOP;

public interface IRobot : IEntity
{
    bool Is_Charged  { get; }
    void Charge();
}