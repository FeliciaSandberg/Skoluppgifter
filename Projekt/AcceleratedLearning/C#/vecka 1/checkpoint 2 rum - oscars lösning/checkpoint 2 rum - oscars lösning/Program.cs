using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkpoint_2_rum___oscars_lösning
{
    class Room
    {
        public int Size { get; set; }
        public string RoomName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange namn på rum: ");
            string input = Console.ReadLine();

            string[] RoomsArray = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            var allRoms = new List<Room>();

            foreach (var roomstring in RoomsArray)
            {
                var room = new Room();
                string[] pair = roomstring.Trim().Split(' ');
                string NameOfTheRoom = pair[0];
                string SizeOfTheRoom = pair[1].Remove(pair[1].Length - 2);
                //string SizeOfTheRoom = pair[1].Replace("m2", "");

                room.RoomName = NameOfTheRoom;
                room.Size = int.Parse(SizeOfTheRoom);
                allRoms.Add(room);
            }

            int i = 1;
            foreach (var room in allRoms)
            {
                Console.WriteLine($"* Rumnamn {i}: {room.RoomName}");
                i++;
            }

            //lösning 1 för att hitta vilket rum som är störst 
            if (allRoms.Count > 0)
            {
                string LargestRoomName = "";
                int LargestRoomSize = 0;

                foreach (var room in allRoms)
                {
                    if (room.Size > LargestRoomSize)
                    {
                        LargestRoomName = room.RoomName;
                        LargestRoomSize = room.Size;
                    }
                   
                }
                Header("lösning 1");
                Console.WriteLine($"Det största rummet är {LargestRoomName} på {LargestRoomSize}M2");
            }

            //lösning 2 att hitta största rummet
            Room LargestRoom = allRoms[0];
            foreach (var room in allRoms)
            {
                if (room.Size > LargestRoom.Size)
                {
                    LargestRoom.Size = room.Size;
                    LargestRoom.RoomName = room.RoomName;
                    
                }
            }
            Header("lösning 2");
            Console.WriteLine($"Det största rummet är {LargestRoom.RoomName} på {LargestRoom.Size}M2");

            //lösning 3 - om man vill ha det minsta är det "orderBy"
           var LargestRoom3 = allRoms.OrderByDescending(x => x.Size).First();
            Header("lösning 3");
            Console.WriteLine($"Det största rummet är {LargestRoom3.RoomName} på {LargestRoom3.Size}M2");

            Console.ReadKey();
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n {v.ToUpper()} \n");
            Console.ResetColor();
        }
    }
}
