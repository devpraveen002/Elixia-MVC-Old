using System.Text.Json.Serialization;

namespace Elixia.Shared.DTOs;

public class UserDTO : EntityBaseDTO
{
    [JsonPropertyName("userName")]
    public string UserName { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("address")]
    public AddressDTO Address { get; set; }
}
