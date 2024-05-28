using Fina.Core.Enums;

namespace Fina.Core.Models
{
    public class Transaction
    {
        public long Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? PaidOrReceivedAt { get; set; }

        public ETransactionType Type { get; set; } = ETransactionType.Withdrawal;
        public Category Category { get; set; }

        public string UserId { get; set; }
    }
}
