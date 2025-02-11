using System.ComponentModel.DataAnnotations;

namespace orbis.iim.core.Requests.Account;

public class LoginRequest : Request
{
    [Required(ErrorMessage = "Campo obrigatório")]
    [EmailAddress(ErrorMessage = "E-mail inválido")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Password { get; set; } = string.Empty;
}