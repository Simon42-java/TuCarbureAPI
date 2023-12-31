using MySqlX.XDevAPI;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuCarbureAPI.EntityLayer;

[Table("carburants", Schema = "tucarbure")]
public class Carburant
{
    [Required]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id_carburant")]
    public int idCarburant { get; set; }
    public string? nom { get; set; }

    [Column("code_europeen")]
    public string? codeEuropeen { get; set; }

}
