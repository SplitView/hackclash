using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unknown.Model
{
    public class Rent
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Information { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
    public class RentManager
    {
        public static void Getroom(string category, ObservableCollection<Rent> Rooms)
        {
            var allItems = getRooms();

            var filteredRooms = allItems.Where(p => p.Category == category).ToList();

            Rooms.Clear();

            filteredRooms.ForEach(p => Rooms.Add(p));
        }
        public static void Getroom(string category, string location, string price,ObservableCollection<Rent> Rooms)
        {

            var allItems = getRooms();
            var filteredRooms = allItems.Where(p => p.Location == location && p.Category == category && p.Price == price).ToList();
            if (location == "Location")
            {
                filteredRooms = allItems.Where(p =>p.Category == category && p.Price == price).ToList();
            }
            else if(price=="Price Limit")
            {
                filteredRooms = allItems.Where(p => p.Location == location && p.Category == category).ToList();
            }
            
           

            Rooms.Clear();

            filteredRooms.ForEach(p => Rooms.Add(p));
        }
        public static List<Rent> getRooms()
        {
            var items = new List<Rent>();

            items.Add(new Rent() { Id = 1, Category = "Room", Location = "Kathmandu", Contact = "9860142732",Price="1000-2000", Information = "Nunc tristique nec", Image = "Assets/room/room1.jpg" });
            items.Add(new Rent() { Id = 2, Category = "Room", Location = "Kathmandu", Contact = "9860142732", Price = "2000-3000", Information = "Nunc tristique nec", Image = "Assets/room/room2.jpg" });
            items.Add(new Rent() { Id = 3, Category = "Room", Location = "Kathmandu", Contact = "9860142732", Price = "1000-2000", Information = "Nunc tristique nec", Image = "Assets/room/room3.jpg" });
            items.Add(new Rent() { Id = 4, Category = "Room", Location = "Lalitpur", Contact = "9860142732", Price = "2000-3000", Information = "Nunc tristique nec", Image = "Assets/room/room4.jpg" });
            items.Add(new Rent() { Id = 5, Category = "Room", Location = "Lalitpur", Contact = "9860142732", Price = "1000-2000", Information = "Nunc tristique nec", Image = "Assets/room/room5.jpg" });
            items.Add(new Rent() { Id = 6, Category = "Room", Location = "Lalitpur", Contact = "9860142732", Price = "2000-3000", Information = "Nunc tristique nec", Image = "Assets/room/room6.jpg" });
            items.Add(new Rent() { Id = 7, Category = "Room", Location = "Bhaktapur", Contact = "9860142732", Price = "1000-2000", Information = "Nunc tristique nec", Image = "Assets/room/room7.jpg" });
            items.Add(new Rent() { Id = 8, Category = "Room", Location = "Bhaktapur", Contact = "9860142732", Price = "2000-3000", Information = "Nunc tristique nec", Image = "Assets/room/room8.jpg" });
            items.Add(new Rent() { Id = 9, Category = "Room", Location = "Bhaktapur", Contact = "9860142732", Price = "1000-2000", Information = "Nunc tristique nec", Image = "Assets/room/room9.jpg" });

            items.Add(new Rent() { Id = 1, Category = "Flat", Location = "Kathmandu", Contact = "9860142732", Price = "3000-4000", Information = "Nunc tristique nec", Image = "Assets/Flat/flat11.jpg" });
            items.Add(new Rent() { Id = 2, Category = "Flat", Location = "Kathmandu", Contact = "9860142732", Price = "2000-3000", Information = "Nunc tristique nec", Image = "Assets/Flat/flat2.jpg" });
            items.Add(new Rent() { Id = 3, Category = "Flat", Location = "Kathmandu", Contact = "9860142732", Price = "3000-4000", Information = "Nunc tristique nec", Image = "Assets/Flat/flat3.jpg" });
            items.Add(new Rent() { Id = 4, Category = "Flat", Location = "Lalitpur", Contact = "9860142732", Price = "2000-3000", Information = "Nunc tristique nec", Image = "Assets/Flat/flat4.jpg" });
            items.Add(new Rent() { Id = 5, Category = "Flat", Location = "Lalitpur", Contact = "9860142732", Price = "3000-4000", Information = "Nunc tristique nec", Image = "Assets/Flat/flat5.jpg" });
            items.Add(new Rent() { Id = 6, Category = "Flat", Location = "Lalitpur", Contact = "9860142732", Price = "2000-3000", Information = "Nunc tristique nec", Image = "Assets/Flat/flat6.jpg" });

            items.Add(new Rent() { Id = 1, Category = "House", Location = "Kathmandu", Contact = "9860142732", Price = "10000-20000", Information = "Nunc tristique nec", Image = "Assets/House/house1.jpg" });
            items.Add(new Rent() { Id = 2, Category = "House", Location = "Kathmandu", Contact = "9860142732", Price = "2000-3000", Information = "Nunc tristique nec", Image = "Assets/House/house2.jpg" });
            items.Add(new Rent() { Id = 3, Category = "House", Location = "Kathmandu", Contact = "9860142732", Price = "10000-20000", Information = "Nunc tristique nec", Image = "Assets/House/house3.png" });
            items.Add(new Rent() { Id = 4, Category = "House", Location = "Lalitpur", Contact = "9860142732", Price = "2000-3000", Information = "Nunc tristique nec", Image = "Assets/House/house4.jpg" });
            items.Add(new Rent() { Id = 5, Category = "House", Location = "Lalitpur", Contact = "9860142732", Price = "10000-20000", Information = "Nunc tristique nec", Image = "Assets/House/house5.jpg" });
            items.Add(new Rent() { Id = 6, Category = "House", Location = "Lalitpur", Contact = "9860142732", Price = "2000-3000", Information = "Nunc tristique nec", Image = "Assets/House/house6.jpg" });

            return items;

        }
    }
}
