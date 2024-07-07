using System.ComponentModel.DataAnnotations.Schema;

namespace sharktrivia.Models;

public class Answer
{
    public int Id { get; set; }
    public string? Text { get; set; }
    public int QuestionId { get; set; }
    public bool Correct {get ; set; }
    [ForeignKey(nameof(QuestionId))]
    public Question? Question { get; set; }
}