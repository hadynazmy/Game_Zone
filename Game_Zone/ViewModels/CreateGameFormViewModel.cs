using Game_Zone.Attributes;
namespace Game_Zone.ViewModels
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
        


        [AllowedExtensions(FileSetting.AllwoedExtensions),
            MaxFileSize(FileSetting.MaxFileSizeInByet)]
        public IFormFile Cover { get; set; } = default!;

        


    }
}
