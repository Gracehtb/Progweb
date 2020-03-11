using Microsoft.AspNetCore.Http;

namespace SampleASPCore.Models
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}