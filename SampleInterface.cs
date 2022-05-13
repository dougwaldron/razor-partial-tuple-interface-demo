public interface ISampleInterface
{
    int Value { get; }
}

public class ImplementationClass : ISampleInterface
{
    public int Value => 5;
}

public class ModelForPartial
{
    public ModelForPartial(ISampleInterface s, int n) => (Sample, Number) = (s, n);

    public ISampleInterface Sample { get; }
    public int Number { get; }
}
