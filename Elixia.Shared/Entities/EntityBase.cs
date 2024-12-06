using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elixia.Shared.Entities;

public class EntityBase
{
    [Key]
    [Column(name: "id", Order = 0)]
    public long Id { get; set; }

    [Column(name: "created_by")]
    public long CreatedBy { get; set; }
    [Column(name: "created_at")]
    public DateTime CreatedAt { get; set; }
    [Column(name: "modified_by")]
    public long? ModifiedBy { get; set; }
    [Column(name: "modified_at")]
    public DateTime? ModifiedAt { get; set; }

}
