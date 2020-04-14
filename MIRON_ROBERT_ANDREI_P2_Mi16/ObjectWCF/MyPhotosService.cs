using MyPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyPhotosProject2
{
    public class MyPhotosService : IMyPhotosService
    {
        private readonly API myAPI;

        public MyPhotosService()
        {
            myAPI = new API();
        }

        public void AddEntry(string name, string path, string description, string location, DateTime dt, List<string> categories, List<string> peoplys)
        {
            myAPI.AddEntry(name,path,description,location,dt,categories,peoplys);
        }

        public bool existPerson(string nameP)
        {
            return myAPI.existPerson(nameP);
        }

        public List<PicTable> GetAllPicsForLoad()
        {
            return myAPI.GetAllPicsForLoad();
        }

        public List<Categories> GetCategoriesById(int id)
        {
            return myAPI.GetCategoriesById(id);
        }

        public List<PicTable> getDataFiltered(string filterString, string text)
        {
            return myAPI.getDataFiltered(filterString, text);
        }

        public bool isInCategories(string index)
        {
            return myAPI.isInCategories(index);
        }

        public void RemoveEntry(int ImageIndex)
        {
            myAPI.RemoveEntry(ImageIndex);
        }

        public void updateEntry(int id, string title, string description, string location, List<string> categories, List<string> peoples)
        {
            myAPI.updateEntry(id, title, description, location, categories, peoples);
        }
    }
}
