using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdressDropdownlist.Models
{
    public class Ilceler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IlceID { get; set; }
        public string Ilce { get; set; }
        public int IlID { get; set; }        
    }
}
