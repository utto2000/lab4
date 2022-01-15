using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Games
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)] //we need Date only
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
    }
}
