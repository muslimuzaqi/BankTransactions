using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTrasactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Required(ErrorMessage ="This field is required")]
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [MaxLength(12, ErrorMessage ="Maximum 12 characters only.")]
        public string AccountNumber { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName ="nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        public string BeneficiaryName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        public string BankName { get; set; }


        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Swift Code")]
        public string SwiftCode { get; set; }


        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
