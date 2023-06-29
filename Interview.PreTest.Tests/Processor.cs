using System;
using System.Text;

namespace Interview.PreTest.Tests
{
    internal class Processor
    {
        public Processor()
        {
        }
        public int[] Increment(int[] integerNum)
        {
            var stringNum = GetStringRepresentationFromArray(integerNum);
            var num = int.Parse(stringNum);

            num++;

            return ConvertIntToArray(num);
        }

        private static string GetStringRepresentationFromArray(int[] integerNum)
        {
            return string.Join("", integerNum);
        }

        private static int[] ConvertIntToArray(int num)
        {
            return num.ToString().Select(c => int.Parse(c.ToString())).ToArray();
        }

        #region Refactored Increment

        //public int[] Increment(int[] numbers)
        //{
        //    int num = ConvertArrayToInt(numbers);
        //    num++;

        //    return ConvertIntToArray(num);
        //}

        //private static int ConvertArrayToInt(int[] numbers)
        //{
        //    int result = 0;
        //    int multiplier = 1;

        //    for (int i = numbers.Length - 1; i >= 0; i--)
        //    {
        //        result += numbers[i] * multiplier;
        //        multiplier *= 10;
        //    }

        //    return result;
        //}

        //private static int[] ConvertIntToArray(int num)
        //{
        //    if (num == 0)
        //        return new int[] { 0 };

        //    int temp = num;
        //    int digitCount = 0;

        //    while (temp != 0)
        //    {
        //        temp /= 10;
        //        digitCount++;
        //    }

        //    int[] result = new int[digitCount];
        //    int index = digitCount - 1;

        //    while (num != 0)
        //    {
        //        result[index] = num % 10;
        //        num /= 10;
        //        index--;
        //    }

        //    return result;
        //}

        #endregion

        #region chatgpt Increment
        public class LargeIntegerIncrementer
        {
            public int[] Increment(int[] digits)
            {
                ValidateDigits(digits);

                int lastIndex = digits.Length - 1;
                int carry = 1;

                for (int i = lastIndex; i >= 0; i--)
                {
                    int sum = digits[i] + carry;
                    digits[i] = sum % 10;
                    carry = sum / 10;

                    if (carry == 0)
                        break;
                }

                if (carry == 1)
                {
                    digits = ExpandDigitsArray(digits);
                }

                return digits;
            }

            private void ValidateDigits(int[] digits)
            {
                if (digits == null || digits.Length == 0)
                {
                    throw new ArgumentException("Digits array cannot be null or empty.");
                }

                foreach (int digit in digits)
                {
                    if (digit < 0 || digit > 9)
                    {
                        throw new ArgumentException("Digits array must contain values between 0 and 9 only.");
                    }
                }
            }

            private int[] ExpandDigitsArray(int[] digits)
            {
                int[] expandedArray = new int[digits.Length + 1];
                expandedArray[0] = 1;
                Array.Copy(digits, 0, expandedArray, 1, digits.Length);
                return expandedArray;
            }
        }

        #endregion
    }
}