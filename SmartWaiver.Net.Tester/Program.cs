namespace SmartWaiver.Net.Tester
{
    internal class Program
    {
        static readonly string _apiKey = "";

        static void Main(string[] args)
        {
            ISmartWaiver smartWaiver = new SmartWaiver(_apiKey);
            var respRAM = smartWaiver.WebhookQueue.RetrieveAccountMessage();

            var respGS = smartWaiver.Waiver.GetSignedWaiver(respRAM.ApiWebhookAccountMessageGet.Payload.UniqueId, true);

            var bytes = Convert.FromBase64String(respGS.Waiver.Pdf);
            File.WriteAllBytes("F:\\test.pdf", bytes);

            Console.ReadLine();
        }
    }
}
