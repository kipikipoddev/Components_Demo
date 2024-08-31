namespace Step_3_Components;

public class Swim_Component : Component, ISwim_Component
{
    public void Swim()
    {
        Parent.Write_Action_Like("swiming");
    }
}