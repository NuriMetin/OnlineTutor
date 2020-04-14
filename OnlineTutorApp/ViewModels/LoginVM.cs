using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTutorApp.ViewModels
{
    public class LoginVM
    {
        [DataType(DataType.EmailAddress, ErrorMessage = "Daxil edilmiş məlumat 'email' formatında deyil!!")]
        [Required(ErrorMessage = "Boş ola bilməz")]
        [StringLength(150, ErrorMessage = "İcazə verilən maksimum simvol sayı 150")]
        [MinLength(10, ErrorMessage = "İcazə verilən minimum simvol sayı 10")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Boş ola bilməz")]
        [StringLength(30, ErrorMessage = "İcazə verilən maksimum simvol sayı 30")]
        [MinLength(6, ErrorMessage = "İcazə verilən minimum simvol sayı 6")]
        public string Password { get; set; }

        public bool Remember { get; set; }
    }
}
