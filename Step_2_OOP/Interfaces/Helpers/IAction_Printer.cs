﻿namespace Step_2_OOP;

public interface IAction_Printer
{
    void Print_Action(IEntity entity, Actions action, Speed? speed = null);
    void Print_Cannot(IEntity entity, Actions action);
    void Print_Actions(IEntity entity);
}