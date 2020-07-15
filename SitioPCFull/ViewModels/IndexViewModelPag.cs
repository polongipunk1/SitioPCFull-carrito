using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SitioPCFull.Models;
using IdentitySample.Models;

namespace SitioPCFull.ViewModels
{
    public class IndexViewModelPag : BaseModelo
    {
        public List<ApplicationUser> Personas { get; set; }
    }
}