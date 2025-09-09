namespace ContractMonthlyClaimSystems.Models
{
    public class Claim
    {
         public int ClaimId { get; set; }
        public string LecturerName { get; set; }
        public DateTime ClaimPeriod { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } // Draft, Submitted, Verified, Approved, Settled

    }
}
