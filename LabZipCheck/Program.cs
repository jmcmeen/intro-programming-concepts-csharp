using System.IO;
using System.IO.Compression;

namespace LabZipCheck
{
    internal class Program
    {
        static int Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Must specify a path to a .zip file or directory of zip files.");
                return -1;
            }
            else if(args[0].Contains(".zip"))
            {
                //this is probably a path to a .zip file
                string filepath = args[0];

                if (!File.Exists(filepath))
                {
                    Console.WriteLine($"{filepath} does not exist. exiting.");
                    return -1;
                }

                if (IsValidLabZipFormat(filepath))
                {
                    Console.WriteLine($"{Path.GetFileName(filepath)} - PASSED");
                }
                else
                {
                    Console.WriteLine($"{Path.GetFileName(filepath)} - FAILED");
                }
            }

            return 0;
        }

        public static bool IsValidLabZipFormat(string labZipFile)
        {
            bool returnValue = true;

            string temp_path = "temp";

            //open the zip file using System.IO.Compression
            using (ZipArchive archive = ZipFile.Open(labZipFile, ZipArchiveMode.Read))
            {
                archive.ExtractToDirectory(temp_path);

                returnValue = returnValue && PathContainsSingleLabDirectory(temp_path);

                temp_path = GetFirstLabDirectory(temp_path);

                returnValue = returnValue && PathContainsProjectAndCodeFiles(temp_path);
            }

            Directory.Delete(temp_path, true);

            return returnValue;
        }

        public static bool PathContainsSingleLabDirectory(string path)
        {
            //path doesn't exist
            if (!Path.Exists(path)) { return false; }

            #if DEBUG
                        Console.WriteLine("Unzip path exists");
            #endif

            //more or less than one lab directory
            if (Directory.GetDirectories(path).Where(x=>x.ToLower().Contains("lab")).ToArray().Length != 1) { return false; }

            #if DEBUG
                        Console.WriteLine("Only one lab file");
            #endif

            //contains directories other than one lab directory
            if (Directory.GetDirectories(path).Where(x => !x.ToLower().Contains("lab")).ToArray().Length != 0) { return false; }

            #if DEBUG
                        Console.WriteLine("No other directories");
            #endif

            //path contains files
            if ( Directory.GetFiles(path).Length != 0) { return false; }

            #if DEBUG
                        Console.WriteLine("No other files");
            #endif

            return true;
        }

        public static bool PathContainsProjectAndCodeFiles(string path)
        {
            //path doesn't exist
            if (!Path.Exists(path)) { return false; }

            #if DEBUG
                        Console.WriteLine("Project path exists");
            #endif

            //path has more or less than one .csproj file
            if (Directory.GetFiles(path).Where(x=>x.ToLower().Contains("csproj")).ToArray().Length == 1) { return false; }

            #if DEBUG
                        Console.WriteLine("one .csproj file exists");
            #endif

            //path does not contain any number of .cs files
            if (Directory.GetFiles(path).Where(x => x.ToLower().Contains("cs")).ToArray().Length == 0) { return false; }

            #if DEBUG
                        Console.WriteLine(".cs files exist");
            #endif

            return true;
        }

        public static string GetFirstLabDirectory(string path)
        {
            return Directory.GetDirectories(path).Where(x => x.ToLower().Contains("lab")).First();
        }
    }
}