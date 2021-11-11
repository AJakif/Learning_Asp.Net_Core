using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.Models.ViewModels
{
    class HomeViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public IEnumerable<Service> ServiceList { get; set; }
    }
}
