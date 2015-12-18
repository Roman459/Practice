using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcApplication3.Models
{
    public class User 
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public string Login { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Foto { get; set; }

     // public HttpPostedFileBase file { get; set; }
    }
}