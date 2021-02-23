using Servicos.Shared.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Servicos.Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Informe o seu nome!")]
        [MaxLength(100,ErrorMessage = "O tamanho máximo do campo é 100 caracteres!")]
        [MinLength(3,ErrorMessage ="O tamanho mínimo do campo é 3 caracteres!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o seu usuário!")]
        [MaxLength(20, ErrorMessage = "O tamanho máximo do campo é 20 caracteres!")]
        [MinLength(3, ErrorMessage = "O tamanho mínimo do campo é 3 caracteres!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Informe sua senha!")]
        [MaxLength(12, ErrorMessage = "O tamanho máximo do campo é 12 caracteres!")]
        [MinLength(6, ErrorMessage = "O tamanho mínimo do campo é 6 caracteres!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Informe seu email!")]
        [EmailAddress(ErrorMessage = "Formato do email inválido")]
        public string Email { get; set; }
        public int TyperUserId { get; set; }
        public virtual TypeUser TypeUser { get; set; }
        public string Image { get; set; }
        public List<Abiliity> Abiliitys { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }

    }
}
