using System;
using FluentAssertions;

namespace FluentAssertionsCheckpoint
{
    class Program
    {
            public class exampleClass {
            public void additionMethod() {
                var first = 3;
                var second = 7;
                var result = first + second;

                result.Should().Be(10);
            }
            }
        static void Main(string[] args)
        {

        }
    }
}
