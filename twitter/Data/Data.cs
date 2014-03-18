using System;
using System.Runtime.Serialization;

namespace DataContract
{
    [DataContract]
    public class Response
    {
        [DataMember(Name = "statuses")]
        public Status[] Statuses { get; set; }
    }


    [DataContract]
    public class Status
    {
        [DataMember(Name = "coordinates")]
        public Point Point { get; set; }
        //geo deprecated
        //++place if needed
    }

    [DataContract]
    public class Point
    {
        // Longitude,Latitude
        [DataMember(Name = "coordinates")]
        public double[] Coordinates { get; set; }
    }

}

