using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publico_YT.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime When { get; set; }
        public virtual AppUser Sender { get; set; }

        public Message()
        {
            When = DateTime.Now;
        }

    }
}
