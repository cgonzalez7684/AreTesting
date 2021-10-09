using System;
using System.Collections.Generic;

#nullable disable

namespace Arepa.Share.Model
{
    public partial class User
    {
        [Key]
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
    }
}
