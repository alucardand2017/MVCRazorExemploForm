
using System.ComponentModel.DataAnnotations;

namespace AULA06APPENQUETES.Models;
public class Resposta
{
    [Required(ErrorMessage =$"O atribubo {nameof(Nome)} é necessário")]
    public string? Nome { get; set; }
    [Required(ErrorMessage =$"O atribubo {nameof(Email)} é necessário")]
    [EmailAddress(ErrorMessage ="Email não corresponde a um valor válido.")]
    public string? Email { get; set; }
    [Required(ErrorMessage =$"O atribubo {nameof(Escolha)} é necessário")]
    public bool? Escolha { get; set; }

}