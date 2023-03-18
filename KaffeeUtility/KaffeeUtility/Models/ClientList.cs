namespace KaffeeUtility.Models
{
    public struct ClientListStruct
    {
        public ClientListStruct(string displayName, string url, string versionSupported, string fileName)
        {
            this.displayName = displayName;
            this.url = url;
            this.versionSupported = versionSupported;
            this.fileName = fileName;
        }
        public string displayName;
        public string url;
        public string versionSupported;
        public string fileName;
    }
}
