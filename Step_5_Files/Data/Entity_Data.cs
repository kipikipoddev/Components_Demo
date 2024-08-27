using Step_5_Files.Core;
using Step_5_Files.Sound_Handlers;
using Step_5_Files.Walk_Handlers;

namespace Step_5_Files.Data;

public record Entity_Data(string Name,string[] Sounds, string Walk, bool Charge)
{
    public Entity_Data Validate()
    {
        if (Sounds == null || Sounds.Length == 0)
            throw new ArgumentException("Sounds is empty");
        if (string.IsNullOrEmpty(Walk))
            throw new ArgumentException("Walk is empty");
        return this;
    }

    public Components Map()
    {
        var components= new Components();
        components.Add(new Name_Component(Name));
        foreach (var sound in Sounds.Reverse())
        {
            switch (sound)
            {
                case "Meow":
                    components.Add(new Meow_Sound_Handler());
                    break;
                case "Bark":
                    components.Add(new Bark_Sound_Handler());
                    break;
                case "Charge":
                    components.Add(new Charge_Sound_Handler());
                    break;
            }
        }
        switch (Walk)
        {
            case "Normal":
                components.Add(new Normal_Walk_Handler());
                break;
            case "Robot":
                components.Add(new Robot_Walk_Handler());
                break;
        }
        if (Charge)
            components.Add(new Charge_Component());
        return components;
    }
}
