using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takowane_na_kod
{
    internal class Program
    {
        public const string fileName = "example.bim";
        static void Main(string[] args)
        {
            FileStream fileStream=new FileStream(fileName, FileMode.Create);
            BinaryWriter binaryWriter=new BinaryWriter(fileStream);
            for (int i = 0; i < 11; i++)
            {
                binaryWriter.Write(i);     
            }
            binaryWriter.Close();
            fileStream.Close();
            fileStream=new FileStream(fileName,FileMode.Open,FileAccess.Read);
            BinaryReader binaryReader=new BinaryReader(fileStream);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(binaryReader.ReadInt32());
            }
            binaryReader.Close();
            fileStream.Close();
        }
        

    }
}
