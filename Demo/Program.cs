
namespace Demo
{
    class Program
    {
        #region Introduction
        //Class Member function
        //static void PrintShapes(int count = 10, string shape = "$_$")
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine($"{shape}");
        //    }
        //}
        #endregion

        #region Value Type Param
        // 1.Passing By Value
        ///static void SWAP(int X, int Y)
        ///{
        ///    Console.WriteLine("====================================");
        ///    int temp = X;
        ///    X = Y;
        ///    Y = temp;
        ///}

        // 2.Passing By Ref
        ///static void SWAP(ref int X,ref int Y)
        ///{
        ///    Console.WriteLine("====================================");
        ///    int temp = X;
        ///    X = Y;
        ///    Y = temp;
        ///}
        #endregion

        #region ReferenceType  {we have problem here}
        // 1.Passing By Value
        /// static int SumOfArray(int[] Arr)
        /// {
        ///     int Result = 0;
        /// 
        ///     if (Arr?.Length > 0)
        ///     {
        ///         Arr[0] = 100;
        ///         for (int i = 0; i < Arr.Length; i++)
        ///         {
        ///             Result += Arr[i];
        ///         }
        ///     }
        /// 
        ///     return Result;
        /// }

        // 2.Passing By Refv
        //static int SumOfArray(ref int[] Arr)
        //{
        //    int Result = 0;

        //    if (Arr?.Length > 0)
        //    {
        //        Arr[0] = 100;
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            Result += Arr[i];
        //        }
        //    }

        //    return Result;
        //}

        #endregion

        #region Passing By Out

        //static void SumMul(int X, int Y, out int Sum, out int Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X * Y;
        //}

        #endregion

        #region Example 02
        static bool CheckCustomerHaveDiscount(int CustomerId,out decimal discount)
        {

            int customerPoint = GetCustomerLoyaltyPoint(CustomerId);

            if (customerPoint > 1000)
            {
                discount = (decimal)customerPoint * 0.1M;
                return true;
            }
            discount = default;
            return false;
        }

        private static int GetCustomerLoyaltyPoint(int customerId)
        {
            if (customerId == 1001)
                return 10_000;
            else if (customerId == 2002)
                return 5_000;
            else
                return 0;
        }
        #endregion

        #region Params Keyword
        static int SumeOfNumberfs(params IEnumerable<int> Numbers)
        {
            int Result = default;
            //if (Numbers?.Length > 0)
            //{
            //    for (int i = 0; i < Numbers.Length; i++)
            //    {
            //        Result += Numbers[i];
            //    }
            //}

            if (Numbers is not null)
            {
                foreach (int Number in Numbers)
                    Result += Number;
            }
            return Result;
        }
        #endregion

        #region Protictive Code
        static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;

                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
                Z = X / Y;

                int[] Arr = { 1, 2, 3, 4, 5, 6 };
                Arr[100] = 22;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
        static void DoSomeProtectiveCode()
        {
            int X, Y, Z;
            do
            {
                Console.WriteLine("Please Enter the First Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out X));
            do
            {
                Console.WriteLine("Please Enter the First Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out Y) || Y == 0);
            Z = X / Y;
            int[] Arr = { 1, 2, 3, 4, 5, 6 };
            if (Arr?.Length > 100)
                Arr[100] = 22;
        }
        #endregion

        // Entery Point
        // static
        static void Main()
        {

            #region Introduction
            /// When We are saying this function is object Momber Or Class Member?
            /// Depeanding On Who will call this function! if
            ///
            /// obj Member => If the calling of this function it will be diffrente betweens alot Objects
            /// Class Member => If the Calling it will to be from the same Object 

            //PrintShapes(10,"*_*"); // Passing Parameters in the same Order
            //PrintShapes(shape: "###", count: 10); // Passing Parameters using Names
            //PrintShapes();

            #endregion

            #region ValueType Parameters [Passing By Value [Input] Vs Passing By Ref[Input Output]] 
            ///int A = 5, B = 10;
            ///
            ///Console.WriteLine($"A: {A}");
            ///Console.WriteLine($"B: {B}");
            ///
            /////SWAP(A, B); //Passing param by Value [Input Paramaters]
            ///              //SWAP(5, 10);            
            ///
            /////SWAP(ref A,ref B); //Passing param by Reference [Input Output Paramaters]
            ///                     //SWAP(A, B);
            ///                     
            ///Console.WriteLine($"A: {A}");
            ///Console.WriteLine($"B: {B}");
            #endregion

            #region 
            // 1.Passing By Value
            //int[] numbers = [1, 2, 3];

            //Console.WriteLine(SumOfArray(ref numbers));
            //Console.WriteLine(numbers[0]);
            #endregion  

            #region Passing by Out

            #region Example 01
            //int A = 3, B = 5/*, SumResult = 0, MulResult = default*/;

            //SumMul(B, A,out int SumResult,out int MulResult); // 3. Passing By out [Output parameter]
            //SumMul(B, A,ref SumResult,ref MulResult); // Passing By ref [Input Output parameter] 
            //                                             But that not the Best becouse i Should Intial it,
            //                                             if i don't need it so the best use out                                                          
            //Console.WriteLine($"Sum = {SumResult}");
            //Console.WriteLine($"Mul = {MulResult}"); 
            #endregion

            #region Example 02

            //int cutormerId = 1001;
            //bool isEligible = false;
            //decimal descountAmount;

            //isEligible = CheckCustomerHaveDiscount(cutormerId, out descountAmount);

            //if (isEligible)
            //    Console.WriteLine($"The Customer is Elgible for Discount  = {descountAmount:c}");
            //else
            //    Console.WriteLine($"The Customer is not Elgible");

            #endregion

            #endregion

            #region Params Keyword

            //int[] nums = new int[] { 1, 2, 3,4};

            //int Result = SumeOfNumberfs(1, 2, 3, 4);
            //Console.WriteLine($"{Result}");
            //Result = SumeOfNumberfs(154, 1, 54, 12, 43, 23, 1);
            //Console.WriteLine($"{Result}");

            //Console.WriteLine("{0} + ", 3, 23);

            #endregion

            #region Protictive Code
            //DoSomeCode();
            //try
            //{
            //    DoSomeProtectiveCode();
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    // Deallocate | Release | Delete | Free | Colese UnManged Resources [Database Connection]
            //    Console.WriteLine("Finally");
            //} 
            #endregion
        }
    }
}
