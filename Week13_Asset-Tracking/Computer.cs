using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Week13_Asset_Tracking
{
    public class Computer : Device
    {
        public Computer(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        new public string Info()
        {
            return $"Computer : ({Brand} {Model})";
        }
    }
}
