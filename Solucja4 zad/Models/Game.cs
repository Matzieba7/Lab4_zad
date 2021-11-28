using System;
using System.ComponentModel.DataAnnotations;

namespace Solucja4_zad.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string type { get; set; }
        public int score { get; set; }
    }
}
