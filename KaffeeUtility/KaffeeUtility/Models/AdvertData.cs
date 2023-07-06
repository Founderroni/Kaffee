namespace KaffeeUtility.Models
{
    public struct AdvertDataStruct
    {
        public AdvertDataStruct(string adName, string adUrl, string adRedirectUrl, string adFilePath)
        {
            this.adName = adName;
            this.adUrl = adUrl;
            this.adRedirectUrl = adRedirectUrl;
            this.adFilePath = adFilePath;
        }
        public string adName;
        public string adUrl;
        public string adRedirectUrl;
        public string adFilePath;
    }
}
