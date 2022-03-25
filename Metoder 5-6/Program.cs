using System;
using System.IO;

namespace Metoder_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            CreateFile();

            FileStreamRead();
            FileStreamWrite();


            Console.ReadKey();

        }

        public static void CreateFile()
        {
            File.WriteAllText(@".\Movies.txt", "Star Wars\nThe Empire Strikes Back\nReturn Of The Jedi");
            File.WriteAllText(@".\Actors.txt", "");
        }

        public static void FileStreamRead()
        {
            FileStream file = new FileStream(@".\Movies.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }

        }

        public static void FileStreamWrite()
        {
            FileStream file = new FileStream(@".\Actors.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file);

            string[] Actors = { "Mark Hamill", "Harrison Ford", "Carrie Fisher" };

            foreach (string i in Actors)
            {
                writer.WriteLine(i);
                
            }
            writer.Close();
        }
           
    }

}

