using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeaStoreApi.Models
{
    [Table("Teas")]
    public class Teas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }
        public int Price { get; set; }

    }
}
