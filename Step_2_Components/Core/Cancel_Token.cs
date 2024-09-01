
namespace Components_Demo;

public class Cancel_Token
{
    public bool Is_Canceled { get; private set; }

    public void Cancel()
    {
        Is_Canceled = true;
    }
}