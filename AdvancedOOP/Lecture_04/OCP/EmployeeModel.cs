namespace SOLID
{
    public class EmployeeModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAdress { get; set; }
        public bool IsManager { get; set; } = false;
    }
}