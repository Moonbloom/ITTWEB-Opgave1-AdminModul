using System.Collections.Generic;

namespace ITTWEB_Opg1_AdminModul.Models
{
  public class EnrichendUser

{
  public ApplicationUser AppUser { get; set; }
  public IEnumerable<string> Roles { get; set; }
}
}