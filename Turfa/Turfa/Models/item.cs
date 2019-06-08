using System;
namespace Turfa.Models
{
    public class item
    {
        public item(String Name, String Image, String Price, String Phone, String Description, String Email, Double x, Double y)
        {
            this.Image = Image;
            this.Price = Price;
            this.Name = Name;
            this.Phone = Phone;
            this.Description = Description;
            this.Email = Email;
            this.x = x;
            this.y = y;
        }

        public item()
        {
        }

        public string Image { get; set; }
        public string Price { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public double x { get; set; }
        public double y { get; set; }
    }
}
