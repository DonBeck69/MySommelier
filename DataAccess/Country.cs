using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySommelier
{
  public class Country
  {
    public Country()
    {

    }

    public int CountryId { get; set; }

    /// <summary>
    /// get or sets country name
    /// </summary>
    [StringLength(50)]
    public string CountryName { get; set; }
    [StringLength(2)]
    public string ISO2 { get; set; }
    public string Description { get; set; }

    public virtual List<Region> Regions { get; set; }


  }
}
