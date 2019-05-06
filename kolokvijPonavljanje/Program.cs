using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kolokvijPonavljanje
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Upisite putanju datoteke cije informacije zelite \n" +
            "ili upisite 'Detaljnije' da saznate informacije o trenutnom direktoriju u \n" +
            "kojem se trenutacno nalazite.");
            string rezultat = Console.ReadLine();
            Console.WriteLine("\n");
            if (rezultat == "Detaljnije")
            {
                string driveLetter = Path.GetPathRoot(Environment.CurrentDirectory);
                Console.WriteLine("Disk: " + driveLetter + "\n");

                string currentDirectory;
                currentDirectory = Directory.GetCurrentDirectory();
                string[] directoryContainsDirectories;
                string[] directoryContainsFiles;
                directoryContainsDirectories = Directory.GetDirectories(currentDirectory);
                directoryContainsFiles = Directory.GetFiles(currentDirectory);
                Console.WriteLine("\n");
                if (directoryContainsDirectories.Length == 0)
                {
                    Console.WriteLine("U ovoj datoteci se ne nalazi vise poddatteka.");
                }
                else
                {
                    Console.WriteLine("Popis poddatoteka u datoteci:\n");
                    foreach (string data in directoryContainsDirectories)
                    {
                        Console.Write(data);
                        Console.WriteLine("\n");
                    }
                }
                Console.WriteLine("\n");
                if (directoryContainsFiles.Length == 0)
                {
                    Console.WriteLine("U ovoj datoteci nema nikakvih file-ova.");
                }
                else
                {
                    Console.WriteLine("Popis file-ova u ovoj datoteci:\n");
                    foreach (string data in directoryContainsFiles)
                    {
                        Console.WriteLine(data);
                        Console.WriteLine("\n");
                    }
                }
                Console.WriteLine("\n");

                DriveInfo[] driveInfos = DriveInfo.GetDrives();
                foreach (DriveInfo d in driveInfos)
                {
                    if (d.Name == driveLetter)
                    {
                        Console.WriteLine("Preostala velicina diska na kojem se nalazi trenutni direktorij: " + (((d.TotalFreeSpace / 1024) / 1024) / 1024) + "GB");
                    }
                }
            }
            else
            {
                string[] directoryContainsDirectories;
                string[] directoryContainsFiles;
                string putanjaDatoteke = rezultat;
                string driveLetter = Path.GetPathRoot(putanjaDatoteke);
                Console.WriteLine("Disk : " + driveLetter + "\n");

                directoryContainsDirectories = Directory.GetDirectories(putanjaDatoteke);
                directoryContainsFiles = Directory.GetFiles(putanjaDatoteke);
                Console.WriteLine("\n");
                if (directoryContainsDirectories.Length == 0)
                {
                    Console.WriteLine("U ovoj datoteci se ne nalazi vise poddatoteka.");
                }
                else
                {
                    Console.WriteLine("Popis poddatoteka u datoteci:\n");
                    foreach (string data in directoryContainsDirectories)
                    {
                        Console.Write(data);
                        Console.WriteLine("\n");
                    }
                }
                Console.WriteLine("\n");
                if (directoryContainsFiles.Length == 0)
                {
                    Console.WriteLine("U ovoj datoteci nema nikakvih file-ova.");
                }
                else
                {
                    Console.WriteLine("Popis file-ova u datoteci:\n");
                    foreach (string data in directoryContainsFiles)
                    {
                        Console.WriteLine(data);
                        Console.WriteLine("\n");
                    }
                }
                Console.WriteLine("\n");

                DriveInfo[] driveInfos = DriveInfo.GetDrives();
                foreach (DriveInfo d in driveInfos)
                {
                    if (d.Name == driveLetter)
                    {
                        Console.WriteLine("Preostala velicina diska na kojem se nalazi trenutni direktorij: " + (((d.TotalFreeSpace / 1024) / 1024) / 1024) + "GB");
                    }
                }
            }
        }
    }
}
