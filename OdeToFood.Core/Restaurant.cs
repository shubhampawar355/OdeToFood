using System.Runtime.CompilerServices;
namespace OdeToFood.Core {

    public class Restaurant {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Location { get; set; }
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