using System.Collections.Generic;
using SampleASPCore.Models;

namespace SampleASPCore.DAL {

    public interface IDosen
    {
        IEnumerable<Dosen> GetAll();
        Dosen GetById(string Nik);

    void Insert(Dosen dsn);
    void Update(Dosen dsn);
    void Delete(string nik);

    }
}