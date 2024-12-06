using System.Text.Json.Serialization;

namespace Elixia.Shared.DTOs;

public class LoginPasswordDTO
{
    [JsonPropertyName("userName")]
    public string UserName { get; set; }
    [JsonPropertyName("password")]
    public string Password { get; set; }
}
