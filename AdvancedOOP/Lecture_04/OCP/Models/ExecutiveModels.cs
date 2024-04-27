namespace SOLID;

public class ExecutiveModeels : IPersonModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public IAccounts? AccountProcessor { get; set; } = new ExecutiveAccounts();
}