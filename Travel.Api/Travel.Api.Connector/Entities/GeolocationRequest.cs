﻿namespace Travel.Api.Connector.Entities
{
    public class GeolocationRequest : BaseRequest
    {
        public string homeMobileCountryCode { get; set; }

        public string homeMobileNetworkCode { get; set; }

        public string radioType { get; set; }

        public string carrier { get; set; }

        public string considerIp { get; set; }

        public string cellTowers { get; set; }

        public string wifiAccessPoints { get; set; }
    }
}