namespace Step_2_OOP;

public class Robot : Entity
{
    private bool is_charged;

    public override void Make_Sound()
    {
        Recharge();
        Write("beeping");
    }

    public override void Walk()
    {
        Recharge();
        Write("walking like a robot");
    }

    protected void Recharge()
    {
        if (is_charged)
            return;
        Write("recharging");
        is_charged = true;
        Write("recharged");
    }
}