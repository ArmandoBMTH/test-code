using System.Text.Json;

namespace test_merge
{
    public class ConvertUtils
    {
        public ConvertUtils() { }

        public static string ConvertToString(object obj)
        {
            //Conver object to json.
            return JsonSerializer.Serialize(obj);
        }

        public static string DoNothing()
        {
            return "Do nothing";
        }
    }
}
