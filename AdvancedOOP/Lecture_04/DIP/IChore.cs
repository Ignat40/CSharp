namespace SOLID;

public interface IChore
{
    public string? ChoreName { get; set; }
    public IPerson? Owner { get; set; }
    public double HoursWorked { get; }
    public bool IsComplete { get; }

    void CompleteChore();
    void PerformedWork(double hours);
}