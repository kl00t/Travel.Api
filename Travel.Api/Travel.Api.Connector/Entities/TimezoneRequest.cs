﻿// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class TimezoneRequest : BaseRequest
    {
        public string location { get; set; }

        public string timestamp { get; set; }
    }
}