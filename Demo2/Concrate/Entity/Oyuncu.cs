using System;
using System.Collections.Generic;
using System.Text;
using Demo2.Abstract;

namespace Demo2.Concrate.Entity
{
    public class Oyuncu : IEntity
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string TcNo { get; set; }

        public DateTime DogumYili { get; set; }

        public int Bakiye { get; set; }

        public List<Oyun> SahipOlduguOyunlar { get; set; }
    }
}
