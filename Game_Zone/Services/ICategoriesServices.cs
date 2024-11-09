namespace Game_Zone.Services
{
    public interface ICategoriesServices
    {
        IEnumerable<SelectListItem> GetSelectList();
        
    }
}
