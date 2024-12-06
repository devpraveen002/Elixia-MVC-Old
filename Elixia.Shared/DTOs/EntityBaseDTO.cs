using System.Text.Json.Serialization;

namespace Elixia.Shared.DTOs;

public class EntityBaseDTO
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; set; }
    [JsonPropertyName("createdAt")]
    public string CreatedAt { get; set; }
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; set; }
    [JsonPropertyName("modifiedAt")]
    public string ModifiedAt { get; set; }
}
