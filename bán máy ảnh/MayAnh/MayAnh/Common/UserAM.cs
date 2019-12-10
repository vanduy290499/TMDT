using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MayAnh.Common
{
    [Serializable]
    public class UserAM
    {
        public long userID { set; get; }
        public string Username { set; get; }
    }
}