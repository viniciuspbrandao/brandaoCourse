using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components;

namespace brandaoCourse.Models;

public class Subscription
{

    [Key]
    [DisplayName("Id")]
    public int Id{get; set;}

    [Required(ErrorMessage = "Informe o tipo de Subscription")]
    [StringLength(80, ErrorMessage = "Limite maximo 80 caracteres")]
    [MinLength(5, ErrorMessage = "Limite minimo 5 caracteres")]
    [DisplayName("Titulo")]
    public string Title{get; set;} = string.Empty;

    [DataType(DataType.DateTime)]
    //[GreaterThanToday]
    [DisplayName("inicio")]
    public DateTime StartDate{get; set;}

    [DataType(DataType.DateTime)]
    [DisplayName("Termino")]
    public DateTime EndDate {get; set;}


    [DisplayName("Aluno")]
    [Required(ErrorMessage = "Aluno Invalido")]
    public int StudentId {get; set;}

    public Student? Student {get; set;}

}