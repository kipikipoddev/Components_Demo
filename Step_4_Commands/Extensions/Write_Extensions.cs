using Step_4_Commands.Commands;

namespace Step_4_Commands;

public static class Write_Extensions
{
    public static void Write_Actions(this IComponents components)
    {
        new Write_Command(components, Write_Commad_Types.Actions);
    }

    public static void Write_Action(this IComponents components, string action)
    {
        new Write_Command(components, Write_Commad_Types.Action, action);
    }

    public static void Write_Action_Like(this IComponents components, string action)
    {
        new Write_Command(components, Write_Commad_Types.Action_Like, action);
    }

    public static void Write_Cannot(this IComponents components, string action)
    {
        new Write_Command(components, Write_Commad_Types.Cannot, action);
    }
}