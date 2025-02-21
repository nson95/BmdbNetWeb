using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BMDBNetWeb.Models;

[Table("Actor")]
[Index("FirstName", "LastName", "Dob", Name = "UC_Actor", IsUnique = true)]
public partial class Actor
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Gender { get; set; } = null!;

    [Column("DOB")]
    public DateOnly Dob { get; set; }

    [InverseProperty("Actor")]
    public virtual ICollection<Credit> Credits { get; set; } = new List<Credit>();
}
