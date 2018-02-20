using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MySommelier
{
  public class SommelierDataContext : DbContext
  {
    public DbSet<Winery> Wineries { get; set; }
    public DbSet<Wine> Wines { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Grape> Grapes { get; set; }
    public DbSet<Region> Regions { get; set; }
  }
}
