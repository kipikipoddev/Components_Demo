using Step_3_Components.Enums;

namespace Step_3_Components;

public class Dog_Walk_Component : Component, IWalk_Component
{
    public void Walk(Speed speed)
    {
        Write($"walking {Get_Speed(speed)}like a dog");
    }
}