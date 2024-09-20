using Step_6_Validation;

namespace Step_6_Validation_Tests;

public abstract class Entity_Test_Base : UnitTest_Base
{
    protected abstract Entities Entity { get; }

    protected override IComponents Get_Subject()
    {
        return Components_Factory.Create(Entity);
    }
}