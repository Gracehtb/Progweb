using SampleASPCore.Models;

namespace SampleASPCore.DAL {
   
   public interface IPengguna
   {
        Pengguna CekLogin(string username,string password); 
        void Insert(Pengguna pengguna);
   }

}