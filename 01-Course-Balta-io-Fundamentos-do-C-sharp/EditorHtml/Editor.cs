using System;
using System.Text;

namespace EditorHtml
{
	public class Editor
	{
		public static void Show()
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Clear();
			Console.WriteLine("CREATE TEXT MODE");
			Console.WriteLine("----------------------------------------");
			Start();
		}

		public static void Start()
		{
			var file = new StringBuilder();
			do
			{
				file.Append(Console.ReadLine());
				file.Append(Environment.NewLine);
			}
			while (Console.ReadKey().Key != ConsoleKey.Escape);

			Viewer.Show(file.ToString());
		}
	}
}
