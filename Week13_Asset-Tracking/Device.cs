using System;
using System.Collections.Generic;
using System.Text;

namespace Week13_Asset_Tracking
{
    public class Device
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public string Info()
        {
            return $"Device -- ({Brand} {Model})";
        }
    }
}
