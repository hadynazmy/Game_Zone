

namespace Game_Zone.Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly ApplicationDbConText _conText;

        public CategoriesServices(ApplicationDbConText conText)
        {
            _conText = conText;
        }
        public IEnumerable<SelectListItem> GetSelectList()
        {
            return _conText.Categories.Select(c => new SelectListItem
            { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text).AsNoTracking().ToList();

        }
        
    }
}
