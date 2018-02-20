using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySommelier
{
  public class Region
  {
    public Region()
    { }

    public int RegionId { get; set; }
    [StringLength(10)]
    public string Code { get; set; }
    [StringLength(50)]
    public string RegionName { get; set; }
    public string Description { get; set; }

    public int CountryId { get; set; }
    public virtual Country Country { get; set; }

    public virtual List<Winery> Wineries { get; set; }


  }
}
