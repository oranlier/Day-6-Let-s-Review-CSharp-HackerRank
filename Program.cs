using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. 
        //Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        string[] strDizi = new string[n];
            for (int i = 0; i < n; i++)
            {
                strDizi[i] = Console.ReadLine();
            }
        
        for (int i = 0; i < n; i++)
        {
            int m = strDizi[i].Length;
            char[] chrs = strDizi[i].ToCharArray();
            int ii=0;
            string tekKarakterler="";
            string ciftKarakterler="";

            foreach (char chr in chrs)
            {
                if (ii % 2==0){
                    ciftKarakterler +=chr;
                }
                else{
                    tekKarakterler +=chr;
                }
                ii+=1;
            }
            Console.WriteLine(tekKarakterler + " " + ciftKarakterler);
        }
    }
}

