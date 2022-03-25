using System;

namespace If_Else_Ternary_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time>=6 && time<11)
                 Console.WriteLine("Günaydın KEKE");
            else if(time<= 18)
                 Console.WriteLine("İyi Günler KEKE");
            else 
                 Console.WriteLine("İyi Geceler KEKE"); 
            string sonuc = time<=18 ? "İyi Günler KEKE" : "İyi Geceler KEKE" ;
            sonuc = time >=6 && time <11 ? "Günaydın KEKE" : time <= 18 ? "İyi Günler KEKE" : "İyi Geceler KEKE";
            Console.WriteLine(sonuc);       
 

        }
    }
}
