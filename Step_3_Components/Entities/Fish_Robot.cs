namespace Step_3_Components;

public class Fish_Robot : Components
{
    public Fish_Robot()
    {
        Add(new Name_Component());
        Add(new Charge_Component());
        Add(new Recharged_Swim_Component(new Swim_Component()));
        Add(new Recharged_Sound_Components(new Beep_Component()));
    }
}