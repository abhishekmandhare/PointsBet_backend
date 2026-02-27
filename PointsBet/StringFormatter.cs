namespace PointsBet.Backend.Online.Code.Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {
        // Making following assumptions:
        // if quote is null, it will be empty string ""
        // if items array is null, we cannot continue and it will throw argument exception.
        // if items array is empty, it wll return empty string. I think this is less aggresive than throwing exception and caller will not have to additional handle errors.
        // if one of the elements in items array is null empty or just spaces, it will skip over that element and continue with the rest. Reason having an empty , , doesn't make much sense. Other option is to fail the whole function, which to me is excessive and limiting.

        // Improvements
        // 1. Using Linq (select, Where) instead of loop for readability.
        // 2. Fixed typo in function name
        // 3. Fixed edge cases of empty elements
        // 4. Removed redundancy and simplified.
        public static string ToCommaSeparatedList(string[] items, string? quote)
        {
            ArgumentNullException.ThrowIfNull(items);
            return string.Join(", ",  items.Where(item => !string.IsNullOrWhiteSpace(item)).Select(item => $"{quote}{item}{quote}"));
        }
    }
}
