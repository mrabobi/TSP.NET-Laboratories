using MyPhotos;
using MyPhotosProject2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosProject2
{
    [ServiceContract]
    interface IMyPhotosService : ICategories, IPerson, IPicTable
    {
        
    }
}
