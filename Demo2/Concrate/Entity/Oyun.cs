using System;
using System.Collections.Generic;
using System.Text;
using Demo2.Abstract;

namespace Demo2.Concrate.Entity
{
    public class Oyun : IEntity
    {
        public string Ad { get; set; }

        public string Türü { get; set; }

        public int fiyati { get; set; }
    }
}
