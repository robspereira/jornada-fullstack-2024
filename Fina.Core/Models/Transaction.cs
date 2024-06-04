using Fina.Core.Enums;

namespace Fina.Core.Models;


public class Transaction
{
    public long Id { get; set; }
    public string Title { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? PaidOrReceivedAt { get; set; }

    public double Amount { get; set; }
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;
    
    public long CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public string UserId { get; set; } = string.Empty;
}