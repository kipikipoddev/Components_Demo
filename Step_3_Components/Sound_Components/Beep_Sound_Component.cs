namespace Step_3_Components;

public class Beep_Sound_Component : Component, ISound_Component
{
    public void Make_Sound()
    {
        Write("Beeping");
    }
}