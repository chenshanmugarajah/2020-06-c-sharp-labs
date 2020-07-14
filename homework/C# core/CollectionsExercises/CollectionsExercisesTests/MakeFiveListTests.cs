using NUnit.Framework;
using CollectionsExercisesLib;

namespace CollectionsExercisesTests
{
    public class MakeFiveListTests
    {
        [TestCase(0)]
        public void WhenNis0TheListisEmpty(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            Assert.AreEqual(0, result.Count);
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void WhenNis1to4TheListisEmpty(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            Assert.AreEqual(0, result.Count);
        }

        [TestCase(5)]
        [TestCase(7)]
        [TestCase(9)]
        public void WhenNis5to9TheListHasOneElement(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            Assert.AreEqual(1, result.Count);
        }

        [TestCase(5)]
        [TestCase(7)]
        [TestCase(9)]
        public void WhenNis5to9TheListContains5(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            Assert.AreEqual(5, result[0]);
        }

        [TestCase(95)]
        [TestCase(97)]
        [TestCase(99)]
        public void WhenNis95to99TheListHas19Elements(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            Assert.AreEqual(19, result.Count);
        }

        [TestCase(95)]
        [TestCase(97)]
        [TestCase(99)]
        public void WhenNis95to99TheLastElementIs95(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            var lastPos = result.Count - 1;
            Assert.AreEqual(95, result[lastPos]);
        }
    }
}