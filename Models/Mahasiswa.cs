

using System.ComponentModel.DataAnnotations;

namespace SampleASPCore.Models {
    public class Mahasiswa {

         [Required(ErrorMessage="Data Nim Harus diisi !")]
        [StringLength(8,MinimumLength=8)]
        public string Nim { get; set; }
         [Required]
        public string  Nama { get; set; }
         [Required]
        [EmailAddress]
        public string  Email { get; set; }  
         [Required]
        public string Telp { get; set; }    
    }
    }