Console.WriteLine("Hello, World!");

public sealed class Quotation : IAggregate
{
    public string Code { get; private set; }

    public int MyProperty { get; set; }

    private Contract? _contract;
    public IContract? Contract => _contract;

    public void SignContract()
    {

        if (_contract is null) throw new NullReferenceException("Ops.. Contract is null...");
        _contract.Sign();
        Validate();
    }

    private void Validate()
    {
        var allTheInvariantsAreOk = true;
        if (!allTheInvariantsAreOk) throw new Exception("Well, we have a problem here...");
    }

    // [...] many other methods and constructos...
}

internal class Contract : IContract, IEntity
{
    public int XptoImportantToTheContract { get; private set; }
    public bool Signed { get; private set; }

    public void Sign() => Signed = true;
}

public interface IContract
{
    int XptoImportantToTheContract { get; }
    bool Signed { get; }
}

// seed work
interface IAggregate { };
interface IEntity { };