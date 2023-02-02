using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratore
{
    public class Ride
    {
        //variables
        public double rideDistance;
        public int rideTime;
        public Ride(double rideDistance, int rideTime)
        {
            this.rideDistance = rideDistance;
            this.rideTime = rideTime;
        }
    }
}