using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Core {

    public class Restaurant {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public CuisineType Cuisine { get; set; }

        public Restaurant() {        }
        public Restaurant(int id,string name,string location,CuisineType cuisine)
        {
            this.Id=id;
            this.Name=name;
            this.Location=location;
            this.Cuisine=cuisine;
        }
    }
}