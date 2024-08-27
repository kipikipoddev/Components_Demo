namespace Step_3_Components;

public class Fish_Swim_Component : Component, ISwim_Component
{
    public void Swim()
    {
        Write("swiming like a fish");
    }
}