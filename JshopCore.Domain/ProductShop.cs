﻿namespace JshopCore.Domain
{
    using Newtonsoft.Json;

    public class ProductShop
    {
        public long ProductShopId { get; set; }

        public long StoreId { get; set; }
        public long ProductId { get; set; }

        [JsonIgnore]
        public virtual Product Product { get; set; }
        [JsonIgnore]
        public virtual Store Store { get; set; }
    }
}
