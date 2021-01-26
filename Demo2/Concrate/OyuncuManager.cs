using System;
using System.Collections.Generic;
using System.Text;
using Demo2.Abstract;
using Demo2.Concrate.Entity;

namespace Demo2.Concrate
{
    public class OyuncuManager : IEntityRepository<Oyuncu>
    {
        public void Add(Oyuncu entity)
        {
            Console.WriteLine(entity.Ad + " Eklendi!");
        }

        public void Delete(Oyuncu entity)
        {
            Console.WriteLine(entity.Ad + " Eklendi!");
        }

        public void Update(Oyuncu entity)
        {
            Console.WriteLine(entity.Ad + " Eklendi!");
        }
    }
}
