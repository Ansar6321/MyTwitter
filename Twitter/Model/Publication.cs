using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Model {
    public class Publication {
        public int Id { get; set; }
        public int Sender_Id { get; set; }
        public DateTime PostDate { get; set; }
        public Theme PostTheme { get; set; }
        public string Content { get; set; }
    }
}
