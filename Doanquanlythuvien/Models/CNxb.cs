using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Doanquanlythuvien.Models
{
    [MetadataType(typeof(CNxb))]
    public class CNxb
    {
        [Required(ErrorMessage = "Nhập Mã NXB")]
        [Display(Name = "Mã NXB")]//tên của giá trị
        public string MaNXB { get; set; }
        [Required(ErrorMessage = "Nhập Tên NXB")]
        [Display(Name = "Tên NXB")]
        public string TenNXB { get; set; }
    }
}