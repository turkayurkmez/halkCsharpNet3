namespace Delegations
{
    public static class FilterHelper
    {

        //public delegate bool Criteria(int value);
        public static List<int> Filter(List<int> numberList, Func<int, bool> criteria)
        {
            List<int> filteredNumbers = new List<int>();
            foreach (var item in numberList)
            {
                if (criteria(item))
                {
                    filteredNumbers.Add(item);
                }

            }

            return filteredNumbers;
        }
    }
}
