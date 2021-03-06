﻿using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Bitfinex.Net.Objects
{
    [JsonConverter(typeof(ArrayConverter))]
    public class BitfinexAvailableBalance
    {
        /// <summary>
        /// The available balance
        /// </summary>
        [ArrayProperty(0)]
        public decimal AvailableBalance { get; set; }
    }
}
