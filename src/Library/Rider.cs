using System;
using System.Collections.Generic;

namespace Ucu.Poo.RideShare
{
    abstract public class Rider : User
    {
        public string vehicle;
        public string bio;

        abstract public void AddPassenger();
    }
}