namespace Step_3_Components;

public class Robot : Components
{
    public Robot()
    {
        Add(new Name_Component());
        Add(new Charge_Component());
        Add(new Robot_Walk_Component());
        Add(new Recharged_Sound_Component(new Beep_Component()));
    }
}