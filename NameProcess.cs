using System;

namespace NameSongs
{
	/// <summary>
	/// Organize my mp3 files fro writing them ont mp3 - disks.
	/// Also short demo of using separate object 
	/// for name generation and renaming
	/// 
	/// Serge Klokov, May 11 2004 - April 17 2015
	/// </summary>
	class NameProcess
	{

		[STAThread]
		static void Main(string[] args)
		{
            Console.WriteLine("Please use parameter - short name which will be part of each .mp3 file.");
		    Console.WriteLine();

			var namesGenerator = new NamesGenerator
			{
			    InitialName = args.Length >= 1 ? args[0] : "noname"
			};

		    namesGenerator.NamingStart();

		    Console.WriteLine();
			Console.WriteLine("Done. Press any key to exit...");
		    Console.ReadKey();
		}

	}
}
