using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BMDBNetWeb.Models;

[Table("Credit")]
[Index("MovieId", "ActorId", Name = "UC_Credit", IsUnique = true)]
public partial class Credit
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("MovieID")]
    public int MovieId { get; set; }

    [Column("ActorID")]
    public int ActorId { get; set; }

    [StringLength(75)]
    [Unicode(false)]
    public string Role { get; set; } = null!;

    [ForeignKey("ActorId")]
    [InverseProperty("Credits")]
    public virtual Actor Actor { get; set; } = null!;

    [ForeignKey("MovieId")]
    [InverseProperty("Credits")]
    public virtual Movie Movie { get; set; } = null!;
}
