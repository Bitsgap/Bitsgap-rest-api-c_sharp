using API.REST.Enums;
using API.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace API.REST.Model
{
    /// <summary>
    /// Request data
    /// </summary>
    class Request
    {
        #region public property

        /// <summary>
        /// Request method
        /// </summary>
        public MethodType Type { get; set; }

        /// <summary>
        /// User's public API-key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Request parameters in dictionary
        /// </summary>
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// Request parameters in JSON-string
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Request parameters signed by SHA512 HMAC and private API-key
        /// </summary>
        public string Signature { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Create class without additional params
        /// </summary>
        /// <param name="type">Request method</param>
        public Request(MethodType type)
        {
            Type = type;
            Params = new Dictionary<string, string>();
        }

        #endregion

        #region public methods

        /// <summary>
        /// Preparing params for request
        /// </summary>
        /// <param name="public_key">Public API-key</param>
        /// <param name="private_key">Private API-key</param>
        public void Prepare(string public_key, string private_key)
        {
            Key = public_key;
            Params = Params ?? new Dictionary<string, string>();
            Params.Add("key", public_key);

            Data = JsonConvert.SerializeObject(Params);

            Signature = SHA512HMAC.Generate(Data, private_key);
        }

        /// <summary>
        /// Get request string
        /// </summary>
        public string AsRequestString()
        {
            var dict = new Dictionary<string, string>
                {
                    { "key", Key },
                    { "data", Data },
                    { "signature", Signature },
                };

            return string.Join("&", dict.Select(x => string.Format("{0}={1}", x.Key, x.Value)));
        }

        /// <summary>
        /// Format to log
        /// </summary>
        public Dictionary<string, dynamic> ToLog()
        {
            var dict = new Dictionary<string, dynamic>();

            // exclude key
            foreach (var item in Params?.Where(x => x.Key != "key"))
            {
                dict.Add(item.Key, item.Value);
            }

            return dict;
        }

        #endregion
    }
}
