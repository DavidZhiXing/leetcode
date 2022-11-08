// given an array of numbers, some numbers appear twice and others appear once.
// 
// example:
// [4,3,2,7,8,2,3,1]
// output:
// [2,3]
// 
// input:
// [1,2,1,2,3,1,2,1]
// output:
// [1,2]

public class Result{
    
    public static List<int> FindAllDuplicatesWithLinq(List<int> arr)
    {
        return arr.GroupBy(x => x)
                  .Where(g => g.Count() > 1)
                  .Select(g => g.Key)
                  .OrderBy(x => x)
                  .ToList();
    }

}
