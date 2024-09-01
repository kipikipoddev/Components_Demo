namespace Components_Demo;

public class Cancel_Token
{
    public bool Is_Cancled { get; private set; }

    public void Cancel()
    {
        Is_Cancled = true;
    }
}
