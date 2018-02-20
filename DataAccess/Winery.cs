using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MySommelier
{
  public class Winery
  {
    public Winery()
    {
      
    }

    public int WineryId { get; set; }
    public string WineryName { get; set; }

    public virtual List<Wine> Wines { get; set; }

    public int RegionId { get; set; }
    public virtual Region Region { get; set; }


  }
}
