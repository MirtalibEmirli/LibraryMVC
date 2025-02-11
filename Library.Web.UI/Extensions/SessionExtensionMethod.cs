using Newtonsoft.Json;

namespace Library.Web.UI.Extensions;

public static class SessionExtensionMethod
{
    public static void SetObject(this ISession session, string key, object obj)
    {
        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto // Store type information
        };

        string objectString = JsonConvert.SerializeObject(obj, settings);
        session.SetString(key, objectString);
    }



    public static T GetObject<T>(this ISession session, string key) where T : class
    {
        string valueString = session.GetString(key);
        if (string.IsNullOrEmpty(valueString))
            return default;

        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto // This ensures interfaces and abstract classes get deserialized properly
        };

        return JsonConvert.DeserializeObject<T>(valueString, settings);
    }
}
