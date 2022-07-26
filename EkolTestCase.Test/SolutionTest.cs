using System;
using Xunit;

namespace EkolTestCase.Test
{
    public class SolutionTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal( "****bc", Solution.stringSolver(4, "aaaabbc"));
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal("aa*****bbccc", Solution.stringSolver(5, "aabbbbbbbccc"));
        }
        [Fact]
        public void Test3()
        {
            Assert.Equal("abcdaa***bccd", Solution.stringSolver(3, "abcdaabbbbccd"));
        }
    }
}
