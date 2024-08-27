namespace Step_3_Components;

public class Cat_Walk_Component : Component, IWalk_Component
{
    public void Walk()
    {
        Write("walking like a cat");
    }
}