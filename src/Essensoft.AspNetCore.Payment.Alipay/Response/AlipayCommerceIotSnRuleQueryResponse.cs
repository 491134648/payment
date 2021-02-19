using System.Text.Json.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotSnRuleQueryResponse.
    /// </summary>
    public class AlipayCommerceIotSnRuleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// profile规则列表
        /// </summary>
        [JsonPropertyName("rule_list")]
        public List<ProfileRuleInfo> RuleList { get; set; }
    }
}
