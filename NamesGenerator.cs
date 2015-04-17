using System;
using System.IO;

namespace NameSongs
{
	/// <summary>
	/// Generate names for *.mp3 files
	/// </summary>
	public class NamesGenerator
	{

	    public string InitialName { get; set; }

        //will be used to convert subfolder to letter in file name
        public int DiscNumber { get; set; }
        
	    public virtual void NamingStart()
		{
			DirectoryInfo rootDir = new DirectoryInfo(Environment.CurrentDirectory);
	        DiscNumber = 1; 

            //get list of subfolders
	        var directories = rootDir.GetDirectories();
	        foreach (var directoryInfo in directories)
	        {
                FileInfo[] filesInDir = directoryInfo.GetFiles("*.mp3");

                int i = 1;

                Console.WriteLine();
                Console.WriteLine("copying from sub folder:" + Environment.NewLine + directoryInfo.FullName);

                foreach (FileInfo file in filesInDir)
                {
                    string shortName = InitialName + " D" + DiscNumber + " T" + i.ToString("00") + file.Extension;
                    string fullName = rootDir + "\\" + shortName; 
                    Console.WriteLine(shortName);
                    file.CopyTo(fullName, true);
                    i++;
                }

	            DiscNumber++;
	        }

            Console.WriteLine();
            Console.WriteLine("Files copied to the folder: " + Environment.NewLine + rootDir.FullName);

        }
	}
}
