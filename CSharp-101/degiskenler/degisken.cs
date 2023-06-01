using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101.degiskenler
{
    class degisken
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            byte b=5;  //1 Byte
            sbyte c=5;  //1 Byte

            short s = 5;    //2 Byte
            ushort us = 5;  //2 Byte


            Int16 i16 = 2;  //2 Byte
            int i = 2;  //4 Byte
            Int32 i32 = 2;  //4 Byte
            Int64 i64 = 2;  //4 Byte

            uint ui = 2;  //4 Byte
            long l = 4;  //8 Byte
            ulong ul = 4;   //8 Byte
            
            // Reel Sayılar 
            float f = 5;  //4 Byte
            double d = 5;  //8 Byte
            decimal de = 5; //16 Byte

            char ch = '2';  //2 Byte
            string str = "John Doe";  //Sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            //String ifadeler
            string str1 = string.Empty;
            str1 = "John Doe";
            string ad = "John";
            string soyad = "Doe";
            string tamIsim = ad + " " + soyad;

            //Integer tanımlama şekilleri
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //Boolean
            bool bool3 = 10 > 2;


            //Değişken dönüşümleri
            string str20 = "10";
            int int20 = 20;
            string yenideger = str20 + int20.ToString(); //Çıktısı 2020
            Console.WriteLine(yenideger);

            int int21 = int20 + Convert.ToInt32(str20); //Çıktısı 40
            Console.WriteLine(yenideger);

            int int22 = int20 + int.Parse(str20); //Çıktısı 40

            //DateTime
            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime1);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //Saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
            Console.ReadLine();
        }
    }
}
