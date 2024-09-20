using Step_6_Validation;

namespace Step_6_Validation_Tests;

public abstract class Component_Test_Base<T> : UnitTest_Base
    where T : IComponent
{
    protected const string Name = "Name";

    protected T Component;

    protected override IComponents Get_Subject()
    {
        Component = Get_Component();
        return new Components().Add(new Name_Component(Name)).Add(Component);
    }

    protected abstract T Get_Component();
}