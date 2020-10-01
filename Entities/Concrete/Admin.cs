using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Admin:IEntity
    {
        [Key] 
        public int  Id { get; set; }
        public string  Email { get; set; }
        public string  Username { get; set; }
        public string  Pass { get; set; }

    }
}
