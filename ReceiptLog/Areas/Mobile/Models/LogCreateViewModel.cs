using System;
using System.ComponentModel.DataAnnotations;

namespace ReceiptLog.Areas.Mobile.Models
{
    public class LogCreateViewModel
    {
        public LogCreateViewModel()
        {
            When = DateTime.Now;
        }

        [Required]
        [StringLength(50)]
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }

        [Required]
        public decimal? Amount { get; set; }

        private DateTime _when = DateTime.Now.Date;

        public DateTime When
        {
            get { return _when.Date; }
            set { _when = value.Date; }
        }

        [Required]
        [StringLength(50)]
        public string Where { get; set; }

        [StringLength(200)]
        [Display(Name = "Why/Notes")]
        public string Why { get; set; }
    }
}