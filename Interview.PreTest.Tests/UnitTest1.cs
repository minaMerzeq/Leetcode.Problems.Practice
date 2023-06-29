namespace Interview.PreTest.Tests
{
    public class UnitTest1
    {
        /*ou are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
         * The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

            Increment the large integer by one and return the resulting array of digits.
            Input: digits = [1,2,3]
            Output: [1,2,4]
            Explanation: The array represents the integer 123.
            Incrementing by one gives 123 + 1 = 124.
            Thus, the result should be [1,2,4].

        Input: digits = [9]
        Output: [1,0]
        Explanation: The array represents the integer 9.
        Incrementing by one gives 9 + 1 = 10.
        Thus, the result should be [1,0].

             */

        // 9 + 1 = 10
        // 10 > 9
        // string 
        // intger 
        // add + 1
        // string
        // array

        [Fact]
        public void Test1()
        {
            var processor = new Processor();
            int[] integerNum = {9};
            int[] expected = {1, 0};

            var result = processor.Increment(integerNum);

            Assert.Equal(expected, result);
        }
    }
}