using System.ComponentModel.DataAnnotations;

namespace Zazaflix.Models;

 public class Genre
 {
     [Key] //Define a propriedade como Chave Primária
    public byte Id { get; set; }


    [Required] //Requirido - Not Null; Validação
    [StringLength(30, ErrorMessage ="Porfavor, apenas 30 caracteres")]
    public string Name { get; set; }


}
