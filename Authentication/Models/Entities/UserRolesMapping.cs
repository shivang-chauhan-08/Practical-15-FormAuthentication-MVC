using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Authentication.Models.Entities
{
    public class UserRolesMapping
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
    }
}