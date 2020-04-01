using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyPhotos
{
    public class API
    {
        private readonly DatabaseModelContainer dbcontext;

        public API()
        {
            dbcontext = new DatabaseModelContainer();
        }

        public List<PicTable> GetAllPicsForLoad()
        {
            return dbcontext.PicTableSet.ToList();
        }

        public bool isInCategories(string index)
        {
            return dbcontext.CategoriesSet.Any(obj => obj.CategoryName == index);
        }

        

        public bool existPerson(string nameP)
        {
            return dbcontext.PersonSet.Any(obj => obj.FirstName == nameP);
        }

        public void AddEntry(string name, string path, string description, string location, DateTime dt, List<string> categories,List<string>peoplys)
        {
            try
            {
                PicTable newPic = new PicTable
                {
                    Name_img = name,
                    Path = path,
                    Location = location,
                    Description = description,
                    Data_create = dt
                };
                foreach (var index in categories) {
                    if (!isInCategories(index))
                    {
                        Categories cat = new Categories
                        {
                            CategoryName = index
                        };
                        newPic.Categories.Add(cat);
                        cat.PicTable.Add(newPic);
                    }
                    else
                    {
                        Categories cat = dbcontext.CategoriesSet.FirstOrDefault(obj => obj.CategoryName == index);
                        newPic.Categories.Add(cat);
                        cat.PicTable.Add(newPic);
                    }

                }

                foreach (var nameP in peoplys)
                {
                    
                    if (!existPerson(nameP))
                    {
                        Person pers = new Person
                        {
                            FirstName = nameP,

                        };

                        newPic.Person.Add(pers);
                        pers.PicTable.Add(newPic);
                    }
                    else
                    {
                        Person pers = dbcontext.PersonSet.FirstOrDefault(obj => obj.FirstName == nameP);
                        newPic.Person.Add(pers);
                        pers.PicTable.Add(newPic);
                    }
                }

                dbcontext.PicTableSet.Add(newPic);
                dbcontext.SaveChanges();
            }
            
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public void updateEntry(int id, string title, string description, string location,List<string>categories, List<string>peoples)
        {
            var personRelRemove = (from per in dbcontext.PersonSet
                                   where per.PicTable.Any(
                                       p => p.ID_IMG == id)
                                   select per).ToList();
            var categoryRelRemove = (from cat in dbcontext.CategoriesSet
                                     where cat.PicTable.Any(
                                         p=> p.ID_IMG == id)
                                     select cat).ToList();

            var result = dbcontext.PicTableSet.SingleOrDefault(p => p.ID_IMG == id);
            if (result != null)
            {
                result.Name_img = title;
                result.Location = location;
                result.Description = description;
                
            }
            foreach(var index in personRelRemove)
                result.Person.Remove(index);
            foreach (var index in categoryRelRemove)
                result.Categories.Remove(index);

            foreach (var index in categories)
            {
                Categories cat;
                if (!isInCategories(index))
                {
                    cat = new Categories
                    {
                        CategoryName = index
                    };
                }
                else
                    cat = dbcontext.CategoriesSet.FirstOrDefault(obj => obj.CategoryName == index);
                
                result.Categories.Add(cat);
                cat.PicTable.Add(result);

            }

            foreach (var namePers in peoples)
            {
                Person pers;
                if (!existPerson(namePers))
                {
                    pers = new Person
                    {
                        FirstName = namePers,
                    };
 
                }
                else
                    pers = dbcontext.PersonSet.FirstOrDefault(obj => obj.FirstName == namePers);
                result.Person.Add(pers);
                pers.PicTable.Add(result);
            }

            dbcontext.SaveChanges();
        }

        public void RemoveEntry(int ImageIndex)
        {
            PicTable EntryToRemove = dbcontext.PicTableSet.Where(obj => obj.ID_IMG == ImageIndex).Include(p=> p.Categories).Include(p=> p.Person).FirstOrDefault();
            //Categories CatRemove = dbcontext.CategoriesSet.Where(obj => obj.PicTable == EntryToRemove).FirstOrDefault();
            dbcontext.PicTableSet.Remove(EntryToRemove);
  
            dbcontext.SaveChanges();
        }

        public List<PicTable> getDataFiltered(string filterString, string text)
        {
            if (filterString == "Nume")
                return dbcontext.PicTableSet.Where(obj => obj.Name_img == text).ToList();
            if (filterString == "Location")
                return dbcontext.PicTableSet.Where(obj => obj.Location == text).ToList();
            if (filterString == "Path")
                return dbcontext.PicTableSet.Where(obj => obj.Path == text).ToList();
            if (filterString == "Descriere")
                return dbcontext.PicTableSet.Where(obj => obj.Description == text).ToList();
            if (filterString == "Person")
            
                return (from pic in dbcontext.PicTableSet
                        where pic.Person.Any(p => p.FirstName == text)
                        select pic).ToList();
            
                //return dbcontext.PicTableSet.Include(p=> p.Person).Where(o => o.Person.Where(p=>p.FirstName == text) ).ToList();
            if (filterString == "Category")
                return (from pic in dbcontext.PicTableSet
                        where pic.Categories.Any(c => c.CategoryName== text)
                        select pic).ToList();


            return new List<PicTable>();
        }
    }
}
