namespace UI.Extensions;

public static class URLExtensions
{
    public static string ToBaseURL(this ConfigurationManager config)
    {
        return config.GetSection("APIAddress").Value;
    }
    public static string ToAddressURL(this ConfigurationManager config)
    {
        string baseAddress = config.GetSection("APIAddress").Value;
        if (baseAddress.Substring(baseAddress.Length - 1, 1) != "/") baseAddress += "/";
        var url = config.GetSection("APIEndpoints").GetSection("Address").Value;
        return baseAddress + url;
    }
    public static string ToURL(this ConfigurationManager config)
    {
        return config.GetSection("APIEndpoints").GetSection("").Value;
    }

}
