using System.ComponentModel.DataAnnotations;

namespace QRCodeGenerator.Models
{
    public class GenerateQRCodeModel
    {
        [Display(Name = "Enter QR Code Text")]
        public string QRCodeText{get;set;}
    }
}
