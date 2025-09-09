namespace ContractMonthlyClaimSystems.Models
{
    public class Attachment
    {
        public int AttachmentId { get; set; }
        public int ClaimId { get; set; }
        public string FileName { get; set; }
        public DateTime UploadedOn { get; set; }
    }
}
