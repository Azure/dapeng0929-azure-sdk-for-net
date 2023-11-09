// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    /// <summary> The PageAsset. </summary>
    public partial class PageAsset : InventoryAsset
    {
        /// <summary> Initializes a new instance of PageAsset. </summary>
        internal PageAsset()
        {
            IpAddresses = new ChangeTrackingList<ObservedString>();
            Successful = new ChangeTrackingList<ObservedBoolean>();
            HttpResponseCodes = new ChangeTrackingList<ObservedInteger>();
            HttpResponseMessages = new ChangeTrackingList<ObservedString>();
            ResponseTimes = new ChangeTrackingList<ObservedLong>();
            Frames = new ChangeTrackingList<ObservedBoolean>();
            Windows = new ChangeTrackingList<ObservedBoolean>();
            NonHtmlFrames = new ChangeTrackingList<ObservedBoolean>();
            UndirectedContent = new ChangeTrackingList<ObservedBoolean>();
            ContentTypes = new ChangeTrackingList<ObservedString>();
            ContentLengths = new ChangeTrackingList<ObservedLong>();
            WindowNames = new ChangeTrackingList<ObservedString>();
            Charsets = new ChangeTrackingList<ObservedString>();
            Titles = new ChangeTrackingList<ObservedString>();
            Languages = new ChangeTrackingList<ObservedString>();
            ResponseHeaders = new ChangeTrackingList<ObservedHeader>();
            Cookies = new ChangeTrackingList<Cookie>();
            WebComponents = new ChangeTrackingList<WebComponent>();
            Attributes = new ChangeTrackingList<Attribute>();
            AssetSecurityPolicies = new ChangeTrackingList<AssetSecurityPolicy>();
            ResponseBodyMinhashSignatures = new ChangeTrackingList<ObservedIntegers>();
            FullDomMinhashSignatures = new ChangeTrackingList<ObservedIntegers>();
            ResponseBodyHashSignatures = new ChangeTrackingList<ObservedString>();
            Errors = new ChangeTrackingList<ObservedString>();
            SslCerts = new ChangeTrackingList<SslCertAsset>();
            Sources = new ChangeTrackingList<Source>();
            RedirectUrls = new ChangeTrackingList<ObservedString>();
            FinalUrls = new ChangeTrackingList<ObservedString>();
            FinalResponseCodes = new ChangeTrackingList<ObservedInteger>();
            ParkedPage = new ChangeTrackingList<ObservedBoolean>();
            ResourceUrls = new ChangeTrackingList<ResourceUrl>();
            Guids = new ChangeTrackingList<GuidPair>();
            FinalIpAddresses = new ChangeTrackingList<ObservedString>();
            Asns = new ChangeTrackingList<ObservedLong>();
            IpBlocks = new ChangeTrackingList<IpBlock>();
            FinalAsns = new ChangeTrackingList<ObservedLong>();
            FinalIpBlocks = new ChangeTrackingList<IpBlock>();
            ResponseBodies = new ChangeTrackingList<ObservedString>();
            Location = new ChangeTrackingList<ObservedLocation>();
            Services = new ChangeTrackingList<Service>();
            Cnames = new ChangeTrackingList<ObservedString>();
            Cdns = new ChangeTrackingList<ObservedString>();
            SslServerConfig = new ChangeTrackingList<SslServerConfig>();
            GdprAssetSecurityPolicies = new ChangeTrackingList<AssetSecurityPolicy>();
            Ipv4 = new ChangeTrackingList<ObservedBoolean>();
            Ipv6 = new ChangeTrackingList<ObservedBoolean>();
        }

        /// <summary> Initializes a new instance of PageAsset. </summary>
        /// <param name="url"></param>
        /// <param name="httpMethod"></param>
        /// <param name="service"></param>
        /// <param name="ipAddresses"></param>
        /// <param name="successful"></param>
        /// <param name="httpResponseCodes"></param>
        /// <param name="httpResponseMessages"></param>
        /// <param name="responseTimes"></param>
        /// <param name="frames"></param>
        /// <param name="windows"></param>
        /// <param name="nonHtmlFrames"></param>
        /// <param name="undirectedContent"></param>
        /// <param name="contentTypes"></param>
        /// <param name="contentLengths"></param>
        /// <param name="windowNames"></param>
        /// <param name="charsets"></param>
        /// <param name="titles"></param>
        /// <param name="languages"></param>
        /// <param name="responseHeaders"></param>
        /// <param name="cookies"></param>
        /// <param name="webComponents"></param>
        /// <param name="attributes"></param>
        /// <param name="assetSecurityPolicies"></param>
        /// <param name="responseBodyMinhashSignatures"></param>
        /// <param name="fullDomMinhashSignatures"></param>
        /// <param name="responseBodyHashSignatures"></param>
        /// <param name="errors"></param>
        /// <param name="sslCerts"></param>
        /// <param name="sources"></param>
        /// <param name="firstSeen"></param>
        /// <param name="lastSeen"></param>
        /// <param name="count"></param>
        /// <param name="cause"></param>
        /// <param name="referrer"></param>
        /// <param name="redirectUrls"></param>
        /// <param name="redirectType"></param>
        /// <param name="finalUrls"></param>
        /// <param name="finalResponseCodes"></param>
        /// <param name="parkedPage"></param>
        /// <param name="resourceUrls"></param>
        /// <param name="guids"></param>
        /// <param name="finalIpAddresses"></param>
        /// <param name="asns"></param>
        /// <param name="ipBlocks"></param>
        /// <param name="finalAsns"></param>
        /// <param name="finalIpBlocks"></param>
        /// <param name="responseBodies"></param>
        /// <param name="domainAsset"></param>
        /// <param name="rootUrl"></param>
        /// <param name="isRootUrl"></param>
        /// <param name="location"></param>
        /// <param name="services"></param>
        /// <param name="siteStatus"></param>
        /// <param name="cnames"></param>
        /// <param name="cdns"></param>
        /// <param name="host"></param>
        /// <param name="domain"></param>
        /// <param name="sslServerConfig"></param>
        /// <param name="gdprAssetSecurityPolicies"></param>
        /// <param name="ipv4"></param>
        /// <param name="ipv6"></param>
        internal PageAsset(Uri url, string httpMethod, string service, IReadOnlyList<ObservedString> ipAddresses, IReadOnlyList<ObservedBoolean> successful, IReadOnlyList<ObservedInteger> httpResponseCodes, IReadOnlyList<ObservedString> httpResponseMessages, IReadOnlyList<ObservedLong> responseTimes, IReadOnlyList<ObservedBoolean> frames, IReadOnlyList<ObservedBoolean> windows, IReadOnlyList<ObservedBoolean> nonHtmlFrames, IReadOnlyList<ObservedBoolean> undirectedContent, IReadOnlyList<ObservedString> contentTypes, IReadOnlyList<ObservedLong> contentLengths, IReadOnlyList<ObservedString> windowNames, IReadOnlyList<ObservedString> charsets, IReadOnlyList<ObservedString> titles, IReadOnlyList<ObservedString> languages, IReadOnlyList<ObservedHeader> responseHeaders, IReadOnlyList<Cookie> cookies, IReadOnlyList<WebComponent> webComponents, IReadOnlyList<Attribute> attributes, IReadOnlyList<AssetSecurityPolicy> assetSecurityPolicies, IReadOnlyList<ObservedIntegers> responseBodyMinhashSignatures, IReadOnlyList<ObservedIntegers> fullDomMinhashSignatures, IReadOnlyList<ObservedString> responseBodyHashSignatures, IReadOnlyList<ObservedString> errors, IReadOnlyList<SslCertAsset> sslCerts, IReadOnlyList<Source> sources, DateTimeOffset? firstSeen, DateTimeOffset? lastSeen, long? count, PageCause cause, string referrer, IReadOnlyList<ObservedString> redirectUrls, PageAssetRedirectType? redirectType, IReadOnlyList<ObservedString> finalUrls, IReadOnlyList<ObservedInteger> finalResponseCodes, IReadOnlyList<ObservedBoolean> parkedPage, IReadOnlyList<ResourceUrl> resourceUrls, IReadOnlyList<GuidPair> guids, IReadOnlyList<ObservedString> finalIpAddresses, IReadOnlyList<ObservedLong> asns, IReadOnlyList<IpBlock> ipBlocks, IReadOnlyList<ObservedLong> finalAsns, IReadOnlyList<IpBlock> finalIpBlocks, IReadOnlyList<ObservedString> responseBodies, DomainAsset domainAsset, ObservedBoolean rootUrl, bool? isRootUrl, IReadOnlyList<ObservedLocation> location, IReadOnlyList<Service> services, string siteStatus, IReadOnlyList<ObservedString> cnames, IReadOnlyList<ObservedString> cdns, string host, string domain, IReadOnlyList<SslServerConfig> sslServerConfig, IReadOnlyList<AssetSecurityPolicy> gdprAssetSecurityPolicies, IReadOnlyList<ObservedBoolean> ipv4, IReadOnlyList<ObservedBoolean> ipv6)
        {
            Url = url;
            HttpMethod = httpMethod;
            Service = service;
            IpAddresses = ipAddresses;
            Successful = successful;
            HttpResponseCodes = httpResponseCodes;
            HttpResponseMessages = httpResponseMessages;
            ResponseTimes = responseTimes;
            Frames = frames;
            Windows = windows;
            NonHtmlFrames = nonHtmlFrames;
            UndirectedContent = undirectedContent;
            ContentTypes = contentTypes;
            ContentLengths = contentLengths;
            WindowNames = windowNames;
            Charsets = charsets;
            Titles = titles;
            Languages = languages;
            ResponseHeaders = responseHeaders;
            Cookies = cookies;
            WebComponents = webComponents;
            Attributes = attributes;
            AssetSecurityPolicies = assetSecurityPolicies;
            ResponseBodyMinhashSignatures = responseBodyMinhashSignatures;
            FullDomMinhashSignatures = fullDomMinhashSignatures;
            ResponseBodyHashSignatures = responseBodyHashSignatures;
            Errors = errors;
            SslCerts = sslCerts;
            Sources = sources;
            FirstSeen = firstSeen;
            LastSeen = lastSeen;
            Count = count;
            Cause = cause;
            Referrer = referrer;
            RedirectUrls = redirectUrls;
            RedirectType = redirectType;
            FinalUrls = finalUrls;
            FinalResponseCodes = finalResponseCodes;
            ParkedPage = parkedPage;
            ResourceUrls = resourceUrls;
            Guids = guids;
            FinalIpAddresses = finalIpAddresses;
            Asns = asns;
            IpBlocks = ipBlocks;
            FinalAsns = finalAsns;
            FinalIpBlocks = finalIpBlocks;
            ResponseBodies = responseBodies;
            DomainAsset = domainAsset;
            RootUrl = rootUrl;
            IsRootUrl = isRootUrl;
            Location = location;
            Services = services;
            SiteStatus = siteStatus;
            Cnames = cnames;
            Cdns = cdns;
            Host = host;
            Domain = domain;
            SslServerConfig = sslServerConfig;
            GdprAssetSecurityPolicies = gdprAssetSecurityPolicies;
            Ipv4 = ipv4;
            Ipv6 = ipv6;
        }

        /// <summary> Gets the url. </summary>
        public Uri Url { get; }
        /// <summary> Gets the http method. </summary>
        public string HttpMethod { get; }
        /// <summary> Gets the service. </summary>
        public string Service { get; }
        /// <summary> Gets the ip addresses. </summary>
        public IReadOnlyList<ObservedString> IpAddresses { get; }
        /// <summary> Gets the successful. </summary>
        public IReadOnlyList<ObservedBoolean> Successful { get; }
        /// <summary> Gets the http response codes. </summary>
        public IReadOnlyList<ObservedInteger> HttpResponseCodes { get; }
        /// <summary> Gets the http response messages. </summary>
        public IReadOnlyList<ObservedString> HttpResponseMessages { get; }
        /// <summary> Gets the response times. </summary>
        public IReadOnlyList<ObservedLong> ResponseTimes { get; }
        /// <summary> Gets the frames. </summary>
        public IReadOnlyList<ObservedBoolean> Frames { get; }
        /// <summary> Gets the windows. </summary>
        public IReadOnlyList<ObservedBoolean> Windows { get; }
        /// <summary> Gets the non html frames. </summary>
        public IReadOnlyList<ObservedBoolean> NonHtmlFrames { get; }
        /// <summary> Gets the undirected content. </summary>
        public IReadOnlyList<ObservedBoolean> UndirectedContent { get; }
        /// <summary> Gets the content types. </summary>
        public IReadOnlyList<ObservedString> ContentTypes { get; }
        /// <summary> Gets the content lengths. </summary>
        public IReadOnlyList<ObservedLong> ContentLengths { get; }
        /// <summary> Gets the window names. </summary>
        public IReadOnlyList<ObservedString> WindowNames { get; }
        /// <summary> Gets the charsets. </summary>
        public IReadOnlyList<ObservedString> Charsets { get; }
        /// <summary> Gets the titles. </summary>
        public IReadOnlyList<ObservedString> Titles { get; }
        /// <summary> Gets the languages. </summary>
        public IReadOnlyList<ObservedString> Languages { get; }
        /// <summary> Gets the response headers. </summary>
        public IReadOnlyList<ObservedHeader> ResponseHeaders { get; }
        /// <summary> Gets the cookies. </summary>
        public IReadOnlyList<Cookie> Cookies { get; }
        /// <summary> Gets the web components. </summary>
        public IReadOnlyList<WebComponent> WebComponents { get; }
        /// <summary> Gets the attributes. </summary>
        public IReadOnlyList<Attribute> Attributes { get; }
        /// <summary> Gets the asset security policies. </summary>
        public IReadOnlyList<AssetSecurityPolicy> AssetSecurityPolicies { get; }
        /// <summary> Gets the response body minhash signatures. </summary>
        public IReadOnlyList<ObservedIntegers> ResponseBodyMinhashSignatures { get; }
        /// <summary> Gets the full dom minhash signatures. </summary>
        public IReadOnlyList<ObservedIntegers> FullDomMinhashSignatures { get; }
        /// <summary> Gets the response body hash signatures. </summary>
        public IReadOnlyList<ObservedString> ResponseBodyHashSignatures { get; }
        /// <summary> Gets the errors. </summary>
        public IReadOnlyList<ObservedString> Errors { get; }
        /// <summary> Gets the ssl certs. </summary>
        public IReadOnlyList<SslCertAsset> SslCerts { get; }
        /// <summary> Gets the sources. </summary>
        public IReadOnlyList<Source> Sources { get; }
        /// <summary> Gets the first seen. </summary>
        public DateTimeOffset? FirstSeen { get; }
        /// <summary> Gets the last seen. </summary>
        public DateTimeOffset? LastSeen { get; }
        /// <summary> Gets the count. </summary>
        public long? Count { get; }
        /// <summary> Gets the cause. </summary>
        public PageCause Cause { get; }
        /// <summary> Gets the referrer. </summary>
        public string Referrer { get; }
        /// <summary> Gets the redirect urls. </summary>
        public IReadOnlyList<ObservedString> RedirectUrls { get; }
        /// <summary> Gets the redirect type. </summary>
        public PageAssetRedirectType? RedirectType { get; }
        /// <summary> Gets the final urls. </summary>
        public IReadOnlyList<ObservedString> FinalUrls { get; }
        /// <summary> Gets the final response codes. </summary>
        public IReadOnlyList<ObservedInteger> FinalResponseCodes { get; }
        /// <summary> Gets the parked page. </summary>
        public IReadOnlyList<ObservedBoolean> ParkedPage { get; }
        /// <summary> Gets the resource urls. </summary>
        public IReadOnlyList<ResourceUrl> ResourceUrls { get; }
        /// <summary> Gets the guids. </summary>
        public IReadOnlyList<GuidPair> Guids { get; }
        /// <summary> Gets the final ip addresses. </summary>
        public IReadOnlyList<ObservedString> FinalIpAddresses { get; }
        /// <summary> Gets the asns. </summary>
        public IReadOnlyList<ObservedLong> Asns { get; }
        /// <summary> Gets the ip blocks. </summary>
        public IReadOnlyList<IpBlock> IpBlocks { get; }
        /// <summary> Gets the final asns. </summary>
        public IReadOnlyList<ObservedLong> FinalAsns { get; }
        /// <summary> Gets the final ip blocks. </summary>
        public IReadOnlyList<IpBlock> FinalIpBlocks { get; }
        /// <summary> Gets the response bodies. </summary>
        public IReadOnlyList<ObservedString> ResponseBodies { get; }
        /// <summary> Gets the domain asset. </summary>
        public DomainAsset DomainAsset { get; }
        /// <summary> Gets the root url. </summary>
        public ObservedBoolean RootUrl { get; }
        /// <summary> Gets the is root url. </summary>
        public bool? IsRootUrl { get; }
        /// <summary> Gets the location. </summary>
        public IReadOnlyList<ObservedLocation> Location { get; }
        /// <summary> Gets the services. </summary>
        public IReadOnlyList<Service> Services { get; }
        /// <summary> Gets the site status. </summary>
        public string SiteStatus { get; }
        /// <summary> Gets the cnames. </summary>
        public IReadOnlyList<ObservedString> Cnames { get; }
        /// <summary> Gets the cdns. </summary>
        public IReadOnlyList<ObservedString> Cdns { get; }
        /// <summary> Gets the host. </summary>
        public string Host { get; }
        /// <summary> Gets the domain. </summary>
        public string Domain { get; }
        /// <summary> Gets the ssl server config. </summary>
        public IReadOnlyList<SslServerConfig> SslServerConfig { get; }
        /// <summary> Gets the gdpr asset security policies. </summary>
        public IReadOnlyList<AssetSecurityPolicy> GdprAssetSecurityPolicies { get; }
        /// <summary> Gets the ipv 4. </summary>
        public IReadOnlyList<ObservedBoolean> Ipv4 { get; }
        /// <summary> Gets the ipv 6. </summary>
        public IReadOnlyList<ObservedBoolean> Ipv6 { get; }
    }
}
