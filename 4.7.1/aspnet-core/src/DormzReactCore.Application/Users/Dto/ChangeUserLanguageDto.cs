using System.ComponentModel.DataAnnotations;

namespace DormzReactCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}