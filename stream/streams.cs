using System;
using System.IO;

class MainClass {
    static void Main() {
        string path = @"/home/thesuess/Downloads/install60.fs";

        byte[] buff = File.ReadAllBytes(path);

        using (FileStream fs = File.Open(path, FileMode.Open))
        {
            byte[] b = new byte[1024];
            fs.Read(b,0,10);
            foreach(var c in b){
                Console.Write(c);
            }
        }

        Stream fs = File.Open("test",FileMode.Create);

        GZipStream c = new GZipStream(fs,CompressionMode.Compress);

        StreamWriter s = new StreamWriter(c);

        s.WriteLine("Hey");

        s.Close();

        Console.ReadLine();
    }
}
