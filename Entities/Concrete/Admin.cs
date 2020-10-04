using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Admin : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your email !")]
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter the password ! And the password must be in 8 character")]
        [DataType(DataType.Password)]
        [StringLength(255, ErrorMessage = "Must be between 8 and 255 characters", MinimumLength = 8)]
        [Display(Name = "Pass")]
        public string Pass { get; set; }

    }
}
