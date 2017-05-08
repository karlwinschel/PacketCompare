using PacketCompare.Classes;
using PacketCompare.FSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileStr1;
            string fileStr2;

            //testfiles
            //fileStr1 = FileToString.GetFileContents("c:/users/kwinschel/documents/visual studio 2015/Projects/PacketCompare/PacketCompare/Resources/test1.txt");
            //fileStr2 = FileToString.GetFileContents("c:/users/kwinschel/documents/visual studio 2015/Projects/PacketCompare/PacketCompare/Resources/test2.txt");

            //actual Files
            fileStr1 = FileToString.GetFileContents("c:/users/kwinschel/documents/visual studio 2015/Projects/PacketCompare/PacketCompare/Resources/130007packetsreconstructed");
            fileStr2 = FileToString.GetFileContents("c:/users/kwinschel/documents/visual studio 2015/Projects/PacketCompare/PacketCompare/Resources/842packetsreconstructed");

            ChunkedFile file1 = new ChunkedFile(fileStr1, 3);
            ChunkedFile file2 = new ChunkedFile(fileStr2, 3);

            List<Chunk> matchList = file1.compareChunkLists(file2);
            List<Chunk> reassembledMatchList = ChunkedFile.reassambleChunks(matchList);

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("c:/users/kwinschel/documents/visual studio 2015/Projects/PacketCompare/PacketCompare/Resources/result.txt"))
            {
                foreach (Chunk chunkelement in reassembledMatchList)
                {
                    file.WriteLine(chunkelement.value + " " + chunkelement.index);
                }
            }
        }
    }
}
