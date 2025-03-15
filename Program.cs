using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace lab6
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Event event1 = new Event();
			event1.EventNum = 1;
			event1.Location = "Calgary";

			Serialize(event1);

			Event deserializedEvent1 = Deserialize();
			Console.WriteLine(deserializedEvent1.EventNum);
			Console.WriteLine(deserializedEvent1.Location);

			ReadFromFile();
		}
		public static void Serialize(Event e1)
		{
			string jsonString = JsonSerializer.Serialize(e1);
			File.WriteAllText("..\\..\\..\\event.txt", jsonString);
		}
		public static Event Deserialize()
		{
			string jsonString = File.ReadAllText("..\\..\\..\\event.txt");
			Event e1 = JsonSerializer.Deserialize<Event>(jsonString);
			return e1;
		}
		public static void ReadFromFile()
		{
			using (StreamWriter eventFile = new StreamWriter("..\\..\\..\\event.txt"))
			{
				eventFile.WriteLine("Hackathon");
			}

			using (FileStream fileStream = new FileStream("..\\..\\..\\event.txt", FileMode.Open, FileAccess.Read))
			{
				fileStream.Seek(0, SeekOrigin.Begin);
				int first = fileStream.ReadByte();

				fileStream.Seek(4, SeekOrigin.Begin);
				int middle = fileStream.ReadByte();

				fileStream.Seek(8, SeekOrigin.Begin);
				int last = fileStream.ReadByte();

				Console.WriteLine("The First Character is: " + (char)first);
				Console.WriteLine("The Middle Character is: " + (char)middle);
				Console.WriteLine("The Last Character is: " + (char)last);
			}
		}
	}
}
