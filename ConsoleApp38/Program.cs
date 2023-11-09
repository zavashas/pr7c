using ConsoleApp38;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

internal class Program
{
    public static void Main()
    {
        DriveInfo[] disks = DriveInfo.GetDrives();
        foreach (DriveInfo disk in disks)
        {
            string namedisk = disk.Name;
            long totalsize = disk.TotalSize / (1024 * 1024 * 1024);
            long freespace = disk.AvailableFreeSpace / (1024 * 1024 * 1024);
            Console.WriteLine("  " + "Диск " + namedisk + freespace + " ГБ свободно" + " из " + totalsize + " ГБ");
        }
        Console.WriteLine("------------------------------------");
        Console.WriteLine("  Создать файл\n  Создать папку\n  Удалить файл\n  Удалить папку");


        int pos = Menu.Show(0, 6);

        if (pos == 2)
        {
            Main();
        }
        if (pos == 3)
        {
            Create_DeleteFileorDirectory.CreateFile();
        }
        if (pos == 4)
        {
            Create_DeleteFileorDirectory.CreateDirectory();
        }
        if (pos == 5)
        {
            Create_DeleteFileorDirectory.DeleteFile();
        }
        if (pos == 6)
        {
            Create_DeleteFileorDirectory.DeleteDirectory();
        }
        else
        {
            ShowDirectoriesandFiles(disks[pos].Name);
        }
        Console.Clear();
    }
    public static void ShowDirectoriesandFiles(string path)
    {
        string[] directories = Directory.GetDirectories(path);
        string[] files = Directory.GetFiles(path);
        int inf = 0;
        try
        {
            Console.Clear();
            foreach (string papka in directories)
            {
                DateTime date = Directory.GetCreationTime(papka);
                Console.WriteLine("  " + papka.PadRight(50) + " |  Дата создания: " + date);
            }
            foreach (string file in files)
            {
                DateTime date = File.GetCreationTime(file);
                string extension = Path.GetExtension(file);
                Console.WriteLine("  " + file.PadRight(50) + " |  Дата создания: " + date + "  |  Формат:" + extension);
            }
            int pos = Menu2.Show(directories.Length + files.Length);

            inf = pos;
            ShowDirectoriesandFiles(directories[pos]);
        }
        catch (IndexOutOfRangeException)
        {
            try
            {
                OpenFile(files[inf]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("Ошибка открытия файла");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.Clear();
            Console.WriteLine("Ошибка: доступ запрещен");
            Main();
        }
    }
    private static void OpenFile(string pathFile)
    {
        Process.Start(new ProcessStartInfo { FileName = pathFile, UseShellExecute = true });
        Console.Clear();
        Main();
    }
}


