﻿namespace Bitfinex.Net.Objects.RestV1Objects
{
    public class BitfinexClosePositionResult
    {
        /// <summary>
        /// Status message
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// The position status
        /// </summary>
        public BitfinexPositionV1 Position { get; set; }
        /// <summary>
        /// The order used to close the position
        /// </summary>
        public BitfinexPlacedOrder Order { get; set; }
    }
}
