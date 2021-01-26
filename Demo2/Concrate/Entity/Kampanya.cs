using System;
using System.Collections.Generic;
using System.Text;
using Demo2.Abstract;

namespace Demo2.Concrate.Entity
{
    public class Kampanya : IEntity
    {
        public string Ad { get; set; }

        public int IndirimFiyati { get; set; }
    }
}
