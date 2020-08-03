using System.ComponentModel;

namespace FavoriteClient.Models
{
  public class Client
  {
     
     //public string Description { get; set; }
     
     [DisplayName("Client Id")]
    public int ClientId { get; set; }
    [DisplayName("Stylist Id")]
    public int StylistId { get; set; }
    [DisplayName("Client Name:")]
    public string Name { get; set; }
    // [DisplayName("Price Range:")]
    // public string PriceRange { get; set; }
    // [DisplayName("Do they deliver?:")]
    // public string Delivery { get; set; }
    // [DisplayName("Do they do takeout?:")]
    // public string Takeout { get; set; }
    // [DisplayName("Can I dine in?")]
    // public string DineIn { get; set; }
    // [DisplayName("Restaurant Address:")]
    public string Address { get; set; }
    [DisplayName("Client Phone Number:")]
    public string PhoneNumber { get; set; }
    // [DisplayName("Did they pass their most recent health inspection?:")]
    
    // public Health PassedHealthInspection { get; set; }
                 //[DisplayName("What kind of stylist does this client use?:")]
   [DisplayName("Stylist:")]
    public virtual Stylist Stylist { get; set; }
  



  }

  // public enum Health
  // {
  //   yes,
  //   no
  // }
}