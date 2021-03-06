﻿using CryptoExchange.Net.Converters;
using Newtonsoft.Json;

namespace Bitfinex.Net.Objects
{
    [JsonConverter(typeof(ArrayConverter))]
    public class BitfinexMarketAveragePrice
    {
        /// <summary>
        /// The average price
        /// </summary>
        [ArrayProperty(0)]
        public decimal AverageRate { get; set; }

        /// <summary>
        /// The amount
        /// </summary>
        [ArrayProperty(1)]
        public decimal Amount { get; set; }
    }
}
