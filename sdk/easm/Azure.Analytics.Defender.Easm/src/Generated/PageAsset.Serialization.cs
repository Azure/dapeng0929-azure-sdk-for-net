// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class PageAsset
    {
        internal static PageAsset DeserializePageAsset(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> url = default;
            Optional<string> httpMethod = default;
            Optional<string> service = default;
            Optional<IReadOnlyList<ObservedString>> ipAddresses = default;
            Optional<IReadOnlyList<ObservedBoolean>> successful = default;
            Optional<IReadOnlyList<ObservedInteger>> httpResponseCodes = default;
            Optional<IReadOnlyList<ObservedString>> httpResponseMessages = default;
            Optional<IReadOnlyList<ObservedLong>> responseTimes = default;
            Optional<IReadOnlyList<ObservedBoolean>> frames = default;
            Optional<IReadOnlyList<ObservedBoolean>> windows = default;
            Optional<IReadOnlyList<ObservedBoolean>> nonHtmlFrames = default;
            Optional<IReadOnlyList<ObservedBoolean>> undirectedContent = default;
            Optional<IReadOnlyList<ObservedString>> contentTypes = default;
            Optional<IReadOnlyList<ObservedLong>> contentLengths = default;
            Optional<IReadOnlyList<ObservedString>> windowNames = default;
            Optional<IReadOnlyList<ObservedString>> charsets = default;
            Optional<IReadOnlyList<ObservedString>> titles = default;
            Optional<IReadOnlyList<ObservedString>> languages = default;
            Optional<IReadOnlyList<ObservedHeader>> responseHeaders = default;
            Optional<IReadOnlyList<Cookie>> cookies = default;
            Optional<IReadOnlyList<WebComponent>> webComponents = default;
            Optional<IReadOnlyList<Attribute>> attributes = default;
            Optional<IReadOnlyList<AssetSecurityPolicy>> assetSecurityPolicies = default;
            Optional<IReadOnlyList<ObservedIntegers>> responseBodyMinhashSignatures = default;
            Optional<IReadOnlyList<ObservedIntegers>> fullDomMinhashSignatures = default;
            Optional<IReadOnlyList<ObservedString>> responseBodyHashSignatures = default;
            Optional<IReadOnlyList<ObservedString>> errors = default;
            Optional<IReadOnlyList<SslCertAsset>> sslCerts = default;
            Optional<IReadOnlyList<Source>> sources = default;
            Optional<DateTimeOffset> firstSeen = default;
            Optional<DateTimeOffset> lastSeen = default;
            Optional<long> count = default;
            Optional<PageCause> cause = default;
            Optional<string> referrer = default;
            Optional<IReadOnlyList<ObservedString>> redirectUrls = default;
            Optional<PageAssetRedirectType> redirectType = default;
            Optional<IReadOnlyList<ObservedString>> finalUrls = default;
            Optional<IReadOnlyList<ObservedInteger>> finalResponseCodes = default;
            Optional<IReadOnlyList<ObservedBoolean>> parkedPage = default;
            Optional<IReadOnlyList<ResourceUrl>> resourceUrls = default;
            Optional<IReadOnlyList<GuidPair>> guids = default;
            Optional<IReadOnlyList<ObservedString>> finalIpAddresses = default;
            Optional<IReadOnlyList<ObservedLong>> asns = default;
            Optional<IReadOnlyList<IpBlock>> ipBlocks = default;
            Optional<IReadOnlyList<ObservedLong>> finalAsns = default;
            Optional<IReadOnlyList<IpBlock>> finalIpBlocks = default;
            Optional<IReadOnlyList<ObservedString>> responseBodies = default;
            Optional<DomainAsset> domainAsset = default;
            Optional<ObservedBoolean> rootUrl = default;
            Optional<bool> isRootUrl = default;
            Optional<IReadOnlyList<ObservedLocation>> location = default;
            Optional<IReadOnlyList<Service>> services = default;
            Optional<string> siteStatus = default;
            Optional<IReadOnlyList<ObservedString>> cnames = default;
            Optional<IReadOnlyList<ObservedString>> cdns = default;
            Optional<string> host = default;
            Optional<string> domain = default;
            Optional<IReadOnlyList<SslServerConfig>> sslServerConfig = default;
            Optional<IReadOnlyList<AssetSecurityPolicy>> gdprAssetSecurityPolicies = default;
            Optional<IReadOnlyList<ObservedBoolean>> ipv4 = default;
            Optional<IReadOnlyList<ObservedBoolean>> ipv6 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("httpMethod"u8))
                {
                    httpMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("service"u8))
                {
                    service = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    ipAddresses = array;
                    continue;
                }
                if (property.NameEquals("successful"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item));
                    }
                    successful = array;
                    continue;
                }
                if (property.NameEquals("httpResponseCodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedInteger> array = new List<ObservedInteger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedInteger.DeserializeObservedInteger(item));
                    }
                    httpResponseCodes = array;
                    continue;
                }
                if (property.NameEquals("httpResponseMessages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    httpResponseMessages = array;
                    continue;
                }
                if (property.NameEquals("responseTimes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLong> array = new List<ObservedLong>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLong.DeserializeObservedLong(item));
                    }
                    responseTimes = array;
                    continue;
                }
                if (property.NameEquals("frames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item));
                    }
                    frames = array;
                    continue;
                }
                if (property.NameEquals("windows"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item));
                    }
                    windows = array;
                    continue;
                }
                if (property.NameEquals("nonHtmlFrames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item));
                    }
                    nonHtmlFrames = array;
                    continue;
                }
                if (property.NameEquals("undirectedContent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item));
                    }
                    undirectedContent = array;
                    continue;
                }
                if (property.NameEquals("contentTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    contentTypes = array;
                    continue;
                }
                if (property.NameEquals("contentLengths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLong> array = new List<ObservedLong>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLong.DeserializeObservedLong(item));
                    }
                    contentLengths = array;
                    continue;
                }
                if (property.NameEquals("windowNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    windowNames = array;
                    continue;
                }
                if (property.NameEquals("charsets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    charsets = array;
                    continue;
                }
                if (property.NameEquals("titles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    titles = array;
                    continue;
                }
                if (property.NameEquals("languages"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    languages = array;
                    continue;
                }
                if (property.NameEquals("responseHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedHeader> array = new List<ObservedHeader>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedHeader.DeserializeObservedHeader(item));
                    }
                    responseHeaders = array;
                    continue;
                }
                if (property.NameEquals("cookies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Cookie> array = new List<Cookie>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Cookie.DeserializeCookie(item));
                    }
                    cookies = array;
                    continue;
                }
                if (property.NameEquals("webComponents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebComponent> array = new List<WebComponent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebComponent.DeserializeWebComponent(item));
                    }
                    webComponents = array;
                    continue;
                }
                if (property.NameEquals("attributes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Attribute> array = new List<Attribute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Attribute.DeserializeAttribute(item));
                    }
                    attributes = array;
                    continue;
                }
                if (property.NameEquals("assetSecurityPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssetSecurityPolicy> array = new List<AssetSecurityPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssetSecurityPolicy.DeserializeAssetSecurityPolicy(item));
                    }
                    assetSecurityPolicies = array;
                    continue;
                }
                if (property.NameEquals("responseBodyMinhashSignatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedIntegers> array = new List<ObservedIntegers>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedIntegers.DeserializeObservedIntegers(item));
                    }
                    responseBodyMinhashSignatures = array;
                    continue;
                }
                if (property.NameEquals("fullDomMinhashSignatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedIntegers> array = new List<ObservedIntegers>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedIntegers.DeserializeObservedIntegers(item));
                    }
                    fullDomMinhashSignatures = array;
                    continue;
                }
                if (property.NameEquals("responseBodyHashSignatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    responseBodyHashSignatures = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("sslCerts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SslCertAsset> array = new List<SslCertAsset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SslCertAsset.DeserializeSslCertAsset(item));
                    }
                    sslCerts = array;
                    continue;
                }
                if (property.NameEquals("sources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Source> array = new List<Source>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Source.DeserializeSource(item));
                    }
                    sources = array;
                    continue;
                }
                if (property.NameEquals("firstSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastSeen"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSeen = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cause"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cause = PageCause.DeserializePageCause(property.Value);
                    continue;
                }
                if (property.NameEquals("referrer"u8))
                {
                    referrer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("redirectUrls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    redirectUrls = array;
                    continue;
                }
                if (property.NameEquals("redirectType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redirectType = new PageAssetRedirectType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("finalUrls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    finalUrls = array;
                    continue;
                }
                if (property.NameEquals("finalResponseCodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedInteger> array = new List<ObservedInteger>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedInteger.DeserializeObservedInteger(item));
                    }
                    finalResponseCodes = array;
                    continue;
                }
                if (property.NameEquals("parkedPage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item));
                    }
                    parkedPage = array;
                    continue;
                }
                if (property.NameEquals("resourceUrls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceUrl> array = new List<ResourceUrl>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceUrl.DeserializeResourceUrl(item));
                    }
                    resourceUrls = array;
                    continue;
                }
                if (property.NameEquals("guids"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GuidPair> array = new List<GuidPair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GuidPair.DeserializeGuidPair(item));
                    }
                    guids = array;
                    continue;
                }
                if (property.NameEquals("finalIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    finalIpAddresses = array;
                    continue;
                }
                if (property.NameEquals("asns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLong> array = new List<ObservedLong>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLong.DeserializeObservedLong(item));
                    }
                    asns = array;
                    continue;
                }
                if (property.NameEquals("ipBlocks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IpBlock> array = new List<IpBlock>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IpBlock.DeserializeIpBlock(item));
                    }
                    ipBlocks = array;
                    continue;
                }
                if (property.NameEquals("finalAsns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLong> array = new List<ObservedLong>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLong.DeserializeObservedLong(item));
                    }
                    finalAsns = array;
                    continue;
                }
                if (property.NameEquals("finalIpBlocks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IpBlock> array = new List<IpBlock>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IpBlock.DeserializeIpBlock(item));
                    }
                    finalIpBlocks = array;
                    continue;
                }
                if (property.NameEquals("responseBodies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    responseBodies = array;
                    continue;
                }
                if (property.NameEquals("domainAsset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainAsset = DomainAsset.DeserializeDomainAsset(property.Value);
                    continue;
                }
                if (property.NameEquals("rootUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rootUrl = ObservedBoolean.DeserializeObservedBoolean(property.Value);
                    continue;
                }
                if (property.NameEquals("isRootUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRootUrl = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedLocation> array = new List<ObservedLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedLocation.DeserializeObservedLocation(item));
                    }
                    location = array;
                    continue;
                }
                if (property.NameEquals("services"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Service> array = new List<Service>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Easm.Service.DeserializeService(item));
                    }
                    services = array;
                    continue;
                }
                if (property.NameEquals("siteStatus"u8))
                {
                    siteStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cnames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    cnames = array;
                    continue;
                }
                if (property.NameEquals("cdns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedString> array = new List<ObservedString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedString.DeserializeObservedString(item));
                    }
                    cdns = array;
                    continue;
                }
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslServerConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SslServerConfig> array = new List<SslServerConfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Easm.SslServerConfig.DeserializeSslServerConfig(item));
                    }
                    sslServerConfig = array;
                    continue;
                }
                if (property.NameEquals("gdprAssetSecurityPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssetSecurityPolicy> array = new List<AssetSecurityPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssetSecurityPolicy.DeserializeAssetSecurityPolicy(item));
                    }
                    gdprAssetSecurityPolicies = array;
                    continue;
                }
                if (property.NameEquals("ipv4"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item));
                    }
                    ipv4 = array;
                    continue;
                }
                if (property.NameEquals("ipv6"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ObservedBoolean> array = new List<ObservedBoolean>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObservedBoolean.DeserializeObservedBoolean(item));
                    }
                    ipv6 = array;
                    continue;
                }
            }
            return new PageAsset(url.Value, httpMethod.Value, service.Value, Optional.ToList(ipAddresses), Optional.ToList(successful), Optional.ToList(httpResponseCodes), Optional.ToList(httpResponseMessages), Optional.ToList(responseTimes), Optional.ToList(frames), Optional.ToList(windows), Optional.ToList(nonHtmlFrames), Optional.ToList(undirectedContent), Optional.ToList(contentTypes), Optional.ToList(contentLengths), Optional.ToList(windowNames), Optional.ToList(charsets), Optional.ToList(titles), Optional.ToList(languages), Optional.ToList(responseHeaders), Optional.ToList(cookies), Optional.ToList(webComponents), Optional.ToList(attributes), Optional.ToList(assetSecurityPolicies), Optional.ToList(responseBodyMinhashSignatures), Optional.ToList(fullDomMinhashSignatures), Optional.ToList(responseBodyHashSignatures), Optional.ToList(errors), Optional.ToList(sslCerts), Optional.ToList(sources), Optional.ToNullable(firstSeen), Optional.ToNullable(lastSeen), Optional.ToNullable(count), cause.Value, referrer.Value, Optional.ToList(redirectUrls), Optional.ToNullable(redirectType), Optional.ToList(finalUrls), Optional.ToList(finalResponseCodes), Optional.ToList(parkedPage), Optional.ToList(resourceUrls), Optional.ToList(guids), Optional.ToList(finalIpAddresses), Optional.ToList(asns), Optional.ToList(ipBlocks), Optional.ToList(finalAsns), Optional.ToList(finalIpBlocks), Optional.ToList(responseBodies), domainAsset.Value, rootUrl.Value, Optional.ToNullable(isRootUrl), Optional.ToList(location), Optional.ToList(services), siteStatus.Value, Optional.ToList(cnames), Optional.ToList(cdns), host.Value, domain.Value, Optional.ToList(sslServerConfig), Optional.ToList(gdprAssetSecurityPolicies), Optional.ToList(ipv4), Optional.ToList(ipv6));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PageAsset FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePageAsset(document.RootElement);
        }
    }
}
