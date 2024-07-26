using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class ReservationTicket
    {
        public DateTime dateReservation { get; set; }
        public float prix { get; set; }
        public int ReservationId { get; set; }




        public int TicketFK { get; set; }
        [ForeignKey("TicketFK")]
        public Ticket Ticket { get; set; }
        
        

        
        public String PassengerFK { get; set; }
        [ForeignKey("PassengerFK")]
        public Passenger Passenger { get; set; }

    }
}
