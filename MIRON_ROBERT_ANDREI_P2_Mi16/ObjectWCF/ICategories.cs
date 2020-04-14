using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosProject2.Interfaces
{
    [ServiceContract]
    interface ICategories
    {
        [OperationContract]
        bool isInCategories(string index);

        [OperationContract]
        List<MyPhotos.Categories> GetCategoriesById(int id);
        
    }
}
