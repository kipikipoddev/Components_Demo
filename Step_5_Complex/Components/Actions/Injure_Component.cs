
namespace Step_5_Complex;

public class Injure_Component
    : Action_Component<Injure_Command>, IInjure_Component, IHandler<Heal_Command>, IValidator<Action_Command>
{
    public int Hp { get; private set; }
    public int Max_Hp { get; private set; }
    public bool Is_Alive => Hp > 0;
    public bool Is_Injured => Hp < Max_Hp;

    public Injure_Component(int max_hp)
    {
        Hp = max_hp;
        Max_Hp = max_hp;
    }

    public override void Handle(Injure_Command cmd)
    {
        base.Handle(cmd);
        Hp--;
    }

    public void Handle(Heal_Command cmd)
    {
        base.Handle(cmd);
        Hp = Max_Hp;
    }

    public bool Is_Valid(Action_Command cmd)
    {
        if (!Is_Alive)
            return false;
        if (cmd is Heal_Command)
            return Is_Injured;
        else
            return true;
    }
}