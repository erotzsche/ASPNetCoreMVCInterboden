using System.ComponentModel.DataAnnotations;

namespace ASPNetMVCAppInterboden.Model
{
    public class Wohnung
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Bitte eine Beschreibung angeben!")]
        [StringLength(50, ErrorMessage = "Die Beschreibung darf nur 50 Zeichen lang sein!")]
        public string Beschreibung { get; set; }
        [Required(ErrorMessage ="Bitte die Straße angeben")]
        [Display(Name = "Straße")]
        [StringLength(255, ErrorMessage = "Die Anschrift darf nur 255 Zeichen lang sein!")]
        public string Strasse { get; set; }
        [Required(ErrorMessage = "Bitte die Postleitzahl angeben")]
        [Display(Name = "PLZ")]
        [RegularExpression("[0-9]{5}", ErrorMessage = "Die Postleitzahl muss 5-stellig sein und darf nur Zahlen enthalten")]
        public string Postleitzahl { get; set; }
        [Required(ErrorMessage = "Bitte den Ort angeben")]
        [StringLength(255, ErrorMessage = "Der Ortsname darf nur 255 Zeichen lang sein!")]
        public string Ort { get; set; }
        [Display(Name = "Inaktiv")]
        public bool IstInaktiv { get; set; }
    }
}
