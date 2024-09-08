﻿
namespace Step_2_Components;

public class Charged_Bark_Component : Bark_Component
{
    public override bool Can_Bark()
    {
        return Parent.Get<ICharged_Component>().Is_Charged;
    }
}