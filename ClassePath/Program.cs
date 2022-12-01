namespace ClassePath
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"c:\testes\minhapasta\arquivo1.txt";
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(caminho));
            Console.WriteLine("GetFileName: " + Path.GetFileName(caminho));
            Console.WriteLine("GetExtension: " + Path.GetExtension(caminho));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(caminho));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(caminho));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}


