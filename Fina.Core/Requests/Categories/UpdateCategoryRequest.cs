using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    [Required(ErrorMessage = "Título Inválido")]
    [MaxLength(80, ErrorMessage = "O título deve conter até 90 caracteres!")]
    public string Title { get; set; } = string.Empty;
    
    public long Id { get; set; }

    [Required(ErrorMessage = "Descrição Inválida")]
    public string Description { get; set; } = string.Empty;
}