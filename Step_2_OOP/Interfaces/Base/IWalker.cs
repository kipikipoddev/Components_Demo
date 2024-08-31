namespace Step_2_OOP;

public interface IWalker : IEntity
{
    bool Can_Walk { get; }
    void Walk();
}