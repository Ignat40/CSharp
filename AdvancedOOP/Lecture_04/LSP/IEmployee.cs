namespace SOLID;

public interface IEmployee
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public decimal Salary { get; set; }
    void CalculatePerHourRate(int rank);
}