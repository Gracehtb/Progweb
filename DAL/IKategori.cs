using System.Collections.Generic;
using SampleASPCore.Models;

namespace SampleASPCore.DAL
{
    public interface IKategori
    {
        IEnumerable<Kategori> GetAll();
        Kategori GetById(int KategoriID);

        void Insert(Kategori ktg);
        void Update(Kategori ktg);
        void Delete(int KategoriID);
    }
}