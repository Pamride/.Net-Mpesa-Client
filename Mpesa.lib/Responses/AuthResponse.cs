using System.Text.Json.Serialization;

namespace Mpesa.lib
{
    public class AuthResponse
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>The access token.</value>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the expiration time of token.
        /// </summary>
        /// <value>The expiration time of token.</value>
        [JsonPropertyName("expires_in")]
        public int Expiration { get; set; }
    }
}
