using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Musteri musteri1 = new Musteri();
			Musteri musteri2 = new Musteri();
			Musteri musteri3 = new Musteri();

			musteri1.MusteriAdi = "Burak";
			musteri1.MusteriSoyadi = "Doğan";
			musteri1.MusteriNo = "123";
			musteri1.MusteriId = 1;

			musteri2.MusteriAdi = "Zeynep Asel";
			musteri2.MusteriSoyadi = "Doğan";
			musteri2.MusteriNo = "456";
			musteri2.MusteriId = 2;

			musteri3.MusteriAdi = "Emir Asaf";
			musteri3.MusteriSoyadi = "Doğan";
			musteri3.MusteriNo = "789";
			musteri3.MusteriId = 3;

			List<Musteri> musteriler = new List<Musteri>() { musteri1, musteri2, musteri3 };

			MusteriManager musteriManager = new MusteriManager();

			musteriManager.MusteriListele(musteriler);

			musteriManager.MusteriEkle(musteriler);

			musteriManager.MusteriGuncelle(musteriler);

			musteriManager.MusteriSil(musteriler);
		}
	}
}
