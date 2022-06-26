using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiAutores.Validaciones;
namespace WebApiAutores.Entidades
{
    public class Autor
    {
        //! Probando validaciones
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 100, ErrorMessage = "El campo {0} no debe tener más de {1} carácteres")]
        [PrimeraLetraMayusculaAttribute]
        public string Nombre { get; set; }
        public List<AutorLibro> AutoresLibros { get; set; }
        /*
           [Range(10, 120)]
           [NotMapped]
            public int Edad { get; set; }
           [CreditCard]
           [NotMapped]
            public string TarjetaDeCredito { get; set; }
           [Url]
           [NotMapped]
            public string URL { get; set; }
        */


    }
}