using System.Collections.ObjectModel;

namespace Transverse._Common.Dictionary;

public static class DictionaryExtension
{
    public static string ToKeyValueString<V>(this IDictionary<string, V> dictionary, string keyValueSeparator = ";", string quoteValueSymbol = "", string keyValueEqualitySymbol = "=") 
    {
        var retour = string.Empty;
        
        ICollection<string> strings = new Collection<string>();
        string str;
        foreach (var keyValue in dictionary)
        {
            str = $"{keyValue.Key}{keyValueEqualitySymbol}{quoteValueSymbol}{keyValue.Value}{quoteValueSymbol}";
            strings.Add(str);
        }

        retour = string.Join(keyValueSeparator, strings);

        return retour;
    }
}