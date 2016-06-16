using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace labeledfile
{
    class Program
    {
        static void Main(string[] args)
        {
            //2labels
            string path = Directory.GetCurrentDirectory();
            if (args.Count() != 6)
            {
                System.Console.WriteLine("syntax error: program <mappingfile> <treefile> <label1file> <label2file> <label3file> <label4file>");
                return;
            }
            string filenamein1 = string.Format(@"{0}\{1}", path, args[0]); // mapping file
            string filenamein2 = string.Format(@"{0}\{1}", path, args[1]); // treefile after parser
            string fileout1 = string.Format(@"{0}\{1}", path, args[2]); // fileoutput1
            string fileout2 = string.Format(@"{0}\{1}", path, args[3]); // fileoutput2
            string fileout3 = string.Format(@"{0}\{1}", path, args[4]); // fileoutput1
            string fileout4 = string.Format(@"{0}\{1}", path, args[5]); // fileoutput2

            process4labels(filenamein1, filenamein2, fileout1, fileout2, fileout3, fileout4);


        }
        public static void process4labels(string mappingfile, string treefile, string label1file, string label2file, string label3file, string label4file)
        {
            System.IO.StreamReader mapfile = new System.IO.StreamReader(mappingfile);
            System.IO.StreamReader tree_file = new System.IO.StreamReader(treefile);
            System.IO.StreamWriter label1 = new System.IO.StreamWriter(label1file);//output
            System.IO.StreamWriter label2 = new System.IO.StreamWriter(label2file);//outputmap
            System.IO.StreamWriter label3 = new System.IO.StreamWriter(label3file);//output
            System.IO.StreamWriter label4 = new System.IO.StreamWriter(label4file);//outputmap
            int numl1 = 0, numl2 = 0, numl3 = 0, numl4 = 0;
            while (!mapfile.EndOfStream)
            {
                string mapline = mapfile.ReadLine();
                String[] temp = Regex.Split(mapline, "\t\t");
                int label = Int32.Parse(temp[2]);
                int numline = Int32.Parse(temp[3]);
               
                if (label == 1)
                {
                    for (int i = 0; i < numline; i++)
                    {
                        string write = tree_file.ReadLine();
                        label1.WriteLine(write);
                    }
                    numl1 += numline;
                }
                else
                    if (label == 2)
                    {
                        for (int i = 0; i < numline; i++)
                        {
                            string write = tree_file.ReadLine();
                            label2.WriteLine(write);
                        }
                        numl2 += numline;
                    }
                    else
                        if (label == 3)
                        {
                            for (int i = 0; i < numline; i++)
                            {
                                string write = tree_file.ReadLine();
                                label3.WriteLine(write);
                            }
                            numl3 += numline;
                        }
                        else
                        {
                                for (int i = 0; i < numline; i++)
                                {
                                    string write = tree_file.ReadLine();
                                    label4.WriteLine(write);
                                }
                                numl4 += numline;
                        }
            }
            System.Console.WriteLine("label1: " + numl1);
            System.Console.WriteLine("label2: " + numl2);
            System.Console.WriteLine("label3: " + numl3);
            System.Console.WriteLine("label4: " + numl4);
            System.Console.WriteLine("all: " + (numl1+numl2+numl3+numl4));
            mapfile.Close();
            tree_file.Close();
            label1.Close();
            label2.Close();
            label3.Close();
            label4.Close();
        }
        public static void process(string mappingfile, string treefile, string label1file, string label2file)
        {
            System.IO.StreamReader mapfile = new System.IO.StreamReader(mappingfile);
            System.IO.StreamReader tree_file = new System.IO.StreamReader(treefile);
            System.IO.StreamWriter label1 = new System.IO.StreamWriter(label1file);//output
            System.IO.StreamWriter label2 = new System.IO.StreamWriter(label2file);//outputmap
            while (!mapfile.EndOfStream)
            {
                string mapline = mapfile.ReadLine();
                String[] temp = Regex.Split(mapline, "\t\t");
                int label = Int32.Parse(temp[2]);
                int numline = Int32.Parse(temp[3]);
                if(label==1)
                {
                    for(int i =0; i< numline; i++)
                    {
                        string write = tree_file.ReadLine();
                        label1.WriteLine(write);
                    }
                }
                else
                {
                    for (int i = 0; i < numline; i++)
                    {
                        string write = tree_file.ReadLine();
                        label2.WriteLine(write);
                    }
                }
                
            }
            mapfile.Close();
            tree_file.Close();
            label1.Close();
            label2.Close();

        }
    }
}
