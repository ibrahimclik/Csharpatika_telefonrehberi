using System;
using System.Collections.Generic;

namespace consoletelefonrehberi
{
    class Program
    {
        static void Main(string[] args)
        {   //BEKLENEN ÖZELLİKLER:No kaydet,no sil,no güncelle,rehber listele ve rehberde arama yap.
        
            

            List<List<string>> ListelerListesi=new List<List<string>>();   //Bu kısımda ilk başta bizden istenilen beş varsayılan kişiyi listeledim.
           
            List <string> varsayılan1=new List<string>();
            varsayılan1.Add("Ali");
            varsayılan1.Add("Yılmaz");
            varsayılan1.Add("3332727");

            List <string> varsayılan2=new List<string>();
            varsayılan2.Add("İbrahim");
            varsayılan2.Add("Çelik");
            varsayılan2.Add("3328852");
            
            List <string> varsayılan3=new List<string>();
            varsayılan3.Add("Merve");
            varsayılan3.Add("Çelik");
            varsayılan3.Add("2278585");
            
            List <string> varsayılan4=new List<string>();
            varsayılan4.Add("Emre");
            varsayılan4.Add("Demir");
            varsayılan4.Add("5568789");
            
            List <string> varsayılan5=new List<string>();
            varsayılan5.Add("Mahmut");
            varsayılan5.Add("Kısa");
            varsayılan5.Add("3336699");
            
            ListelerListesi.Add(varsayılan1);
            ListelerListesi.Add(varsayılan2);
            ListelerListesi.Add(varsayılan3);
            ListelerListesi.Add(varsayılan4);
            ListelerListesi.Add(varsayılan5);
            

            //Her bir işlem için ayrı ayrı metotlar oluşturdum.


            void anaekran() {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :\n"+"*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("*******************************************");
            int a=int.Parse(Console.ReadLine());

            if(a==1) 
                NumaraEkleme();
            if(a==2) 
                NumaraSilmek();
            if(a==3) 
                NumaraGüncelle(); 
            if(a==4) 
                RehberiListele();
            if(a==5)
                AramaYap();       //Bu kısımda kullanıcının tercihine göre fonksiyonlara gitmemi sağlayan bir if bloğu kullandım.  
            }
 
            anaekran();           //Kullanıcının karşısına çıkan arayüz.





           //NUMARA EKLEME İÇİN KULLANILACAK METOT.
            
            void NumaraEkleme() {
            Console.WriteLine("Lütfen isim giriniz             :");
            string isim=Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            string soyisim=Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string numara=Console.ReadLine();
            
            
            List<string> Yeninumaralar=new List<string>();
            
            Yeninumaralar.Add(isim);
            Yeninumaralar.Add(soyisim);
            Yeninumaralar.Add(numara);
            ListelerListesi.Add(Yeninumaralar);
            
            Console.WriteLine("Numara başarıyla eklendi,ana ekrana dönülüyor...\n");
            
               
            anaekran();
            }




            
            //NUMARA SİLME ÖZELLİĞİ İÇİN KULLANACAĞIM METOT.

            void NumaraSilmek() {

            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string silinen=Console.ReadLine();
            
            foreach (var item in ListelerListesi)
            {   
                foreach (var içerdeki in item)
                {     
                  if(silinen==içerdeki) {
                  Console.WriteLine(silinen+" isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                  string cevap=Console.ReadLine();
                  if(cevap=="y") {
                  item.RemoveRange(0,3);
                  Console.WriteLine("Silme işlemi başarıyla gerçekleşti.\n");
                  anaekran(); }
                  else {
                  anaekran();}
                  }  
                }
                
            }
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            string cevap2=Console.ReadLine();
            if(cevap2=="1") {
            Console.WriteLine("Silme işlemi sonlandırıldı,ana ekrana dönülüyor..\n");
            anaekran(); }
            else 
            NumaraSilmek();
            }
            

            //NUMARALARI GÜNCELLEMEK İÇİN KULLANILACAK METOT.


            void NumaraGüncelle() {
            
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string güncellenen=Console.ReadLine();

            foreach (var item in ListelerListesi)
            {   
                foreach (var içerdeki  in item)
                {
                if(güncellenen==içerdeki) {
                    Console.WriteLine(güncellenen+" isimli kişinin bilgileri güncellenmek üzere, onaylıyor musunuz ?(y/n)");
                    string z=Console.ReadLine();
                    if(z=="y") {
                    item.RemoveRange(0,3);
                    Console.WriteLine("Lütfen isim giriniz");
                    item.Add(Console.ReadLine());
                    Console.WriteLine("Lütfen soyisim giriniz");
                    item.Add(Console.ReadLine());
                    Console.WriteLine("Lütfen numara giriniz");
                    item.Add(Console.ReadLine());
                    Console.WriteLine("Güncelleme işlemi başarılı,ana ekrana dönülüyor...\n");
                    anaekran();
                    }
                    }
                }
            }
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n");
            Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            int w=int.Parse(Console.ReadLine());
            if(w==1){
                Console.WriteLine("Güncelleme sonlandırıldı,ana ekrana dönülüyor...\n");
                anaekran();
            } 
            else {
                NumaraGüncelle();
            }
            }


            //REHBERİ LİSTELEMEK İÇİN KULLANILAN METOT.




            void RehberiListele() {
            Console.WriteLine("\n");
            Console.WriteLine("Telefon Rehberi\n"+"**********************************************");
            string[] kalıp={"isim: ","Soyisim: ","Numara: "};
            int sayac=0;
            foreach (var eleman in ListelerListesi)
            {    
                
                foreach (var içeleman in eleman)
                
                {
                    Console.Write(kalıp[sayac]+içeleman+"\n");
                    sayac++;
                }
                sayac=0;
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Ana ekrana dönülüyor...");
            Console.WriteLine("\n");
            anaekran();
            
            }






            //ARAMA İÇİN KULLANILACAK METOT.




            void AramaYap() {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n"+"**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string istenen=Console.ReadLine();
            Console.WriteLine("Arama yapamak istediğiniz kişinin bilgisini giriniz.");
            string aranan=Console.ReadLine();
            string[] kalıp={"isim: ","Soyisim: ","Numara: "};
            int sayac=0;
            foreach (var item in ListelerListesi)
            {   
                foreach (var içerdeki  in item)
                {   
                if(aranan==içerdeki) {
                    foreach (var ayrı in item)
                    {
                    Console.WriteLine(kalıp[sayac]+ayrı);
                    sayac++;        
                }
                
                Console.WriteLine("Ana ekrana dönmek için 1'i tuşlayınız");
                int a1=int.Parse(Console.ReadLine());
                if(a1==1)
                anaekran();              
                }
            } 
            }
            Console.WriteLine("Aradığınız kişi rehberde yok");
            }



        //THE END.
       
        }
    }
}