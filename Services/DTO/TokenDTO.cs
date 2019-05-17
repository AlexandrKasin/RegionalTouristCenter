using System.Collections.Generic;

namespace Services.DTO
{
    public class TokenDto
    {
        public string AccessToken { get; set; }
        public string Username { get; set; }
        public List<string> Role { get; set; }
    }
}