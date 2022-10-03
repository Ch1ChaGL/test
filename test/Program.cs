using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {

        enum DayTime
        {
            morning,
            Afternoon,
            evening,
            night
        }
        struct Coords
        {
            public double x1;
            public double y1;
        }
        static void Main(string[] args)
        {
            //string[] message = new string[] { "hellow", "world", "!!!" };                         МЕТОД JOIN
            //string message2 = string.Join("_",message);
            //Console.WriteLine(message2);




            //string s1 = "Hellow";
            //string s2 = "World";    
            //int result=string.Compare(s1, s2);                                                    МЕТОД COMPARE
            //Console.WriteLine(result);




            //string s1 = "hellow world hellow";
            //string ch = "hell";                                                                      МЕТОД IndexOF
            //int test = s1.LastIndexOf(ch);
            //Console.WriteLine(test);







            //string[] files = new string[]
            //{
            //    "myapp.exe",
            //    "ccasdc.jpg",
            //    "sdfsdf.exe",
            //    "wfwefwef.pdf",
            //    "sdffsdf.png"
            //StartsWith EndsWith
            //};                                                                                                                startswith endswith
            //for (int i = 0; i < files.Length; i++)
            //{
            //    if (files[i].EndsWith(".exe"))
            //    {
            //        Console.WriteLine(files[i]);
            //    }
            //}



            //string text = "И поэтому все так произошло";
            //string[] words=text.Split( ' ' );

            //foreach(string s in words)                                                                                    split                                
            //{
            //    Console.WriteLine(s);
            //}



            //string text = "            hellow world                    ";
            //text = text.Trim();                                                                                   trim
            //Console.WriteLine(text);
            //text = text.Trim(new char[] {'h','d'});
            //Console.WriteLine(text);


            //string text = "Хороший день";
            //text = text.Substring(2);
            //Console.WriteLine(text);                                                                                  Substring
            //text = text.Substring(3,text.Length-5);
            //Console.WriteLine(text);



            //string text = "Хороший день";
            //string text2 = ", замечательный ";                                                                            Insert
            //text = text.Insert(8, text2);
            //Console.WriteLine(text);


            //string text = "Хороший день";
            //text=text.Remove(text.Length - 1);                                                                    remove
            //Console.WriteLine(text);
            //text=text.Remove(0,3);
            //Console.WriteLine(text);



            DayTime dayTime = DayTime.morning;
            //if (dayTime == DayTime.morning)
            //{
            //    Console.WriteLine("Доброе утро");
            //}
            //switch (dayTime)
            //{                                                                                                           ENUM Перечисление
            //    case DayTime.morning:
            //        Console.WriteLine("Доброе утро!!!!");
            //            break;
            //    case DayTime.evening:
            //        Console.WriteLine("Добрый вечер");
            //            break;  
            //}
            Coords p;
            p.x1 = 3.0;
            p.y1 = 4.3;
            Coords tom = new Coords { x1 = 3.3, y1 = 4.0 } ;
            Console.WriteLine(tom.x1 +" "+" "+ tom.y1);
            List<int> people=new List<int>(){ 1,2,3};
            int firstPerson = people[0];
            Console.WriteLine(firstPerson);
            Console.WriteLine(people.Count);
            people.Add(4);
            people.AddRange(new[] {5,6});
            people.Insert(0,11);


            Console.ReadKey();
        }



    }
}
