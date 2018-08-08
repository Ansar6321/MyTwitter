using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Model {
    public class User {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImagePath { get; set; }
        public string Login { get; set; }
        // Password - хранить безопасно
        public string Password { get; set; }
    }
}
