using System.Collections.Generic;

namespace Services.DTO.User
{
    public class TokenDTO
    {
        public string AccessToken { get; set; }
        public string Username { get; set; }
        public List<string> Role { get; set; }
    }
}