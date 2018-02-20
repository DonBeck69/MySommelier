using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace MySommelier
{
  public class Wine
  {
    public Wine()
    {
      
    }

    public int WineId { get; set; }

    [StringLength(50)]
    public string WineName { get; set; }
    public int Year { get; set; }

    /// <summary>
    /// gets or sets cork, skrewtop etc
    /// </summary>
    public int SealType { get; set; }
    public int RateTaste { get; set; }
    public int RateSmoothness { get; set; }
    public int RatePrice { get; set; }
    public int RateNose { get; set; }
    public int RateDryness { get; set; }
    public int RateFruitynes { get; set; }
    public int RateWoodyness { get; set; }
    public int RateSweetnes { get; set; }

    public virtual List<Grape> Grapes { get; set; }

    public int WineryId { get; set; }
    public virtual Winery Winery { get; set; }

  }
}
