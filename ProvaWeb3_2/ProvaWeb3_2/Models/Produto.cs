using System.ComponentModel.DataAnnotations;

namespace ProvaWeb3_2.Models
{
    public class Produto
    {
        [Key]
        public long id { get; set; }
        public string nome { get; set; }
        public float valor { get; set; }
    }
}
