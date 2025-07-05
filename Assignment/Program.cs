using System.Text;

namespace Assignment
{
    internal class Program
    {
        #region 1.Passing [ValueType] By [Value] and By[Reference]
        #region 1.1 Passing [ValueType] By [Value]
        //static void SwapByValue(int X, int Y)
        //{
        //    Console.WriteLine("==============SWAP================");
        //    // Dosn't Make Changed in Original variable
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        #endregion

        #region 1.2 Passing [ValueType] By [Reference]
        //static void SWAP(ref int X,ref int Y)
        //{
        //    Console.WriteLine("==============SWAP================");
        //    // Change in Original variable
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        #endregion
        #endregion

        #region 2.Passing [ReferenceType] By [Value] and By[Reference]
        #region 2.1 Passing [ReferenceType] By [Value]
        static int ChangeArray(int[] Arr) // Arr = Numbers = [1,2,3,4,5]
        {
            int Result = 0;

            /// /*Example 1*/  Arr[0] = 100; // initiated in Fram of Funciotn in STACK
            ///                            // so Here it also Refer to Numbers array in HEAP
            ///                            // It will be Also Change in Numbers array
            ///                            // Numbers = [100,2,3,4,5]

            /*Example 2 */  Arr = new int[] { 4, 5, 6 };   // initiated in Fram of Funciotn in STACK
                                                           // so Here it Was Refer to Numbers array in HEAP
                                                           // But Now After `NEW` it will Refer to Another Array in HEAP
                                                           // So It will be Not Make any Change in `Numbers` array or Original Array
                                                           // so it Still Numbers = [1,2,3,4,5]
            return Result;
        }
        #endregion

        #region 2.2 Passing [ReferenceType] By [Reference]
        static int ChangeArray(ref int[] Arr) // Arr(Numbers) = [1,2,3,4,5]
        {
            int Result = 0;

            /// /*Example 1*/ Arr[0] = 100; // Not Initiated in Fram of Funciotn in STACK But Refer to Number array
            ///                         // it just like rename the array to be `Arr` rather than `Numbers`,
            ///                         // it Will Make Change in Orignal array
            ///                         // So After excuting function, Numbers = [100,2,3,4,5]  

           /// /*Example 2 */               // Not Initiated in Fram of Funciotn in STACK But Refer to Number array
           ///                              // is just like rename the to be `Arr` rather than `Numbers` So now the Two Arrays are The Same,
           /// Arr = new int[] { 4, 5, 6 }; // So Here `Arr` it Will be Refer to New Object of Type Array in HEAP ,
           ///                              // Than MEEN The Numbers Array it also Refer To NEW Object of Type Array in HEAP
           ///                              // So it Will Make Change in Orignal array `Numbers`
           ///                              // So After excuting function, Numbers = [4,5,6] 
           ///
           /// // The Diffrance Happend Between passing by value and passing by ref When Use [Input Output parameters]
           return Result; 
        }
        #endregion
        #endregion

        #region 3.Summation and Subtracting 

        static void SumMul(int X, int Y, out int Sum, out int Sub)
        {
            Sum = X + Y;
            Sub = X - Y;
        }

        #endregion

        #region 4.Individual Digits Of Number
        static int IndividualDigitOfNumber(int Number,out int Result)
        {
            Result = 0;

            string[] arrOfDigits = Number.ToString().Select(x =>x.ToString()).ToArray();

            foreach (string digit in arrOfDigits) 
            {
                int num = Convert.ToInt32(digit);
                Result = Result + num;
            }
            return Result;
        }

        #endregion

        #region 5. Is Prime
        static bool IsPrime(int Number)
        {
            if (Number < 2)
                return false;
            else
                for (int a = 2; a <= Number / 2; a++)
                    if (Number % a == 0)
                        return true;
            return false;
        }
        #endregion

        #region 6.Min Max Array
        static object MinMaxArray(int[] Arr, ref int min, ref int max)
        {
            min = Arr.Min();
            max = Arr.Max();
            return new { min, max };
        }
        #endregion

        #region 7.Calc Factorial Of The Number
        static long GetFactorilOfTheNumber(int Number)
        {
            long factor = 1;
            if (Number == 0)
                return 1;
            else
                for (int i = 1; i <= Number; i++)
                {
                    factor *= i;
                }
            return factor;
        }
        #endregion

