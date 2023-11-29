using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Domain.Entities
{
    public class EmailTemplate : NotificationTemplate
    {
        public EmailTemplate()
        {
            
        }

        public string Subject { get; set; } = default!;
    }
}
