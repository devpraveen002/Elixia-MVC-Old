using System.ComponentModel.DataAnnotations.Schema;

namespace Elixia.Shared.Entities;

[Table(name: "user", Schema = "main")]
public class User : EntityBase
{
    [Column(name: "user_name", Order = 1)]
    public string UserName { get; set; }
    [Column(name: "password", Order = 2)]
    public string Password { get; set; }
    [Column(name: "email", Order = 3)]
    public string Email { get; set; }
    [Column(name: "address_id", Order = 4)]
    public long AddressId { get; set; }

}
