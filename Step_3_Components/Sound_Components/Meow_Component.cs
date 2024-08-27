namespace Step_3_Components;

public class Meow_Component : Component, ISound_Component
{
    public void Make_Sound()
    {
        Write("meowing");
    }
}
