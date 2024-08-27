namespace Step_5_Files.Resources;

public class Named_Resource
{
    public string Name { get; private set; }

    public void Set_Name(string path)
    {
        var index = path.LastIndexOf('\\') + 1;
        Name = path.Substring(index, path.Length - index - 5);
    }
}