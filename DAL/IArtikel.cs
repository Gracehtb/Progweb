using System.Collections.Generic;
using SampleASPCore.Models;

namespace SampleASPCore.DAL
{
    public interface IArtikel
    {
        IEnumerable<Artikel> GetAll();
        Artikel GetById(string ArtikelID);
        void Insert(Artikel art);
        void Update(Artikel art);
        void Delete(string ArtikelID);
        IEnumerable<Artikel> GetAllByjudul(string Judul);
        IEnumerable<Artikel> GetAllByIsi(string Berita);
        IEnumerable<Artikel> GetAllByName(string Username);

    }
}