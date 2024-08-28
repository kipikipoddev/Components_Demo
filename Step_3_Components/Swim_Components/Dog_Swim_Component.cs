using Step_3_Components.Enums;

namespace Step_3_Components;

public class Dog_Swim_Component : Component, ISwim_Component
{
    public void Swim(Speed speed)
    {
        Write($"swiming {Get_Speed(speed)}like a dog");
    }
}