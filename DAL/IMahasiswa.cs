using System.Collections.Generic;
using SampleASPCore.Models;

namespace SampleASPCore.DAL {

    public interface IMahasiswa
    {
        IEnumerable<Mahasiswa> GetAll();
        Mahasiswa GetById(string nim);

    void Insert(Mahasiswa mhs);
    void Update(Mahasiswa mhs);
    void Delete(string nim);

    IEnumerable<Mahasiswa> GetAllByNim(string nim);
    IEnumerable<Mahasiswa> GetAllByNama(string nama);

    }
}