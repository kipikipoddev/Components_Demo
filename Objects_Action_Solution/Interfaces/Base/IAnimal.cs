namespace Objects_Solution;

public interface IAnimal : IEntity
{
    bool Is_Injured { get; set; }
    void Injure();
    void Heal();
}