using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kk
{
    class Personeller
    {
        private int _PersonelId;
        private int _PersonelGorevId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private string _PersonelParola;
        private string _PersonelKullaniciAdi;
        private bool _PersonelDurum;
        #region property
        public int PersonelId
        {
            get { return _PersonelId; }
            set { _PersonelId = value; }
        }
        
        public int PersonelGorevId
        {
            get { return (int)_PersonelGorevId; }
            set { _PersonelGorevId = value; }
        }
       
        public string PersonelAd
        {
            get { return _PersonelAd; }
            set { _PersonelAd = value; }
        }

        
        public string PersonelSoyad
        {
            get { return _PersonelSoyad; }
            set { _PersonelSoyad = value; }
        }
        
        public string PersonelParola
        {
            get { return _PersonelParola; }
            set { _PersonelParola = value; }
        }
        
        public string PersonelKullaniciAdi
        {
            get { return _PersonelKullaniciAdi; }
            set { _PersonelKullaniciAdi = value; }
        }

        
        public bool PersonelDurum
        {
            get { return _PersonelDurum; }
            set { _PersonelDurum = value;}
        }
        #endregion
        public bool PersonelGirisKontorl(string sifre, int id)
        {
            bool result=false;
            return true;
        }
    }
}
