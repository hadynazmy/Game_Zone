using Game_Zone.Attributes;

namespace Game_Zone.ViewModels
{
    public class EditGameFormViewModel : GameFormViewModel
    {
        public int Id { get; set; }

        public string? CurrentCover { get; set; }

        [AllowedExtensions(FileSetting.AllwoedExtensions),
            MaxFileSize(FileSetting.MaxFileSizeInByet)]
        public IFormFile? Cover { get; set; } = default!;
    }
}
