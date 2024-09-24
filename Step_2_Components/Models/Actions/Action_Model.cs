namespace Step_2_Components;

public class Action_Model
{
    private readonly IPrint_Model print_model;

    public Action_Model(IPrint_Model print_model)
    {
        this.print_model = print_model;
    }

    protected void Print_Was(Actions_Description actions)
    {
        print_model.Print_Was(actions);
    }

    protected void Print_Cant(Actions actions)
    {
        print_model.Print_Cant(actions);
    }
}