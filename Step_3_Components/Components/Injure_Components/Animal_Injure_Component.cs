using Step_3_Components.Enums;

namespace Step_3_Components;

public class Animal_Injure_Component : Component, IInjure_Component
{
    public bool Is_Injured { get; set; }

    public void Injure()
    {
        Parent.Write_Action("injured");
        Is_Injured = true;
        Parent.Get<IData_Component>().Speed = Speed.Slow;
    }
}