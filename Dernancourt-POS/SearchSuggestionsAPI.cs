using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dernancourt_POS
{
    public class SearchSuggestionsAPI
    {
        /// <summary>
        /// The Google Suggest search URL.
        /// </summary>
        /// <remarks>
        /// Add gl=dk for Google Denmark. Add lr=lang_da for danish results. Add hl=da to indicate the language of the UI making the request.
        /// </remarks>
        private const string _suggestSearchUrl = "http://www.google.com/complete/search?output=toolbar&q={0}&hl=en";

        /// <summary>
        /// Gets the search suggestions from Google.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>A list of <see cref="GoogleSuggestion"/>s.</returns>
        public async Task<List<GoogleSuggestion>> GetSearchSuggestions(string query)
        {
            if (String.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentException("Argument cannot be null or empty!", "query");
            }

            string result = String.Empty;

            using (HttpClient client = new HttpClient())
            {
                result = await client.GetStringAsync(String.Format(_suggestSearchUrl, query));
            }

            XDocument doc = XDocument.Parse(result);

            var suggestions = from suggestion in doc.Descendants("CompleteSuggestion")
                              select new GoogleSuggestion
                              {
                                  Phrase = suggestion.Element("suggestion").Attribute("data").Value
                              };

            return suggestions.ToList();
        }
    }

    /// <summary>
    /// Encapsulates a suggestion from Google.
    /// </summary>
    public class GoogleSuggestion
    {
        /// <summary>
        /// Gets or sets the phrase.
        /// </summary>
        /// <value>The phrase.</value>
        public string Phrase { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.Phrase;
        }
    }
}