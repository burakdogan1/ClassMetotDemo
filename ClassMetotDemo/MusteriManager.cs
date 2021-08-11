using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
	public class MusteriManager
	{
		public void MusteriListele(List<Musteri> musteris)
		{
			Console.WriteLine(" ");
			Console.WriteLine("______________________  MÜŞTERİ lİSTELEME İŞLEMLERİ  _______________________");
			Console.WriteLine(" ");

			foreach (Musteri musteri in musteris)
			{
				Console.WriteLine("MMüşteri Adı :   " + musteri.MusteriAdi + "   Müşteri Soyadı :   " + musteri.MusteriSoyadi + "   Müşteri Numarası :   " + musteri.MusteriNo + "    Müşteri ID :   " + +musteri.MusteriId);
			}
		}

		public void MusteriEkle(List<Musteri> musteris)
		{
			Console.WriteLine(" ");
			Console.WriteLine("______________________  MÜŞTERİ EKLEME İŞLEMLERİ  _______________________");
			Console.WriteLine(" "); 

			Musteri _musteri = new Musteri();
			Console.Write("Eklemek İstediğiniz Müşterinin ADINI Giriniz : ");
			_musteri.MusteriAdi = Console.ReadLine();
			Console.Write("Eklemek İstediğiniz Müşterinin SOYADINI Giriniz : ");
			_musteri.MusteriSoyadi = Console.ReadLine();
			Console.Write("Eklemek İstediğiniz Müşterinin MÜŞTERİ NUMARASINI Giriniz : ");
			_musteri.MusteriNo = Console.ReadLine();
			_musteri.MusteriId = musteris.Count + 1;
			musteris.Add(_musteri);

			MusteriListele(musteris);

		}

		public void MusteriGuncelle(List<Musteri> musteris)
		{
			Console.WriteLine(" ");
			Console.WriteLine("______________________  MÜŞTERİ GÜNCELLEME İŞLEMLERİ  _______________________");
			Console.WriteLine(" ");

			Console.WriteLine("Güncellemek İstediğiniz Müşteri Numarasını Giriniz ");
			string MusteriNo = Console.ReadLine();
			int i = 0;
			while (i < musteris.Count)
			{
				if (musteris[i].MusteriNo == MusteriNo)
				{

					Console.Write("Güncellemek İstediğiniz Müşterinin ADINI Giriniz : ");
					musteris[i].MusteriAdi = Console.ReadLine();
					Console.Write("Güncellemek İstediğiniz Müşterinin SOYADINI Giriniz : ");
					musteris[i].MusteriSoyadi = Console.ReadLine();
					Console.Write("Güncellemek İstediğiniz Müşterinin MÜŞTERİ NUMARASINI Giriniz : ");
					musteris[i].MusteriNo = Console.ReadLine();
					MusteriListele(musteris);
					break;
				}
				else
					i++;
			}

			MusteriListele(musteris);
		}

		public void MusteriSil( List<Musteri> musteris)
		{
			Console.WriteLine(" ");
			Console.WriteLine("______________________  MÜŞTERİ SİLME İŞLEMLERİ  _______________________");
			Console.WriteLine(" ");

			Console.WriteLine("Silmek İstediğiniz Müşteri Numarasını Giriniz ");
			Musteri _musteri = new Musteri();
			_musteri.MusteriNo = Console.ReadLine();
			int i = 0;
			while ( i< musteris.Count)
			{
				if (musteris[i].MusteriNo == _musteri.MusteriNo)
				{
					musteris.Remove(musteris[i]);
					break;
				}
				else
					i++;
			}

			MusteriListele(musteris);
		}
	}
}
