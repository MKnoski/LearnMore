namespace LearnMore.Domain.Models.Authentication
{
    public class Token
    {
        public string Id { get; set; }

        public string AuthToken { get; set; }

        public int ExpiresIn { get; set; }
    }
}