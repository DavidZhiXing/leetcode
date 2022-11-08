// An e-commerce site tracks the purchases made each day. The product that is purchased the most one day is the featured product for the following day. If there is a tie for the product purchased most frequently, those product names are ordered alphabetically ascending and the last name in the list is chosen.
// example:
// products = ['redShirt', 'greenPants', 'redShirt', 'orangeShoes', 'blackPants', 'blackPants']
// 
// greenPants and orangeShoes were purchased once.
// 
// redShirt was purchased twice.
// 
// blackPants was purchased twice.
// 
// greenPants and orangeShoes are alphabetically ordered, so orangeShoes is the featured product for the following day.
//

public class result{
    public static string findFeaturedProduct(List<string> products)
    {
        var dict = new Dictionary<string, int>();
        foreach (var product in products)
        {
            if (dict.ContainsKey(product))
            {
                dict[product]++;
            }
            else
            {
                dict.Add(product, 1);
            }
        }
        var result = dict.OrderByDescending(x => x.Value)
                         .ThenBy(x => x.Key)
                         .Select(x => x.Key)
                         .First();
        return result;
    }

    public static void Main(string[] args)
    {
        var products = new List<string> { "redShirt", "greenPants", "redShirt", "orangeShoes", "blackPants", "blackPants" };
        var result = findFeaturedProduct(products);
        Console.WriteLine(result);
    }
}