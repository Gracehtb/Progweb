using System.ComponentModel.DataAnnotations;

namespace SampleASPCore.Models {
    public class Artikel{

         [Required(ErrorMessage="ID Artikel Harus diisi !")]
        public string ArtikelID { get; set; }

        [Required]
        public int KategoriID { get; set; }

        [Required]
        public string Judul { get; set; }

        [Required]
        public string Berita { get; set; }

        [Required]
        public string Tanggal { get; set; }

        [Required]
        public string Gambar { get; set; }

        [Required]
        public string Username { get; set; }

        public virtual Kategori Kategori {get;set;}
    }
}