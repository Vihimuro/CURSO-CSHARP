﻿using System;

namespace HotelReservation.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) :base(message) { }
    }
}
