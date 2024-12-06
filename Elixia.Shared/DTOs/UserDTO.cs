using System.Text.Json.Serialization;

namespace Elixia.Shared.DTOs;

public class UserDTO : EntityBaseDTO
{
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; set; }
    [JsonPropertyName("createdAt")]
    public string CreatedAt { get; set; }
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; set; }
    [JsonPropertyName("modifiedAt")]
    public string ModifiedAt { get; set; }
}
