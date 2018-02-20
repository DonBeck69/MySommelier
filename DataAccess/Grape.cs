using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace MySommelier
{
  public class Grape
  {
    public Grape()
    {
      
    }

    public int GrapeId { get; set; }

    [StringLength(50)]
    public string GrapeName { get; set; }
    public string Description { get; set; }
    public int Rate { get; set; }

    public int WineId { get; set; }
    public virtual Wine Wine { get; set; }

  }
}
