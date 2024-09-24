// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents
{
    public partial class SearchOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IncludeTotalCount))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteBooleanValue(IncludeTotalCount.Value);
            }
            if (Optional.IsCollectionDefined(Facets))
            {
                writer.WritePropertyName("facets"u8);
                writer.WriteStartArray();
                foreach (var item in Facets)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            if (Optional.IsDefined(HighlightFieldsRaw))
            {
                writer.WritePropertyName("highlight"u8);
                writer.WriteStringValue(HighlightFieldsRaw);
            }
            if (Optional.IsDefined(HighlightPostTag))
            {
                writer.WritePropertyName("highlightPostTag"u8);
                writer.WriteStringValue(HighlightPostTag);
            }
            if (Optional.IsDefined(HighlightPreTag))
            {
                writer.WritePropertyName("highlightPreTag"u8);
                writer.WriteStringValue(HighlightPreTag);
            }
            if (Optional.IsDefined(MinimumCoverage))
            {
                writer.WritePropertyName("minimumCoverage"u8);
                writer.WriteNumberValue(MinimumCoverage.Value);
            }
            if (Optional.IsDefined(OrderByRaw))
            {
                writer.WritePropertyName("orderby"u8);
                writer.WriteStringValue(OrderByRaw);
            }
            if (Optional.IsDefined(QueryType))
            {
                writer.WritePropertyName("queryType"u8);
                writer.WriteStringValue(QueryType.Value.ToSerialString());
            }
            if (Optional.IsDefined(ScoringStatistics))
            {
                writer.WritePropertyName("scoringStatistics"u8);
                writer.WriteStringValue(ScoringStatistics.Value.ToSerialString());
            }
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsCollectionDefined(ScoringParameters))
            {
                writer.WritePropertyName("scoringParameters"u8);
                writer.WriteStartArray();
                foreach (var item in ScoringParameters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ScoringProfile))
            {
                writer.WritePropertyName("scoringProfile"u8);
                writer.WriteStringValue(ScoringProfile);
            }
            if (Optional.IsDefined(Debug))
            {
                writer.WritePropertyName("debug"u8);
                writer.WriteStringValue(Debug.Value.ToString());
            }
            if (Optional.IsDefined(SearchText))
            {
                writer.WritePropertyName("search"u8);
                writer.WriteStringValue(SearchText);
            }
            if (Optional.IsDefined(SearchFieldsRaw))
            {
                writer.WritePropertyName("searchFields"u8);
                writer.WriteStringValue(SearchFieldsRaw);
            }
            if (Optional.IsDefined(SearchMode))
            {
                writer.WritePropertyName("searchMode"u8);
                writer.WriteStringValue(SearchMode.Value.ToSerialString());
            }
            if (Optional.IsDefined(QueryLanguage))
            {
                writer.WritePropertyName("queryLanguage"u8);
                writer.WriteStringValue(QueryLanguage.Value.ToString());
            }
            if (Optional.IsDefined(Speller))
            {
                writer.WritePropertyName("speller"u8);
                writer.WriteStringValue(Speller.Value.ToString());
            }
            if (Optional.IsDefined(SelectRaw))
            {
                writer.WritePropertyName("select"u8);
                writer.WriteStringValue(SelectRaw);
            }
            if (Optional.IsDefined(Skip))
            {
                writer.WritePropertyName("skip"u8);
                writer.WriteNumberValue(Skip.Value);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("top"u8);
                writer.WriteNumberValue(Size.Value);
            }
            if (Optional.IsDefined(SemanticConfigurationName))
            {
                writer.WritePropertyName("semanticConfiguration"u8);
                writer.WriteStringValue(SemanticConfigurationName);
            }
            if (Optional.IsDefined(SemanticErrorMode))
            {
                writer.WritePropertyName("semanticErrorHandling"u8);
                writer.WriteStringValue(SemanticErrorMode.Value.ToString());
            }
            if (Optional.IsDefined(SemanticMaxWaitInMilliseconds))
            {
                if (SemanticMaxWaitInMilliseconds != null)
                {
                    writer.WritePropertyName("semanticMaxWaitInMilliseconds"u8);
                    writer.WriteNumberValue(SemanticMaxWaitInMilliseconds.Value);
                }
                else
                {
                    writer.WriteNull("semanticMaxWaitInMilliseconds");
                }
            }
            if (Optional.IsDefined(SemanticQuery))
            {
                writer.WritePropertyName("semanticQuery"u8);
                writer.WriteStringValue(SemanticQuery);
            }
            if (Optional.IsDefined(QueryAnswerRaw))
            {
                writer.WritePropertyName("answers"u8);
                writer.WriteStringValue(QueryAnswerRaw);
            }
            if (Optional.IsDefined(QueryCaptionRaw))
            {
                writer.WritePropertyName("captions"u8);
                writer.WriteStringValue(QueryCaptionRaw);
            }
            if (Optional.IsDefined(QueryRewrites))
            {
                writer.WritePropertyName("queryRewrites"u8);
                writer.WriteStringValue(QueryRewrites.Value.ToString());
            }
            if (Optional.IsDefined(SemanticFields))
            {
                writer.WritePropertyName("semanticFields"u8);
                writer.WriteStringValue(SemanticFields);
            }
            if (Optional.IsCollectionDefined(VectorQueries))
            {
                writer.WritePropertyName("vectorQueries"u8);
                writer.WriteStartArray();
                foreach (var item in VectorQueries)
                {
                    writer.WriteObjectValue<VectorQuery>(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FilterMode))
            {
                writer.WritePropertyName("vectorFilterMode"u8);
                writer.WriteStringValue(FilterMode.Value.ToString());
            }
            if (Optional.IsDefined(HybridSearch))
            {
                writer.WritePropertyName("hybridSearch"u8);
                writer.WriteObjectValue(HybridSearch);
            }
            writer.WriteEndObject();
        }

        internal static SearchOptions DeserializeSearchOptions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? count = default;
            IList<string> facets = default;
            string filter = default;
            string highlight = default;
            string highlightPostTag = default;
            string highlightPreTag = default;
            double? minimumCoverage = default;
            string orderby = default;
            SearchQueryType? queryType = default;
            ScoringStatistics? scoringStatistics = default;
            string sessionId = default;
            IList<string> scoringParameters = default;
            string scoringProfile = default;
            QueryDebugMode? debug = default;
            string search = default;
            string searchFields = default;
            SearchMode? searchMode = default;
            QueryLanguage? queryLanguage = default;
            QuerySpellerType? speller = default;
            string select = default;
            int? skip = default;
            int? top = default;
            string semanticConfiguration = default;
            SemanticErrorMode? semanticErrorHandling = default;
            int? semanticMaxWaitInMilliseconds = default;
            string semanticQuery = default;
            string answers = default;
            string captions = default;
            QueryRewritesType? queryRewrites = default;
            string semanticFields = default;
            IList<VectorQuery> vectorQueries = default;
            VectorFilterMode? vectorFilterMode = default;
            HybridSearch hybridSearch = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("facets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    facets = array;
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlight"u8))
                {
                    highlight = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlightPostTag"u8))
                {
                    highlightPostTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlightPreTag"u8))
                {
                    highlightPreTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumCoverage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("orderby"u8))
                {
                    orderby = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryType = property.Value.GetString().ToSearchQueryType();
                    continue;
                }
                if (property.NameEquals("scoringStatistics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scoringStatistics = property.Value.GetString().ToScoringStatistics();
                    continue;
                }
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scoringParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    scoringParameters = array;
                    continue;
                }
                if (property.NameEquals("scoringProfile"u8))
                {
                    scoringProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("debug"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debug = new QueryDebugMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("search"u8))
                {
                    search = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchFields"u8))
                {
                    searchFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    searchMode = property.Value.GetString().ToSearchMode();
                    continue;
                }
                if (property.NameEquals("queryLanguage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryLanguage = new QueryLanguage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("speller"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    speller = new QuerySpellerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("select"u8))
                {
                    select = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skip = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("top"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("semanticConfiguration"u8))
                {
                    semanticConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("semanticErrorHandling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    semanticErrorHandling = new SemanticErrorMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("semanticMaxWaitInMilliseconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        semanticMaxWaitInMilliseconds = null;
                        continue;
                    }
                    semanticMaxWaitInMilliseconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("semanticQuery"u8))
                {
                    semanticQuery = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("answers"u8))
                {
                    answers = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("captions"u8))
                {
                    captions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryRewrites"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryRewrites = new QueryRewritesType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("semanticFields"u8))
                {
                    semanticFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vectorQueries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VectorQuery> array = new List<VectorQuery>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VectorQuery.DeserializeVectorQuery(item));
                    }
                    vectorQueries = array;
                    continue;
                }
                if (property.NameEquals("vectorFilterMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vectorFilterMode = new VectorFilterMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hybridSearch"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hybridSearch = HybridSearch.DeserializeHybridSearch(property.Value);
                    continue;
                }
            }
            return new SearchOptions(
                count,
                facets ?? new ChangeTrackingList<string>(),
                filter,
                highlight,
                highlightPostTag,
                highlightPreTag,
                minimumCoverage,
                orderby,
                queryType,
                scoringStatistics,
                sessionId,
                scoringParameters ?? new ChangeTrackingList<string>(),
                scoringProfile,
                debug,
                search,
                searchFields,
                searchMode,
                queryLanguage,
                speller,
                select,
                skip,
                top,
                semanticConfiguration,
                semanticErrorHandling,
                semanticMaxWaitInMilliseconds,
                semanticQuery,
                answers,
                captions,
                queryRewrites,
                semanticFields,
                vectorQueries ?? new ChangeTrackingList<VectorQuery>(),
                vectorFilterMode,
                hybridSearch);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SearchOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSearchOptions(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
