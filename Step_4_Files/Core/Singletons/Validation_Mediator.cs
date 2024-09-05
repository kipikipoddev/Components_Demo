
using System.Reflection;

namespace Step_4_Files;

public static class Validation_Mediator
{
    private static MethodInfo method;

    public static bool Is_Valid(Command cmd)
    {
        Init();
        return Is_Valid_Type(cmd, cmd.GetType());
    }

    private static bool Is_Valid_Type(Command cmd, Type type)
    {
        if (type == null || type == typeof(object))
            return true;
        var gen_method = method.MakeGenericMethod(type!);
        var is_valid = (bool)gen_method.Invoke(null, [cmd]);
        if (!is_valid)
            return false;
        return Is_Valid_Type(cmd, type.BaseType);
    }

    private static bool Is_Valid_Gen<T>(T cmd)
        where T : Command
    {
        var validators = cmd.Components.Get_All<IValidator<T>>().ToArray();
        foreach (var validator in validators)
            if (!validator.Is_Valid(cmd))
                return false;
        return true;
    }

    private static void Init()
    {
        if (method == null)
            method = typeof(Validation_Mediator).GetMethod("Is_Valid_Gen", BindingFlags.Static | BindingFlags.NonPublic)!;
    }
}
