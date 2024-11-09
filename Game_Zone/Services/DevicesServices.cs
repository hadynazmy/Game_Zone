

namespace Game_Zone.Services
{
    public class DevicesServices : IDevicesServices
    {
        private readonly ApplicationDbConText _conText;
        public DevicesServices(ApplicationDbConText conText)
        {
            _conText = conText;
            
        }
        public IEnumerable<SelectListItem> GetSelectList()
        {

            return _conText.Devices.
                Select(d => new SelectListItem
                { Value = d.Id.ToString(), Text = d.Name })
                .OrderBy(d => d.Text).AsNoTracking().ToList();

        }
    }
}
