// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The Location. </summary>
    public partial class Location
    {
        /// <summary> Initializes a new instance of Location. </summary>
        internal Location()
        {
        }

        /// <summary> Initializes a new instance of Location. </summary>
        /// <param name="countryCode"></param>
        /// <param name="countryName"></param>
        /// <param name="region"></param>
        /// <param name="regionName"></param>
        /// <param name="city"></param>
        /// <param name="areaCode"></param>
        /// <param name="postalCode"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="dmaCode"></param>
        /// <param name="metroCodeId"></param>
        internal Location(string countryCode, string countryName, string region, string regionName, string city, int? areaCode, string postalCode, float? latitude, float? longitude, int? dmaCode, int? metroCodeId)
        {
            CountryCode = countryCode;
            CountryName = countryName;
            Region = region;
            RegionName = regionName;
            City = city;
            AreaCode = areaCode;
            PostalCode = postalCode;
            Latitude = latitude;
            Longitude = longitude;
            DmaCode = dmaCode;
            MetroCodeId = metroCodeId;
        }

        /// <summary> Gets the country code. </summary>
        public string CountryCode { get; }
        /// <summary> Gets the country name. </summary>
        public string CountryName { get; }
        /// <summary> Gets the region. </summary>
        public string Region { get; }
        /// <summary> Gets the region name. </summary>
        public string RegionName { get; }
        /// <summary> Gets the city. </summary>
        public string City { get; }
        /// <summary> Gets the area code. </summary>
        public int? AreaCode { get; }
        /// <summary> Gets the postal code. </summary>
        public string PostalCode { get; }
        /// <summary> Gets the latitude. </summary>
        public float? Latitude { get; }
        /// <summary> Gets the longitude. </summary>
        public float? Longitude { get; }
        /// <summary> Gets the dma code. </summary>
        public int? DmaCode { get; }
        /// <summary> Gets the metro code id. </summary>
        public int? MetroCodeId { get; }
    }
}
