﻿
namespace Step_3_Commands;

public record Print_Was_Command(IComponents Components, Actions_Description Action) : Command(Components)
{
}