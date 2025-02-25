using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BMDBNetWeb.Models;

[Table("Movie")]
[Index("Title", "Year", Name = "UC_Movie", IsUnique = true)]
public partial class Movie
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(75)]
    [Unicode(false)]
    public string Title { get; set; } = null!;

    [Column("YEAR")]
    public int Year { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Rating { get; set; } = null!;

    [StringLength(75)]
    [Unicode(false)]
    public string Director { get; set; } = null!;

    [InverseProperty("Movie")]
    public virtual ICollection<Credit> Credits { get; set; } = new List<Credit>();
   
}
