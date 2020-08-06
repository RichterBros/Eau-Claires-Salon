using System.ComponentModel;
using System.Collections.Generic;
namespace FavoriteClient.Models
{
  public class Client
  {
    
    
    
    [DisplayName("Client Id")]
    public int ClientId { get; set; }
    [DisplayName("Stylist Id")]
    public int StylistId { get; set; }
    [DisplayName("Client Name:")]
    public string Name { get; set; }
    public string Address { get; set; }
    [DisplayName("Client Phone Number:")]
    public string PhoneNumber { get; set; }
  
   [DisplayName("Stylist:")]
    public virtual Stylist Stylist { get; set; }
  
  
  }
}
  
     
    
     





 