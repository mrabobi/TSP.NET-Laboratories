
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestPerson();
            Console.ReadKey();
        }
        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                string fname, lname, mname, pnumber;
                Console.Write("Enter first name: ");
                fname = Console.ReadLine();

                Console.Write("Enter last name: ");
                lname = Console.ReadLine();

                Console.Write("Enter midle name: ");
                mname = Console.ReadLine();

                Console.Write("Enter telephon number: ");
                pnumber = Console.ReadLine();

                Person p = new Person()
                {   
                    
                    FirstName = fname,
                    LastName = lname,
                    MidleName = mname,
                    TelephonNumber = pnumber
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }

        static void TesTOneToMany()
        {
            Console.WriteLine("One to many association");
            using (Model2Container context =
           new Model2Container())
            {
                Customer c = new Customer()
                {
                    Name = "Customer 1",
                    City = "Iasi"
                };
                Order o1 = new Order()
                {
                    TotalValue = 200,
                    Date = DateTime.Now,
                    Customer = c
                };
                Order o2 = new Order()
                {
                    TotalValue = 300,
                    Date = DateTime.Now,
                    Customer = c
                };
                
                context.CustomerSet.Add(c);
                context.OrderSet.Add(o1);
                context.OrderSet.Add(o2);
                context.SaveChanges();
                var items = context.CustomerSet;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                   x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Order)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                       ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }

        public class MusicService
        {
            private readonly Model3Container context;
            public MusicService(Model3Container context)
            {
                this.context = context;
            }

            public void AddArtist(Artist a)
            {
                context.ArtistSet.Add(a);
                context.SaveChanges();
            }

            public void AddAlbum(Album a)
            {
                context.AlbumSet.Add(a);
                context.SaveChanges();
            }

            public Boolean BindAlbumAndArtist(int AlbumID, int ArtistID)
            {
                var artist = context.ArtistSet.FirstOrDefault(a => a.ArtistId == ArtistID);
                var album = context.AlbumSet.FirstOrDefault(a => a.AlbumId == AlbumID);
                if (artist != null && album != null)
                {
                    artist.Album.Add(album);
                    album.Artist.Add(artist);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static void ManageMusicData()
        {
            MusicService service = new MusicService(new Model3Container());
            String response;
            String option;
            Console.WriteLine("Options:");
            Console.WriteLine("Add Artist");
            Console.WriteLine("Add Album");
            Console.WriteLine("Add Relationship");

            while (true)
            {
                Console.Write("Continue?[Y\\N]");
                response = Console.ReadLine();
                if (response != "Y")
                    break;
                Console.Write("Pick an option:");
                option = Console.ReadLine();
                if (option == "Add Artist")
                {
                    String first;
                    String last;
                    Console.Write("First Name:");
                    first = Console.ReadLine();
                    Console.Write("Last Name:");
                    last = Console.ReadLine();
                    Artist a = new Artist() { FirstName = first, LastName = last };
                    service.AddArtist(a);
                }
                else if (option == "Add Album")
                {
                    String name;
                    Console.Write("Album Name:");
                    name = Console.ReadLine();
                    Album a = new Album() { AlbumName = name };
                    service.AddAlbum(a);

                }
                else if (option == "Add Relationship")
                {
                    int artistID;
                    int albumID;
                    Console.Write("Artist ID:");
                    artistID = Int32.Parse(Console.ReadLine());
                    Console.Write("Album ID:");
                    albumID = Int32.Parse(Console.ReadLine());
                    if (!service.BindAlbumAndArtist(albumID, artistID))
                    {
                        Console.WriteLine("Invalid Album or Artist ID");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Option");
                }
            }
        }
    }
}
