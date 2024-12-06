using System.Text.Json.Serialization;

namespace Elixia.Shared.DTOs;

public class AddressDTO : EntityBaseDTO
{
    [JsonPropertyName("addressLine1")]
    public string AddressLine1 { get; set; }
    [JsonPropertyName("city")]
    public string City { get; set; }
    [JsonPropertyName("state")]
    public string State { get; set; }
    [JsonPropertyName("zipcode")]
    public string ZipCode { get; set; }
    [JsonPropertyName("country")]
    public string Country { get; set; }
}
