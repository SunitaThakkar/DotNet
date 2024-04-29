using System;

namespace InterFace
{
    public interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }
    public interface IBinaryFile
    {
        void OpeenBinaryFile();
        void ReadFile();
    }

    class FileInfo : IFile , IBinaryFile
    {
         void IFile.ReadFile() 
        {
            Console.WriteLine("Reading File");
        }

        void IFile.WriteFile(string text)
        {
            Console.WriteLine("Writting To File");
        }

        void IBinaryFile.OpeenBinaryFile()
        {
            Console.WriteLine("Opening Binary File");
        }
        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Reading Binary File");
        }
        public void Search(string text)
        {
            Console.WriteLine("Searching File");
        }
    }
    public class Program
    {
        public  static void Main(string[] args)
        {
            IFile file = new FileInfo();
            FileInfo file1 = new FileInfo();
            IBinaryFile binaryFile = new FileInfo();

            file.ReadFile();
            file.WriteFile("Content");

            file1.Search("Text to be Search");

            binaryFile.OpeenBinaryFile();
            binaryFile.ReadFile();
        }
    }
}