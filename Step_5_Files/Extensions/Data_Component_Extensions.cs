using Step_5_Files.Enums;

namespace Step_5_Files;

public static class Data_Component_Extensions
{
    public static Speed_Type Speed(this IComponents components)
    {
        return components.Get<Data_Component>().Speed;
    }

    public static string Name(this IComponents components)
    {
        return components.Get<Data_Component>().Name;
    }

    public static bool Is_Injured(this IComponents components)
    {
        return components.Get<Data_Component>().Is_Injured;
    }

    public static Entity_Types Type(this IComponents components)
    {
        return components.Get<Data_Component>().Type;
    }
}