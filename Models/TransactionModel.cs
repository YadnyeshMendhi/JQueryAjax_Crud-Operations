using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JQueryAjaxCRUD_PopUp_Dialog.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionID { get; set; }

        [MaxLength(12, ErrorMessage = "Maximum 12 characters only")]
        [Required(ErrorMessage ="This is required field")]
        [DisplayName("Account Number")]
        [Column(TypeName = "nvarchar(12)")]
        public string AccountNumber { get; set; }

        [Required(ErrorMessage = "This Field is required")]
        [DisplayName("Beneficiary Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string BenificiaryName { get; set; }

        [Required(ErrorMessage = "This Field is required.")]
        [DisplayName("Bank Name")]
        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }


        [MaxLength(11 , ErrorMessage = "Maximum 12 characters only")]
        [Required(ErrorMessage = "This Field is required.")]
        [DisplayName("SWIFT Code")]
        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage ="This is field is required")]
        [DisplayName("Amount")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

    }
}
