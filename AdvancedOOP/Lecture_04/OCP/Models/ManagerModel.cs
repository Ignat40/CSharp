namespace SOLID;

public class ManagerModel : IPersonModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public IAccounts? AccountProcessor { get; set; } = new ManagerAccounts();
}