using @System.ComponentModel.DataAnnotations;
using FormApp.Components.Pages;

namespace FormApp.Models;

public class Registration 
{
    [Required(ErrorMessage ="Cognome obbligatorio")]
    [StringLength(20, ErrorMessage = "Cognome troppo lungo. Massimo 20 caratteri.")]
    public string? Cognome { get; set;}

    [Required(ErrorMessage = "Nome obbligatorio")]
    [StringLength(20, ErrorMessage = "Nome troppo lungo. Massimo 20 caratteri.")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "Luogo di nascita obbligatorio")]
    public string? LuogoDiNascita { get; set; }

    [Required(ErrorMessage = "Data di nascita obbligatoria")]
    public DateOnly? DataDiNascita { get; set; }

    [Required(ErrorMessage = "Via di residenza obbligatoria")]
    public string? ViaResidenza { get; set; }

    [Required(ErrorMessage = "Numero civico di residenza obbligatorio")]
    public int? NCivResidenza { get; set; }

    [Required(ErrorMessage = "CAP di residenza obbligatorio")]
    public int? CapResidenza { get; set; }

    [Required(ErrorMessage = "Comune di residenza obbligatorio")]
    public string? ComuneResidenza { get; set; }

    [Required(ErrorMessage = "Provincia di residenza obbligatoria")]
    public string? ProvinciaResidenza { get; set; }

    public string? ViaDomicilio { get; set; }

    public int? NCivDomicilio { get; set; }

    public int? CapDomicilio { get; set; }

    public string? ComuneDomicilio { get; set; }

    public string? ProvinciaDomicilio { get; set; }

    [Required(ErrorMessage = "Cittadinanza obbligatoria")]
    public int? Cittadinanza { get; set; }

    [Required(ErrorMessage = "Codice fiscale obbligatorio")]
    public string? CodiceFiscale { get; set; }

    [Required(ErrorMessage = "Email obbligatoria")]
    public string? Email { get; set; }
}