using System;

namespace encapsulation_property
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim="Ayse";
            ogrenci1.Soyisim="Yılmaz";
            ogrenci1.Sinif=3;
            ogrenci1.OgrenciNo=1353;
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci1.Isim="Mehmet";
            ogrenci1.Soyisim="Aydın";
            ogrenci1.Sinif=1;
            ogrenci1.OgrenciNo=2222;
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();


        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get {return isim;} //=> isim;
            set => isim = value; //{isim=value;}
        }

        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Sinif
        { 
          get => sinif;
          set
          {
            if(value < 1)
                {Console.WriteLine("Birden düşük sinif olamaz!!");
                sinif=1;}
            else
                sinif = value;
          } 

        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            this.soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}
        
        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("********OgrenciBilgileri********");
            Console.WriteLine("Öğrenci Adı    :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı :{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No     :{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıf  :{0}",this.Sinif );
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;

        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
