using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SweetAndSavory.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntries = new HashSet<TreatFlavor>();
    }

    public int FlavorId { get; set; }

    [DisplayName("Install Date")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime InstallDate { get; set; }

    [DisplayName("Flavor Name")]
    public string FlavorName { get; set; }

    public ICollection<TreatFlavor> JoinEntries { get; }
  }
}  