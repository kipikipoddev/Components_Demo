namespace Step_3_Components;

public class Bark_Component : Component, ISound_Component
{
    public void Make_Sound()
    {
        Write("barking");
    }
}