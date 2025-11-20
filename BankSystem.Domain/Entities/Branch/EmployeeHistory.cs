namespace BankSystem.Domain.Entities.Branch;

public class EmployeeHistory
{
    public required Employee EmployeeId { get; set; }
    public required Branche BrancheId { get; set; }
    
    public DateTime HireDate { get; set; } = DateTime.Now;
    
    public decimal PenaltiesForMonth { get; set; }
    public decimal TotalSumOfPenalties { get; set; }
    
    public required Employee OldPosition { get; set; }
    public string? NewPosition { get; set; }
    
    public required Employee OldSalary { get; set; }
    public string? NewSalary { get; set; }
    
    public DateTime EndDate { get; set; } 
    public bool IsActive { get; set; } = true;
    public DateTime UpdatedDate { get; set; } = DateTime.Now;
}