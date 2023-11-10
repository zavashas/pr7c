using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public static class Create_DeleteFileorDirectory
    {

        public static void CreateFile()
        {
            ConsoleKeyInfo key;

            Console.Write("Введите путь и имя файла: ");
            string path = Console.ReadLine();
            File.Create(path);
            Console.WriteLine("Файл успешно создан");
            Console.WriteLine("Нажмите Escape");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Program.Main();
            }
        }

        public static void CreateDirectory()
        {
            ConsoleKeyInfo key;
            Console.Write("Введите путь и имя папки: ");
            string path = Console.ReadLine();
            Directory.CreateDirectory(path);
            Console.WriteLine("Папка успешно создана");
            Console.WriteLine("Нажмите Escape");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Program.Main();
            }
        }

        public static void DeleteFile()
        {
            ConsoleKeyInfo key;
            Console.Write("Введите путь и имя файла: ");
            string path = Console.ReadLine();
            File.Delete(path);
            Console.WriteLine("Файл успешно удален");
            Console.WriteLine("Нажмите Escape");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Program.Main();
            }
        }

        public static void DeleteDirectory()
        {
            ConsoleKeyInfo key;
            Console.Write("Введите путь и имя папки: ");
            string path = Console.ReadLine();
            Directory.Delete(path, true);
            Console.WriteLine("Папка успешно удалена");
            Console.WriteLine("Нажмите Escape");
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Program.Main();
            }
        }
    }
}
