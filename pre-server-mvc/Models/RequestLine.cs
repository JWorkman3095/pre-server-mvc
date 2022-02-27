using System;
using System.Collections.Generic;

#nullable disable

namespace pre_server_mvc.Models
{
    public partial class RequestLine
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Request Request { get; set; }
    }
}
