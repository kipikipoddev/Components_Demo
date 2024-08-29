using Step_5_Files.Enums;
using Step_5_Files.Sound_Handlers;

namespace Step_5_Files.Data;

public record Component_Data(string Name, Dictionary<string, object> Properties)
{
    public Components Map()
    {
        var components = new Components();
        components.Add(Get_Data());
        components.Add(Get_Ingure());
        return components;
    }

    private IComponent Get_Data()
    {
        var type = Get_Enum<Entity_Types>("Type");
        var speed = Get_Enum<Speed_Type>("Speed");
        return new Data_Component(Name, speed, type);
    }

    private IComponent? Get_Ingure()
    {
        var injure = Properties["Injure"];
        if (injure.Equals("Animal"))
            return new Animal_Injure_Handler();
        if (injure.Equals("Robot"))
            return new Robot_Injure_Handler();
        return null;
    }

    private T Get_Enum<T>(string key)
        where T : struct
    {
        return Enum.Parse<T>(Properties[key].ToString()!);
    }
}