using MyPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotosProject2.Interfaces
{
    [ServiceContract]
    interface IPicTable
    {
        [OperationContract]
        void AddEntry(string name, string path, string description, string location, DateTime dt, List<string> categories, List<string> peoplys);

        [OperationContract]
        void updateEntry(int id, string title, string description, string location, List<string> categories, List<string> peoples);

        [OperationContract]
        List<PicTable> GetAllPicsForLoad();

        [OperationContract]
        void RemoveEntry(int ImageIndex);

        [OperationContract]
        List<PicTable> getDataFiltered(string filterString, string text);
    }
}
