using System;

namespace PeeReview.Models
{

    
    public class defaultSetUniqueID 
    {

        /*
         *Ideally, a GUID will never be generated twice by any computer or group of computers in existence.
        * The total number of unique keys (2^128 or 3.4×10^38 - in relation there are about 1.33×10^50 atoms on earth)
        * is so large that the probability of the same number being generated twice is extremely small,
        * and certain techniques have been developed to help ensure that numbers are not duplicated
         */
        public void setUniqueID(string ID)
        {
            ID = Guid.NewGuid().ToString();
        }
    }
}
