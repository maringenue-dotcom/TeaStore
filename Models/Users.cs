using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeaStoreApi.Models
{
    [Table("Users")]
    public class Users
    {
        public Users(string login, string pass)
        {
            Login = login;
            Pass = pass;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Pass { get; set; }

    }
}
