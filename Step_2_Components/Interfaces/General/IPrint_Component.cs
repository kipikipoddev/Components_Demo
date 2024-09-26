namespace Step_2_Components;

public interface IPrint_Component : IComponent
{
    void Print_Was(Actions_Description action);
    void Print_Cant(Actions action);
}