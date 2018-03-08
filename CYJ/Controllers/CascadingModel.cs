using System.Collections.Generic;
using System.Web.Mvc;

namespace CYJ.Controllers
{
    internal class CascadingModel
    {
        public List<SelectListItem> CATEGORIES { get; internal set; }
        public List<SelectListItem> GOALS { get; internal set; }
        public List<SelectListItem> SUBCATEGORIES { get; internal set; }
        public List<SelectListItem> WORKSTREAMS { get; internal set; }
        public List<SelectListItem> TEAMS { get; internal set; }
    }
}