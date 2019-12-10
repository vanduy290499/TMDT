using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MayAnh.Areas.Admin.Models
{
    public class LoginAM
    {
        [Required(ErrorMessage = "Mời Nhập Tài Khoản")]
        [Display(Name = "Tên Đăng Nhập:")]
        public string username { get; set; }

        [Required(ErrorMessage = "Mời Nhập Password")]
        [Display(Name = "Mật Khẩu:")]
        public string password { get; set; }
        public bool remeberme { get; set; }
    }
}