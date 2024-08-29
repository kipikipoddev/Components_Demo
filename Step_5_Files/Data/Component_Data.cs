using Step_5_Files.Commands;
using Step_5_Files.Enums;
using Step_5_Files.Sound_Handlers;

namespace Step_5_Files.Data;

public record Component_Data(string Name, Dictionary<string, object> Properties)
{
    public Components Map()
    {
        var components = new Components();
        components.Add(Get_Data());
        components.Add(Get_Writer());
        components.Add(Get_Charge());
        components.Add(Get_Injure());
        components.Add(Get_Walk());
        components.Add(Get_Sound());
        components.Add(Get_Swim());
        components.Add(new No_Handler_Handler());

        if (components.Has<Recharge_Component>())
        {
            Add_Robots<Walk_Command>(components);
            Add_Robots<Make_Sound_Command>(components);
            Add_Robots<Swim_Command>(components);
        }
        return components;
    }

    private IComponent Get_Data()
    {
        var type = Get_Enum<Entity_Types>("Type");
        var speed = Get_Enum<Speed_Type>("Speed");
        return new Data_Component(Name, speed, type);
    }

    private IComponent? Get_Writer()
    {
        var writer = Properties["Writer"].ToString();
        if (writer.Equals("Injured"))
            return new Injured_Write_Handler();
        return new Write_Handler();
    }

    private IComponent? Get_Injure()
    {
        var injure = Properties["Injure"].ToString();
        if (injure.Equals("Animal"))
            return new Animal_Injure_Handler();
        if (injure.Equals("Robot"))
            return new Robot_Injure_Handler();
        return null;
    }

    private IComponent? Get_Walk()
    {
        return Properties.ContainsKey("Walk") ?
             new Walk_Handler() :
             null;
    }

    private IComponent? Get_Sound()
    {
        if (!Properties.ContainsKey("Sound"))
            return null;
        var sound = Properties["Sound"].ToString()!;
        if (sound.Equals("Meow"))
            return new Meow_Handler();
        if (sound.Equals("Bark"))
            return new Bark_Handler();
        if (sound.Equals("Beep"))
            return new Beep_Handler();
        return null;
    }

    private IComponent? Get_Swim()
    {
        return Properties.ContainsKey("Swim") ?
             new Swim_Handler() :
             null;
    }

    private IComponent? Get_Charge()
    {
        return Properties.ContainsKey("Charge") ?
             new Recharge_Component() :
             null;
    }

    private void Add_Robots<T>(IComponents components)
        where T : Command
    {
        if (components.Can<T>())
        {
            components.Add(new Repair_Handler<T>(), true);
            components.Add(new Recharge_Handler<T>(), true);
        }
    }

    private T Get_Enum<T>(string key)
        where T : struct
    {
        return Enum.Parse<T>(Properties[key].ToString()!);
    }
}