using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutenticacaoGoogleTeste.Models
{
    [Table("User")]
    public class UserModel
    {
        public int UserId { get; set; }

        [Display(Name = "Email")]
        public string UserEmail { get; set; }

        public bool verifiedUser { get; set; }

        [Display(Name = "Nome do Usuário")]
        public string userName { get; set; }
    }
}
