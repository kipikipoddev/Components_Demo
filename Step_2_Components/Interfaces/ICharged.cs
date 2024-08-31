namespace Components_Demo;

public interface ICharged : IEntity
{
    bool Is_Charged { get; }
    bool Is_Max_Charged { get; }
    int Charges { get; }
    int Max_Charges { get; }
}