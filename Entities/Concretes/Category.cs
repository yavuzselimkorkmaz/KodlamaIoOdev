using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category : BaseClass
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
