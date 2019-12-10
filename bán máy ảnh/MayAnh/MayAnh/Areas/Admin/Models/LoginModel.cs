using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MayAnh.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời Nhập Tài Khoản")]
        [Display(Name ="Tên Đăng Nhập:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mời Nhập Password")]
        [Display(Name = "Mật Khẩu:")]
        public string PassWord { get; set; }
        public bool RememberMe { get; set; }

    }
}