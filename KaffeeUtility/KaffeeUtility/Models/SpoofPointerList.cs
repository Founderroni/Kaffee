namespace KaffeeUtility.Models
{
    public struct SpoofPointersStruct
    {
        public SpoofPointersStruct(string version, string didPtr, string mcidPtr)
        {
            this.version = version;
            this.didPtr = didPtr;
            this.mcidPtr = mcidPtr;
        }
        public string version;
        public string didPtr;
        public string mcidPtr;
    }
}
