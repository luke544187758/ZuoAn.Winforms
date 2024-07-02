using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace Study.Antd.Demo.Models
{
    public class AccountModel
    {
        //Fields
        private string _tenant; // 租户
        private string _userName;   // 用户名
        private string _password;   // 密码，密文
        private bool _isRemember;   // 是否记住

        //Properties 
        [YamlMember(Alias ="tenant")]
        [DisplayName("Tenant")]
        [Required(ErrorMessage = "Tenant is required")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "Tenant be between 3 and 16 characters")]
        public string Tenant { get => _tenant; set => _tenant = value; }
        [YamlMember(Alias = "username")]
        [DisplayName("UserName")]
        [Required(ErrorMessage = "UserName is required")]
        [StringLength(16, MinimumLength = 3, ErrorMessage = "UserName be between 3 and 16 characters")]
        public string UserName { get => _userName; set => _userName = value; }
        [YamlMember(Alias = "password")]
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "Password be between 6 and 16 characters")]
        public string Password { get => _password; set => _password = value; }
        [YamlMember(Alias = "isremember")]
        [DisplayName("IsRemember")]
        public bool IsRemember { get => _isRemember; set => _isRemember = value; }
    }
}
