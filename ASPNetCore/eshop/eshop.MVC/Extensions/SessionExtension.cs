using System.Text.Json;

namespace eshop.MVC.Extensions
{
    public static class SessionExtension
    {
        public static void SetJson<T>(this ISession session, string key, T value)
        {
            var serialized = JsonSerializer.Serialize(value);
            session.SetString(key, serialized);
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var objectString = session.GetString(key);
            return objectString == null ? default(T) : JsonSerializer.Deserialize<T>(objectString);
        }
    }
}
