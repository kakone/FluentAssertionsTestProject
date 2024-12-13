namespace FluentAssertionsTestProject;

internal class MyClass : IMyInterface
{
    public string Type { get; } = nameof(TypeCode.Object);

    TypeCode IMyInterface.Type => TypeCode.Object;
}
