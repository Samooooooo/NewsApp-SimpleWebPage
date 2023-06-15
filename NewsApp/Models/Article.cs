using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace NewsApp.Models
{
  public partial class Article
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "Bitte Einen Betriff angeben")]
    public string Headline { get; set; }
    [Required(ErrorMessage = "Bitte Parr sätze einzufügen")]
    [MinLength(10, ErrorMessage = ("Ein Content muss Minimal 10 Zeichnen haben"))]
    public string Content { get; set; }
    public DateTime Created { get; set; }
    [Required(ErrorMessage = "Ihere Name Bitte")]
    public string Author { get; set; }
    [Required(ErrorMessage = "Einen bild ist benötigt")]
    public string ImageFile { get; set; }
  }
}
