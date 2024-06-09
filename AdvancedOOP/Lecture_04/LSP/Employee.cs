namespace SOLID;

public class Employee : BaseEmployee, IManaged
{
    public IEmployee? Manager { get; set; } = null;
    IEmployee IManaged.Manager { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public virtual void AssignManager(IEmployee manager)
    {
        Manager = manager;
    }

}