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

    public class Attachment
    {
        public int AttachmentId { get; set; }
        public int ClaimId { get; set; }
        public string FileName { get; set; }
        public DateTime UploadedOn { get; set; }
    }

public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
