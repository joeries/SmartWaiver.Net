using Newtonsoft.Json;

namespace SmartWaiver.Net.Objects
{
    public class SendSmsRequest
    {
        public SendSmsRequest() { }

        [JsonProperty(PropertyName = "templateId")]
        public int TemplateId { get; set; }
        [JsonProperty(PropertyName = "number")]
        public int Number { get; set; }
    }
}
