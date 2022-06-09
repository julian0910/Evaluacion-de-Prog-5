using System;

using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;


namespace MvcMovie.Models

{

    public class Movie

    {

        public int Id { get; set; }


        [StringLength(60, MinimumLength = 3)]

        public string Componente { get; set; }


        [Display(Name = "Fecha De Salida"), DataType(DataType.Date)]

        public DateTime FechaDeSalida { get; set; }


        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]

        public string Marca { get; set; }


        [Range(1, 99999999), DataType(DataType.Currency)]

        [Column(TypeName = "decimal(18, 2)")]

        public decimal Precio { get; set; }


        public string Valoracion { get; set; }

        public byte Imagen { get; set; }

    }



}
