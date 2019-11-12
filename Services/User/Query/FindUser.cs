using System;
using System.Collections.Generic;
using System.Text;
using Services.Common.Query;
using Services.User.Dtos;

namespace Services.User.Query
{
    public class FindUser:IQuery<IEnumerable<FindUserDto>>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
