using System.ComponentModel.DataAnnotations;

namespace ps3.Models
{
    public class Dane
    {
        [Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]
        [Required(ErrorMessage = "Pole jest obowiązkowe!")]
        public int Rok { get; set; }


        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "W imieniu mogą występować tylko litery")]
        [StringLength(100, ErrorMessage = "Maksymalna długość imienia to 100")]
        [Required(ErrorMessage = "Pole jest obowiązkowe!")]
        public string Imie { get; set; }
    }
}
