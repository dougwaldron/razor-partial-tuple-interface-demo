public interface ISampleInterface
{
    int Value { get; }
}

public class ImplementationClass : ISampleInterface
{
    public int Value => 5;
}
