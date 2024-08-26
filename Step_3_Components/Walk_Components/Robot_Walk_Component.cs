namespace Step_3_Components;

public class Robot_Walk_Component : Component, IWalk_Component
{
    public void Walk()
    {
        Parent.Recharge();
        Write("Walking like a robot");
    }
}