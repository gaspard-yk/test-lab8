namespace TestProject1
{
    public class Lab1
    {
        public int[] Sort(int[] intArray)
        {
            if (intArray.Length != 0 && intArray.Length != 1)
            {
                int x;
                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    for (int j = i + 1; j < intArray.Length; j++)
                    {
                        if (intArray[j] < intArray[i])
                        {
                            x = intArray[j];
                            intArray[j] = intArray[i];
                            intArray[i] = x;
                        }
                    }
                }
            }
            return intArray;
        }







        public bool IsPalindroml(string str)
        {
            if (str.Length == 0)
                return true;

            for (int i = 0; i < str.Length; i++)
                if (str[i] != str[str.Length - i - 1])
                    return false;
            return true;
        }







        public int getfactorial(int x)
        {
            if (x <= 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                int factorial = 1;
                for (int i = 2; i <= x; i++)
                {
                    factorial = factorial * i;
                }
                return factorial;
            }
        }




        public int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                int fib1 = 1;
                int fib2 = 1;
                int fib_sum = 0;

                for (int i = 0; i < n - 2; i++)
                {
                    fib_sum = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = fib_sum;
                }
                return fib_sum;
            }
        }










        public double real_degree(double x, double y)
        {
            return Math.Pow(x, y);
        }







        public bool issimple(int x)
        {
            if (x <= 0)
            {
                return false;

            }
            else if (x == 1)
            {
                return true;
            }
            else
            {
                int k = 0;
                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0) k++;
                }
                if (k == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
        }
    }
    [TestFixture]



    public class TestClass
    {

        private Lab1 lab1;

        [OneTimeSetUp]
        public void SetUp()
        {
            lab1 = new Lab1();
        }

        [Test]
        [TestCase(new int[] { 3, 15, 12, 15, 2 })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 0, 2 })]
        public void TestSort(int[] x)
        {
            int[] res = x;
            Array.Sort(res);
            Assert.AreEqual(res, lab1.Sort(x), "TestSort");
        }






        [Test]
        [TestCase("pap")]
        [TestCase("")]
        public void TestIsPalindroml(string str)
        {
            Assert.IsTrue(lab1.IsPalindroml(str), "TestIsPalindroml");
        }
        [Test]
        [TestCase("ne")]
        public void TestIsnotPalindroml(string str)
        {
            Assert.IsFalse(lab1.IsPalindroml(str), "TestIsPalindroml");
        }

        [Test]
        public void Testgetfactorial_0()
        {
            Assert.AreEqual(0, lab1.getfactorial(0), "Testgetfactorial_0");
        }
        [Test]
        public void Testgetfactorial_1()
        {
            Assert.AreEqual(5, lab1.getfactorial(1), "Testgetfactorial_1");
        }
        [Test]
        public void Testgetfactorial_2()
        {
            Assert.AreEqual(24, lab1.getfactorial(4), "Testgetfactorial_4");
        }

        [Test]
        public void TestFibonacci_0()
        {
            Assert.AreEqual(0, lab1.Fibonacci(0), "TestFibonacci_0");
        }
        [Test]
        public void TestFibonacci_1()
        {
            Assert.AreEqual(1, lab1.Fibonacci(1), "TestFibonacci_1");
        }
        [Test]
        public void TestFibonacci_2()
        {
            Assert.AreEqual(21, lab1.Fibonacci(8), "TestFibonacci_8");
        }

        [Test]
        [TestCase(2.23, 1.44)]
        [TestCase(1.23, 0.44)]
        public void Testreal_degree(double x, double y)
        {
            double z = Math.Pow(x, y);
            Assert.AreEqual(z, lab1.real_degree(x, y), "Testreal_degree");
        }






        [Test]
        [TestCase(1)]
        [TestCase(13)]
        public void Testissimple(int x)
        {
            Assert.IsTrue(lab1.issimple(x), "Testissimple");
        }
        [Test]
        [TestCase(-2)]
        [TestCase(12)]
        public void Testnotissimple(int x)
        {
            Assert.IsFalse(lab1.issimple(x), "Testisnotsimple");
        }
    }
}
