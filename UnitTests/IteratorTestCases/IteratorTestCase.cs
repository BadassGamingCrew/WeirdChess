﻿// <auto-generated />
namespace UnitTests.IteratorTestCases
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using WeirdChess.Interfaces;
    using WeirdChess.Utilities;

    [TestClass]
    public class IteratorTestCase : AbstractIteratorTestCase
    {
        [ClassInitialize]
        public static void Init(TestContext context)
        {
            BaseInit(context);
        }

        protected override IIterator<string> GetStringIterator(ICollection<string> stringCollection)
        {
            return new Iterator<string>(stringCollection);
        }

        protected override IIterator<string> GetStringIterator(ICollection<string> stringCollection, int startIndex)
        {
            return new Iterator<string>(stringCollection, startIndex);
        }

        protected override IIterator<string> GetStringIterator(ICollection<string> stringCollection, int startIndex, int endIndex)
        {
            return new Iterator<string>(stringCollection, startIndex, endIndex);
        }

        protected override IIterator<int> GetIntIterator(ICollection<int> intCollection)
        {
            return new Iterator<int>(intCollection);
        }

        protected override IIterator<int> GetIntIterator(ICollection<int> intCollection, int startIndex)
        {
            return new Iterator<int>(intCollection, startIndex);
        }

        protected override IIterator<int> GetIntIterator(ICollection<int> intCollection, int startIndex, int endIndex)
        {
            return new Iterator<int>(intCollection, startIndex, endIndex);
        }
    }
}