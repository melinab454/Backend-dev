using System.IO.Compression;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Week2;

class Program
{
    static void Main(string[] args)
    {
        //! 1.
        /*int a = 5 ;
        int b=7; 
        int result = a +b ; 
        System.Console.WriteLine($"A+B : {result}");*/

        //! 2. 
        /*
        double X = 12.5;
        double operation = X * X;
        System.Console.WriteLine(operation);*/

        //! 3. 
        // string Name = "Ömer ";
        // int Age = 23;
        // System.Console.WriteLine($"Benim Adım {Name} , {Age} yaşındayım ");

        //! 4. 
        // char harf = 'O';
        // int asciD = (int)harf;
        // System.Console.WriteLine("Asci Değeri : "+asciD);

        //! 5. 

        // bool trueD = true; 
        // bool falseD = false; 

        // System.Console.WriteLine($"True : {trueD} False: {falseD}");

        //! 6.   
        // ? : (GetType() fonksiyonu türünü geriye döndürür 

        // byte X = 255; // System.Byte
        // int Y = (int)X; //System.Int32 :  ! gerek yok 
        // int Z = X; //! System.Int32 : Bilincsiz tür dönüşümü çünkü int>byte 

        // System.Console.WriteLine(Y.GetType());
        //  System.Console.WriteLine(X.GetType());
        //  System.Console.WriteLine(Z.GetType());

        //! 7.   
        // int X = 12361312;
        // byte Y = (byte)X; //x in içideki veriyi  byte türünde karşıla eğer varsa veri kaybı bunu ben üsteliyorum ,bilinçli bir şekilde yaptığımız  derleyice söylemek için cast ettik 
        // System.Console.WriteLine(X.GetType());
        // System.Console.WriteLine(Y.GetType() + " "+ Y ); //! System.Byte 96 cıkma sebebini defterde yazıyordu 
        //!  : System.Console.WriteLine(12361312% 256);  //96 cıkar 255 değil 256 ile bölümünde kalan kadar veri tütar diğer türleride böyle düşünebilirsin 

        //! 8.  

        // double X = 3.14;
        // double X = 3.99;
        // int Y = (int)X;
        // System.Console.WriteLine(Y); //virgülden sonraki gelen kısımı ekrana yazdırmadı  ve her zaman en aza yuvarlar kısaca sadece tam sayıyı alır 

        //! 9. 
        // string X = "15";
        // int Y = Convert.ToInt32(X);
        // System.Console.WriteLine(Y.GetType());

        //! 10. 
        // int X = 6; 
        // int Y = 10; 
        // int Z = 15;
        // double result = (X + Y + Z) / 3.0; //ondalıklı sayıyı 
        // double result2 = (X + Y + Z) / 3; //tam sayı
        // System.Console.WriteLine(result);

        //! 11. 
        // decimal X = 10.25m;
        // decimal Y = 5.78m;

        // decimal Z = Y + X;
        // System.Console.WriteLine(Z + " : " +  Z.GetType());

        //! 12.  double > float 
        // float f = 1.23f;        // float tipinde bir değişken oluşturuyoruz
        // double d = (double)f;  // float değerini double'a dönüştürüyoruz

        // System.Console.WriteLine("F " + f); //! 1,23
        // System.Console.WriteLine("D " + d); //! 1,2300000190734863

        //! 13 . 
        //     long X = 500000000000;  
        //     //int Y = (int)X; 

        //    // System.Console.WriteLine("long : "+ X+ " int : "+ Y); //
        //     System.Console.WriteLine(int.MaxValue);
        //     int Z = int.MaxValue;
        //     System.Console.WriteLine("Result : "+ X%Z);

        //! 14. 

        string Name = "Ömer";
        string LastName = "TAŞTEKİN";
        string FullName = $"{Name} {LastName}";
        System.Console.WriteLine(FullName);

        //! 15

        // string T = "true";
        // bool Td = Convert.ToBoolean(T);
        // System.Console.WriteLine(Td.GetType()); 

        //! 16.

        // double D = 3.1415956656565656565656;
        // float F = (float)D;
        // System.Console.WriteLine("D : "+ D + " F : "+F);
        // System.Console.WriteLine( D.GetType() +"  " +  F.GetType());

        //! 17. 

        System.Console.WriteLine(sizeof(byte));
        System.Console.WriteLine(sizeof(short));
        System.Console.WriteLine(sizeof(int));
        System.Console.WriteLine(sizeof(long));
        System.Console.WriteLine(sizeof(double));
        System.Console.WriteLine(sizeof(float));

        //! 18 . 
        string text = "merhaba ben ömer ";
        System.Console.WriteLine(text.Length);
    }
}
