namespace LearnMore.Domain.Models
{
    public struct UserVerification
    {
        public UserVerification(bool isVerified, string id = null)
        {
            this.IsVerified = isVerified;
            this.Id = id;
        }

        public bool IsVerified { get; set; }

        public string Id { get; set; }
    }
}