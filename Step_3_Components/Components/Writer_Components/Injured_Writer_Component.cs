namespace Step_3_Components;

public class Injured_Writer_Component : Writer_Component
{
    public override void Write_Action(string action)
    {
        if (Parent.Injure().Is_Injured)
            Console.WriteLine($"{Parent.Name()} is {action} painfully");
        else
            base.Write_Action(action);
    }
}