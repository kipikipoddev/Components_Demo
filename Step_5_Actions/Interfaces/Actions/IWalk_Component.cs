﻿
namespace Step_5_Final;

public interface IWalk_Component : IAction_Component
{
    bool Can_Walk();
    void Walk();
}