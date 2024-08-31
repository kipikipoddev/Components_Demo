namespace Step_3_Components;

public class Walk_Component : Component, IWalk_Component
{
    public void Walk()
    {
        Parent.Write_Action_Like("walking");
    }
}