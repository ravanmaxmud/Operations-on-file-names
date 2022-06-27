using System;

namespace extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("English");
            Console.WriteLine("Russian");
            Console.WriteLine("Turkish");
            Console.WriteLine();

            FileVlaidator fileVlaidator = new FileVlaidator(".jpg", ".pdf", ".docx");
            Console.Write("Choose The Language :");
            Console.WriteLine(fileVlaidator.programLanguage(Console.ReadLine()));

            Console.WriteLine("========================================================================");

            Console.Write("Enter your 'File'-Name and 'Extension' :");
            Console.WriteLine(fileVlaidator.ReturnExtension(Console.ReadLine()));
            Console.WriteLine("=========================================================================");
            Console.WriteLine("Enter File Full Name");
            fileVlaidator.CheckExtension(Console.ReadLine());
        }
    }
    class FileVlaidator
    {
        private string[] _fileExtension;


        public FileVlaidator(params string[] extension)
        {
            _fileExtension = extension;
        }


        public string programLanguage(string language1)
        {
            switch (language1)
            {
                case "English":
                    Console.WriteLine($"These are the supported file types");
                    break;

                case "Russian":
                    Console.WriteLine($"Возможные типы файлов");
                    break;

                case "Turkish":
                    Console.WriteLine($"Bunlar desteklenen dosya türleridir");
                    break;

                default:
                    Console.WriteLine($"These are the supported file types");
                    break;
            }
            return ".jpg  .pdf  .docx ";
        }
        public bool ReturnExtension(string value)

        {
            string text = "";
            char dotPoint = '.';
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == dotPoint)
                {
                    for (int z = i; z < value.Length; z++)
                    {
                        text += value[z];
                    }
                }
            }
            for (int i = 0; i < _fileExtension.Length; i++)
            {
                if (_fileExtension[i] == text)
                {
                    Console.WriteLine("Saved");
                    return true;
                }
            }
            Console.WriteLine("This Extension Not Found Sorry For That.");
            return false;
        }
        public void CheckExtension(string value)
        {
            string text = "";
            char dotPoint = '.';
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == dotPoint)
                {
                    for (int z = i; z < value.Length; z++)
                    {
                        text += value[z];
                    }
                }
            }
            Console.WriteLine(text);
        }
    }
}

