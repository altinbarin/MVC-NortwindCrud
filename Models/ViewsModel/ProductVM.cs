using _10_MVC_NortwindCrud.Models.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _10_MVC_NortwindCrud.Models.ViewsModel
{
    public class ProductVM
    {
        public List<ProductDTO> plist { get; set; }
        public Product product { get; set; }

        public List<SelectListItem> CategoriesForDropDown { get; set; }

        public List<SelectListItem> SupplierForDropDown { get; set; }

    }
}
