namespace Step_3_Components;

public class Robot_Cat_Dog : Components
{
    public Robot_Cat_Dog()
    {
        Add(new Name_Component());
        Add(new Charge_Component());
        Add(new Robot_Walk_Component());
        Add(new Recharged_Sound_Components(new Meow_Component(), new Bark_Component()));
    }
}