using Step_3_Components.Enums;

namespace Step_3_Components;

public interface ISwim_Component : IComponent
{
    void Swim(Speed speed = Speed.Normal);
}