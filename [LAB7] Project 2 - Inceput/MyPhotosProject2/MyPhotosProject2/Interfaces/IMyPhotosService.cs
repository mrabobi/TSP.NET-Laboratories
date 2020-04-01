using MyPhotosProject2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosProject2
{
    interface IMyPhotosService : ICategories, IPerson, IPicTable
    {
    }
}
