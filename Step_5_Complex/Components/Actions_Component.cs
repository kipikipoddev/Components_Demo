
namespace Step_5_Complex;

public class Actions_Component : Component, IActions_Component
{
    public IEnumerable<Actions> Available_Actions
    {
        get
        {
            return null;//var components = Parent.Get_All<IAction_Component>();
        }
    }
}