using NUnit.Framework;
using CollectionsExercisesLib;
using System.Collections.Generic;

namespace CollectionsExercisesTests
{
    public class MakeAListTests
    {
        [Test]
        public void IfTheListIsEmptyAnEmptyListIsReturned()
        {
            var argList = new List<string>();
            var result = ListExercises.MakeAList(argList);
            Assert.AreEqual(0, result.Count);
        }
        [Test]
        public void IfTheListHasNoWordsStartingWithAAnEmptyListIsReturned()
        {
            var argList = new List<string> { "Cat", "Dog", "Budgie" };
            var result = ListExercises.MakeAList(argList);
            Assert.AreEqual(0, result.Count);
        }

        [Test]
        public void IfTheListHasTwoWordsStartingWithAListOfSize2IsReturned()
        {
            var argList = new List<string> { "Cat", "Aarvaark", "ant", "Dog", "Budgie" };
            var result = ListExercises.MakeAList(argList);
            Assert.AreEqual(2, result.Count);
        }
        [Test]
        public void IfTheListHasTwoWordsStartingWithATheCorrectWordsAreReturned()
        {
            var argList = new List<string> { "Cat", "Aardvark", "ant", "Dog", "Budgie" };
            var result = ListExercises.MakeAList(argList);
            Assert.Contains("Aardvark", result);
            Assert.Contains("ant", result);
        }
        [Test]
        public void IfTheListHasaWordsStartingWithaTheWordIsReturned()
        {
            var argList = new List<string> { "Cat", "ant", "Dog", "Budgie" };
            var result = ListExercises.MakeAList(argList);
            Assert.AreEqual(1, result.Count);
            Assert.Contains("ant", result);
        }
        [Test]
        public void IfTheListHasaWordsStartingWithATheWordIsReturned()
        {
            var argList = new List<string> { "Cat", "Aardvark", "Dog", "Budgie" };
            var result = ListExercises.MakeAList(argList);
            Assert.AreEqual(1, result.Count);
            Assert.Contains("Aardvark", result);
        }
    }
}