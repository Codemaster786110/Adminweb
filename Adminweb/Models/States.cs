namespace Adminweb.Models
{
   public class States
    {
        public int Id { get; set; }
        public string StateName{ get; set; }
    }

    public class City
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
        public string State { get; set; }
    }
}