        #region 8.Change Char
        static string ChangeChar(string str, char NewChar,int oldCharPosition)
        {
            StringBuilder sb = new StringBuilder(str);
            sb[oldCharPosition] = NewChar;
            str = sb.ToString();
            return str;
        }
        #endregion

        static void Main()
        {
            #region 1.Passing [ValueType] By [Value] and By[Reference]

            #region 1.1 Passing [ValueType] By [Value]
            //int A = 20, B = 30;
            //Console.WriteLine($"A: {A}"); // 20
            //Console.WriteLine($"B: {B}"); // 30

            //SwapByValue(A, B); // Passing the Value (Or Just like Take a Copy from Value) and NOT The address of Variable
            //            // And use it In Function As a [Input]

            //            // So that dosn't Make any Change in variable
            //Console.WriteLine($"A: {A}"); // 20
            //Console.WriteLine($"B: {B}"); // 30
            #endregion

            #region 1.2 Passing [ValueType] By [Reference]
            //int A = 20, B = 30;
            //Console.WriteLine($"A: {A}"); // 20
            //Console.WriteLine($"B: {B}"); // 30

            //SWAP(ref A,ref B); // Passing the Reference (Address)  Of Variable
            //                   // So When Make any Change in Function that Also Make Change in Original variable

            //// Here Will Make Changes In Values
            //Console.WriteLine($"A: {A}"); // 30
            //Console.WriteLine($"B: {B}"); // 20
            #endregion

            #endregion

            #region 2.Passing [ReferenceType] By [Value] and By[Reference]

            #region 2.1 Passing [ReferenceType] By [Value]
            //int[] Numbers = [1, 2, 3, 4, 5];

            //Ex 1
            ///ChangeArray(Numbers); // Passing By Value 
            ///                      // ChangeArray(TheAddressOfNumbers)
            ///Console.WriteLine(Numbers[0]); // 100 Rather Than 1
            ///So the Result it will to be the same but with diffrante Behaviors

            //Ex 2
            /// ChangeArray(Numbers); // Passing By Value [Input Parameter]
            ///                       // ChangeArray(TheAddressOfNumbers)
            /// 
            /// Console.WriteLine(Numbers[0]); // 1

            #endregion

            #region 2.2 Passing [ReferenceType] By [Reference]
            //int[] Numbers = [1, 2, 3, 4, 5];

            //Ex 1
            ///ChangeArray(ref Numbers); // Passing By Ref [Input Parameter]
            ///                          // ChangeArray(TheAddressOfNumbers)
            ///Console.WriteLine(Numbers[0]); // 100 Rather Than 1
            ///So the Result it will to be the same but with diffrante Behaviors

            //Ex 2
            ///ChangeArray(ref Numbers); // Passing By Ref [Input Output Parameter]
            ///                          // ChangeArray(TheAddressOfNumbers)
            ///Console.WriteLine(Numbers[0]); // 4 Rather Than 1


            #endregion

            #endregion

            #region 3.Summation and Subtracting 
            //int A, B;
            //do
            //{
            //    Console.Write("Enter Number A: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out  A));
            //do
            //{
            //    Console.Write("Enter Number B: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out B));

            //SumMul(A,B, out int SumResult, out int SubResult);

            //Console.WriteLine($"Summation  = {SumResult}");
            //Console.WriteLine($"Subtracting  = {SubResult}");
            #endregion

            #region 4.Individual Digits Of Number
            //int Number,Result;
            //do
            //{
            //    Console.Write($"Enter a number: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Number));

            //IndividualDigitOfNumber(Number,out Result);

            //Console.WriteLine($"The sum of the digits of the number {Number} is: {Result}");
            #endregion

            #region 5. Is Prime

            //int Number;
            //do
            //{
            //    Console.Write($"Enter a number: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Number));
            //if (IsPrime(Number))
            //    Console.WriteLine($"Your Number is Prime number");
            //else
            //    Console.WriteLine($"Your Number is Not Prime number");
            #endregion

            #region 6.Min Max Array
            //int MinNumber = default;
            //int MaxNumber = default;
            //int[] array = { 1, 2,3, 4, 5 };

            //Console.WriteLine(MinMaxArray(array, ref MinNumber, ref MaxNumber).ToString());
            #endregion

            #region 7.Calc Factorial Of The Number
            //Console.WriteLine(GetFactorilOfTheNumber(5)); 
            #endregion

            #region 8.Change Char
            //string str = "Mina Erian";
            //int position = 1;

            //Console.WriteLine(ChangeChar(str, 'e', position));
            #endregion

        }
    }
}
