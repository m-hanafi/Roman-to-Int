// See https://aka.ms/new-console-template for more information


namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter roman number:");
            string s = Console.ReadLine().ToUpper();

            int res = RomanToInt(s);
            Console.WriteLine(res);

        }

        static int RomanToInt(string s)
        {
            Dictionary<string,int> dict = new Dictionary<string, int>()
            {
                {"I",1},
                {"V",5},
                {"X",10},
                {"L",50},
                {"C",100},
                {"D",500},
                {"M",1000},
                {"IV",4},
                {"IX",9},
                {"XL",40},
                {"XC",90},
                {"CD",400},
                {"CM",900}
            };


            int sum =0;
            int val=0;
            string str;

            while(s.Length>0)
            {
                string strRom_1 = s[0].ToString();
                string strRom_2 = "";
                if (s.Length>1)
                {
                    strRom_2 = s[1].ToString();
                }
                
                if ((strRom_1 == "I" && (strRom_2 == "V" || strRom_2 == "X")) || (strRom_1 == "X" && (strRom_2 == "L" || strRom_2 == "C")) || (strRom_1 == "C" && (strRom_2 == "D" || strRom_2 == "M")))
                {
                    str = s.Substring(0,2);
                    s = s.Remove(0,2);
                }
                else{
                    str = s.Substring(0,1);
                    s = s.Remove(0,1);                    
                }

                dict.TryGetValue(str, out val);

                sum += val;
            }
            return sum;            
        } 

        
    }
    
}
