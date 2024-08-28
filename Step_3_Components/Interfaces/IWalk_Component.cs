using Step_3_Components.Enums;

namespace Step_3_Components;

public interface IWalk_Component : IComponent
{
    void Walk(Speed speed = Speed.Normal);
}