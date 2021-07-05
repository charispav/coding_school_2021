using System;

namespace FibonacciClassLibrary {
    public class FibonacciCalculator : IFibonacciCalculator {
        
        public long FibonacciSeries(long n) {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else if (n > 1 && n < 90)
                return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
            else if (n < 0)
                throw new ArgumentException("Invalid input", nameof(n));
            else
                throw new ArgumentException("Fibonacci result number too big", nameof(n));
        }
    }
}

