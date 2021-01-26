using System;
using System.Collections.Generic;
using System.Text;
using Demo2.Abstract;
using Demo2.Concrate.Entity;

namespace Demo2.Concrate
{
    public class KampanyaManager : IEntityRepository<Kampanya>
    {
        public void Add(Kampanya entity)
        {
            Console.WriteLine(entity.Ad + " Eklendi!");
        }

        public void Delete(Kampanya entity)
        {
            Console.WriteLine(entity.Ad + " Eklendi!");
        }

        public void Update(Kampanya entity)
        {
            Console.WriteLine(entity.Ad + " Eklendi!");
        }
    }
}
