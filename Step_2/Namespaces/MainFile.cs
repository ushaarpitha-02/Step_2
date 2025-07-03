using Allfiles;
using EXCELfile;
using PPTfile;
using DOCfile;
using System;
namespace MainFile
{ 
    class MainFile
    {
        public static void Main()
        {
            Allfiles.DOCfiles files100 = new Allfiles.DOCfiles();
            Console.WriteLine(files100.Filename);


            Allfiles.EXCELfiles files200=new Allfiles.EXCELfiles();
            Console.WriteLine(files200.Filename);

            Allfiles.PPTfiles files300=new Allfiles.PPTfiles();
            Console.WriteLine(files300.Filename);

            //File1 file=new File1();
            //Console.WriteLine(file.Filename);

            EXCELfile.File1 file1 = new EXCELfile.File1();
            Console.WriteLine(file1.Filename);
            EXCELfile.File2 file2 = new EXCELfile.File2();
            Console.WriteLine(file2.Filename);
            EXCELfile.File3 file3 = new EXCELfile.File3();
            Console.WriteLine(file3.Filename);

            DOCfile.File1 file11 = new DOCfile.File1();
            Console.WriteLine(file11.Filename);
            DOCfile.File2 file21 = new DOCfile.File2();
            Console.WriteLine(file21.Filename);
            DOCfile.File3 file31 = new DOCfile.File3();
            Console.WriteLine(file31.Filename);

            PPTfile.File1 file12 = new PPTfile.File1();
            Console.WriteLine(file12.Filename);
            PPTfile.File2 file22 = new PPTfile.File2();
            Console.WriteLine(file22.Filename);
            PPTfile.File3 file23 = new PPTfile.File3();
            Console.WriteLine(file23.Filename);




        }
    }
}