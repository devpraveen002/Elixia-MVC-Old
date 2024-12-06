using System.ComponentModel.DataAnnotations.Schema;

namespace Elixia.Shared.Entities;

[Table(name: "address", Schema = "main")]
public class Address : EntityBase
{
    [Column(name: "address_line1", Order = 1)]
    public string AddressLine1 { get; set; }

    [Column(name: "address_line2", Order = 2)]
    public string? AddressLine2 { get; set; }

    [Column(name: "city", Order = 3)]
    public string City { get; set; }
    [Column(name: "state", Order = 4)]
    public string State { get; set; }
    [Column(name: "zip_code", Order = 5)]
    public string ZipCode { get; set; }
    [Column(name: "country", Order = 6)]
    public string Country { get; set; }
}