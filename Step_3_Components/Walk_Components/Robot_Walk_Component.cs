namespace Step_3_Components;

public class Robot_Walk_Component : Component, IWalk_Component
{
    public void Walk()
    {
        Parent.Recharge_If_Need();
        Write("Walking like a robot");
    }
}