using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDeliverQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDeliverQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 配置ID
        /// </summary>
        [JsonPropertyName("config_id")]
        public string ConfigId { get; set; }
    }
}
