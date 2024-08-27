namespace Step_3_Components;

public class Robot_Dog : Components
{
    public Robot_Dog()
    {
        Add(new Name_Component());
        Add(new Charge_Component());
        Add(new Recharged_Walk_Component(new Dog_Walk_Component()));
        Add(new Recharged_Swim_Component(new Dog_Swim_Component()));
        Add(new Recharged_Sound_Components(new Bark_Component()));
    }
}