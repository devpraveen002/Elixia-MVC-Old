using System.Text.Json.Serialization;

namespace Elixia.Shared.DTOs;

public class LoginDTO : EntityBaseDTO
{
    [JsonPropertyName("user_name")]
    public string UserName { get; set; }
}
