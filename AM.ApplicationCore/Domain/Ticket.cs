using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public String classe { get; set; }
        public String destination { get; set; }
        public int TicketId { get; set; }
        public ReservationTicket Reservation { get; set; }

    }
}
