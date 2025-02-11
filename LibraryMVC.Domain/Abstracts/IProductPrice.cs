using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Domain.Abstracts
{
    public interface IProductPrice:IEntity
    {
        public int Price { get; set; }
    }
}
