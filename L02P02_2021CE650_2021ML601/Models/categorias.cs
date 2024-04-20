using System.ComponentModel.DataAnnotations;

namespace L02P02_2021CE650_2021ML601.Models
{
    public class categorias
    {
        [Key]
        public int id { get; set; }
        public string? categoria { get; set; }

    }
}
