using Newtonsoft.Json;

internal static class SerializeHelpers
{
    public static string ToJson(this Welcome4 self) => JsonConvert.SerializeObject(self, CodeBeautify.Converter.Settings);
}