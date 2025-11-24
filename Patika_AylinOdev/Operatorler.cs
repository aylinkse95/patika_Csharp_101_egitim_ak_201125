using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_AylinOdev
{
    public class Operatorler
    {
        public Operatorler(string start)
        {
            // kurucu method
            Console.WriteLine("Operatorler sinifi calisti : "+start);


        }

        // sayi1  =  10 => 5 / sayi2 3 => -2
        public int Hesapla(int sayi1, int sayi2)
        {
            
          if (sayi1 > 5)
            {
                Console.WriteLine("Sayi1 5ten  kucuk");
                return sayi1 - 5;
            }

            return sayi2 - 5;
        }

        public string Kontrol(int yas)
        {
            if(yas >=15 && yas<18)
            {
                return "Sınırlı üyelik oluşturabilirsiniz.";
            }
            else if (yas>=18 && yas<30)
            {
                return "Üyelik oluşturabilirsiniz.";
            }
            else if (yas>=30)
            {
                return "Üyelik oluşturulamaz.";
        }
            return "Beklenmedik hata oluştu.";
        }

    }
}
