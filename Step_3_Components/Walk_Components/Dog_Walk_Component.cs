namespace Step_3_Components;

public class Dog_Walk_Component : Component, IWalk_Component
{
    public void Walk()
    {
        Write("walking like a dog");
    }
}