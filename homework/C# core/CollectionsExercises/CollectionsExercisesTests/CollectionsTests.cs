using System;
using NUnit.Framework;
using CollectionsExercisesLib;
using System.Collections.Generic;
using NUnit.Framework.Internal;

namespace CollectionsExercisesTests
{
    public class DictionaryTests
    {
        [TestCase("", "")]
        [TestCase("abpeituebd,dkrwej'cnsjjs", "")]
        [TestCase("50266400055", "[5, 3][0, 4][2, 1][6, 2][4, 1]")]
        [TestCase("pa55w0rd", "[5, 2][0, 1]")]
        [TestCase("4395862328567590638356894", "[4, 2][3, 4][9, 3][5, 4][8, 4][6, 4][2, 2][7, 1][0, 1]")]
        public void GivenAString_CountDigits_ReturnsACountOfEachDigit(string input, string expectedOutput)
        {
            var result = CollectionsExercises.CountDigits(input);
            Assert.AreEqual(expectedOutput, result);
        }
    }

    public class QueueTest
    {
        Queue<string> _queue;
        [SetUp]
        public void SetUp()
        {
            _queue = new Queue<string>();
            _queue.Enqueue("Cathy");
            _queue.Enqueue("Jim");
            _queue.Enqueue("Petra");
            _queue.Enqueue("Moxie");
            _queue.Enqueue("Petunia");
        }
        [TestCase(3, "Cathy, Jim, Petra")]
        [TestCase(0, "")]
        [TestCase(1, "Cathy")]
        public void GivenANumber_NextInQueue_ReturnsCorrectNames(int num, string expectedNames)
        {

            var result = CollectionsExercises.NextInQueue(num, _queue);
            Assert.AreEqual(expectedNames, result);
        }

        [TestCase(3, 2)]
        [TestCase(0, 5)]
        [TestCase(1, 4)]
        public void GivenANumber_NextInQueue_RemoveExpectedNumberFromTheQueue(int num, int expectedQueueCount)
        {
            var result = CollectionsExercises.NextInQueue(num, _queue);
            Assert.AreEqual(expectedQueueCount, _queue.Count);
        }
        [Test]
        public void NextInQueue_DoesNotThrowException_IfTheQueueIsTooShort()
        {
            var result = CollectionsExercises.NextInQueue(7, _queue);
            Assert.AreEqual(0, _queue.Count);
            Assert.AreEqual("Cathy, Jim, Petra, Moxie, Petunia", result);
        }
    }

    public class StackTest
    {
        [Test]
        public void GivenAnEmptyArray_Reverse_ReturnsAnEmptyArray()
        {
            int[] array = { };
            var result = CollectionsExercises.Reverse(array);
            Assert.AreEqual(0, array.Length);
        }

        [Test]
        public void GivenAnArray_Reverse_ReturnsTheArrayInReverse()
        {
            int[] array = { 10, 20, 30, 40, 50 };
            var result = CollectionsExercises.Reverse(array);
            Assert.AreEqual(5, array.Length);
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(array[4 - i], result[i]);
            }
        }
    }
}