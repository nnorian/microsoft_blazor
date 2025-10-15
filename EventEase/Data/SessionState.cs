namespace EventEase.Data
{
    public class SessionState
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }

        public bool IsRegistred => !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Email);
    }
}