namespace Step_3_Components;

public class Bark_Sound_Component : Component, ISound_Component
{
    public void Make_Sound()
    {
        Write("Barking");
    }
}