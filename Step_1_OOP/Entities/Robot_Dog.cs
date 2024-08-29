namespace Step_1_OOP;

public class Robot_Dog : Robot
{
    public Robot_Dog(IAction_Printer printer, Speed speed)
        : base(printer, speed)
    {
        Can_Walk = true;
        Can_Make_Sound = true;
        Can_Swim = true;
    }

    public override void Make_Sound()
    {
        if (Can_Make_Sound)
            Printer.Print_Action(this, Actions.Barking);
        else
            base.Make_Sound();
    }
}