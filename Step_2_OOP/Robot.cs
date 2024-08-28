
namespace Step_2_OOP;

public class Robot : Entity
{
    private bool is_recharged;

    public Robot(Speed speed)
        : base(speed)
    {
        Can_Walk = true;
        Can_Make_Sound = true;
    }

    public override void Make_Sound()
    {
        Check_Status();
        Write_Action("beeping");
    }

    public override void Walk()
    {
        Check_Status();
        base.Walk();
    }

    public override void Injure()
    {
        base.Injure();
        Write_Action("broken");
    }

    protected void Check_Status()
    {
        if (!is_recharged)
            Recharge();
        if (Is_Injured)
            Repair();
    }

    protected void Repair()
    {
        Write_Action("repairing...");
        Is_Injured = false;
        Write_Action("repaired");
    }

    protected void Recharge()
    {
        Write_Action("recharging...");
        is_recharged = true;
        Write_Action("recharged");
    }
}