using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartShop.Models
{
    public class UserLogin
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}