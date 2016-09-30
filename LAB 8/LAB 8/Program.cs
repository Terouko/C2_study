using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = " WindowsFormsApplication ";
            int i = text.LastIndexOf("o");//с конца
            int l = text.IndexOf("o");//с начала 

            string newtext = text.Trim();

            string[] Pieces = text.Split('F');
            foreach (string Piece in Pieces)
                Console.WriteLine(Piece);

            StringBuilder tx = new StringBuilder(text, text.Length + newtext.Length);
            tx.AppendFormat(newtext);
            Console.WriteLine("Склееная строка: " + tx);

            Console.WriteLine(Console.ReadLine().Reverse().ToArray());
        }
    }
}
