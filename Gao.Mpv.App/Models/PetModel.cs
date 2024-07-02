using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Gao.Mpv.App.Models
{
    public class PetModel
    {
        //Fields
        private int _id;
        private string _name;
        private string _type;
        private string _color;

        //Propeties - Validations
        [DisplayName("Pet ID")]
        public int Id { get => _id; set => _id = value; }
        [DisplayName("Pet Name")]
        [Required(ErrorMessage ="Pet Name is required")]
        [StringLength(50, MinimumLength =3,ErrorMessage ="Pet name be between 3 and 50 characters")]
        public string Name { get => _name; set => _name = value; }
        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet Type is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet type be between 3 and 50 characters")]
        public string Type { get => _type; set => _type = value; }
        [DisplayName("Pet Color")]
        [Required(ErrorMessage = "Pet Color is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet color be between 3 and 50 characters")]
        public string Color { get => _color; set => _color = value; }
    }
}
