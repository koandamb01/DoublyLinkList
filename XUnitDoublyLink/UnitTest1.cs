using System;
using Xunit;
using DoublyLink;

namespace XUnitDoublyLink
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(7)]
        public void GetTailTest(int expect)
        {
            DoublyLinkList d = new DoublyLinkList();
            d.AddToTail(5);
            d.AddToTail(1);
            d.AddToTail(14);
            d.AddToTail(7);
            Assert.Equal(expect, d.GetTail());
        }

        //[Theory]
        //[InlineData(5)]
        //[InlineData(3)]
        //public void AddToTail(int expect)
        //{
        //    Assert.Equal(expect, DoublyLink.DoublyLinkList.GetTail());
        //}


    }
}
