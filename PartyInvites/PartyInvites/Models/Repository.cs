namespace PartyInvites.Models
{
    public static class Repository
    {
        private static readonly List<GuestResponse> _responses = new();
        public static List<GuestResponse> Responses
        {
            get
            {
                return _responses;
            }
        }
        public static void AddResponse(GuestResponse guestResponse)
        {
            _responses.Add(guestResponse);
        }
    }
}