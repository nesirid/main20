public static class DictionaryExtensions
{
    // OrderByAge metodu 
    public static Dictionary<string, int> OrderByAge(this Dictionary<string, int> dictionary)
    {
        return dictionary.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
    }
}