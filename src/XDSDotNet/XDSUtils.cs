namespace XDSDotNet
{
    public static class XDSUtils
    {
        public static string PatientID(string id, string authorityId)
        {
            return $"{id}^^^&{authorityId}&ISO";
        }
    }
}