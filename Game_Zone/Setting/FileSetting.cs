using static System.Net.Mime.MediaTypeNames;

namespace Game_Zone.Setting
{
    public static class FileSetting
    {
        public const string ImagesPath ="/assets/images/games";
        public const string AllwoedExtensions =".jpg,.jpeg,.png";
        public const int MaxFileSizeInMB =1;
        public const int MaxFileSizeInByet = MaxFileSizeInMB * 1024 * 1024;
    }
}
