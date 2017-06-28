﻿namespace DistanceMatrix.Connector.Entities
{
    public class DistanceMatrix
    {
        public string[] destination_addresses { get; set; }

        public string[] origin_addresses { get; set; }

        public Row[] rows { get; set; }

        public string status { get; set; }
    }
}