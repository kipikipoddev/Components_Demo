using Step_3_Components.Enums;

namespace Step_3_Components;

public class Fish_Swim_Component : Component, ISwim_Component
{
    public void Swim(Speed speed)
    {
        Write($"swiming {Get_Speed(speed)}like a fish");
    }
}