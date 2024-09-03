﻿
namespace Components_Better_Solution;

public class Charge_Command(IComponents components)
    : Action_Command(components)
{
    public override Actions Name => Actions.Charge;
    public override Actions Was => Actions.Charged;
}