﻿namespace JshopCore.Domain
{
    public class Store
    {
        public long StoreId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public string Phone { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
