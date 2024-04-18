using Microsoft.AspNetCore.Http.HttpResults;

namespace NetCoreWebProject.Model.Interface
{
    public class M51 : GunfireWeapons, IZoomable
    {
        public string Zoom()
        {
            return "Yakınlaştırıldı";
        }
    }
}
