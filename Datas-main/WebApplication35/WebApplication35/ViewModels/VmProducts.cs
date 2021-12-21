using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication35.ViewModels
{
    public class VmProducts
    {
        public List<Prodct> Product { get; set; }
        public About About { get; internal set; }
    }
}
