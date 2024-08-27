namespace Step_2_OOP;

public class Robot : Entity
{
    public override bool Can_Walk => true;
    public override bool Can_Make_Sound => true;

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
        Write("recharged");
    }
}