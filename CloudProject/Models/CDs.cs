using System.ComponentModel.DataAnnotations;

namespace CloudProject.Models
{
    public class CDs
    {
        public CDs(int idCD) 
        {
            this.idCD = idCD;
            CDName = "";
            Artist = "";
            Genre = "";
            Arrive = DateTime.Now;
        }

        public CDs(int idCD, string CDName, string Artist, string Genre, int Quantity, DateTime Arrive)
        {
            this.idCD = idCD;
            this.CDName = CDName; 
            this.Artist = Artist;
            this.Genre = Genre;
            this.Quantity = Quantity;
            this.Arrive = Arrive;
        }

        public int idCD { get; set; }
        [Required(ErrorMessage = "CD Name is required")]
        public string CDName { get; set; }
        [Required(ErrorMessage = "Artist name is required")]
        public string Artist { get; set; }
        [Required(ErrorMessage = "Genre field is required")]
        public string Genre { get; set; }
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Arrival date is required")]
        public DateTime Arrive { get; set; }

    }
}
