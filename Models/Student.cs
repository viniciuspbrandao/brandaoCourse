using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace brandaoCourse.Models;

public class Student
{
    [Key]
    [DisplayName("Id")]
    public int Id {get; set;}

    [Required(ErrorMessage = "Informe o nome")]
    [StringLength(80, ErrorMessage = "Limite maximo 80 caracteres")]
    [MinLength(5, ErrorMessage = "Limite minimo 5 caracteres")]
    [DisplayName("Nome completo")]
    public string Name {get; set;} = string.Empty;

    [Required(ErrorMessage = "Informe o email")]
    [EmailAddress(ErrorMessage = "Email invalido")]
    [DisplayName("Email")]
    public string Email{get; set;} = string.Empty;

    public List<Subscription> Subscriptions {get; set;} = new();

}