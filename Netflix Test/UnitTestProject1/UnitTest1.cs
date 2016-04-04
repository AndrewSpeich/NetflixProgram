using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netflix_Test;
using NetflixRewrite;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void testGenreMovieName()
        {
            Movie attackoftheqs = new Movie("attack of the Qs", 2);
            Genre comedy = new Genre("Comedy");
            Genre stuff = comedy + attackoftheqs;
            Genre testcompare = new Genre("Comedy");
            Assert.AreEqual(testcompare.Name, stuff.Name);
        }
        [TestMethod]
        public void testGenreMovieAdd()
        {
            Movie attackoftheqs = new Movie("attack of the Qs", 2);
            Genre comedy = new Genre("Comedy");
            Genre stuff = comedy + attackoftheqs;
            Genre testcompare = new Genre("Comedy");
            testcompare.Add(ref attackoftheqs);
            Assert.AreEqual(testcompare.Name, stuff.Name);
        }
        [TestMethod]
        public void testGenreMovieAddList()
        {
            Movie attackoftheqs = new Movie("attack of the Qs", 2);
            Genre comedy = new Genre("Comedy");
            Genre stuff = comedy + attackoftheqs;
            
            Assert.AreEqual(attackoftheqs.genre , comedy.Name);
        }
        [TestMethod]
        public void testGenreShowName()
        {
            Show attackoftheqs = new Show("attack of the Qs", 2);
            Genre comedy = new Genre("Comedy");
            Genre stuff = comedy + attackoftheqs;
            Genre testcompare = new Genre("Comedy");
            Assert.AreEqual(testcompare.Name, stuff.Name);
        }
        [TestMethod]
        public void testGenreShowAdd()
        {
            Show attackoftheqs = new Show("attack of the Qs", 2);
            Genre comedy = new Genre("Comedy");
            Genre stuff = comedy + attackoftheqs;
            Genre testcompare = new Genre("Comedy");
            testcompare.Add(ref attackoftheqs);
            Assert.AreEqual(testcompare.Name, stuff.Name);
        }
        [TestMethod]
        public void testGenreMoviName()
        {
            Show attackoftheqs = new Show("attack of the Qs", 2);
            Genre comedy = new Genre("Comedy");
            Genre stuff = comedy + attackoftheqs;

            Assert.AreEqual(attackoftheqs.genre, comedy.Name);
        }
        [TestMethod]
        public void testMultiMovieAdd()
        {
            Movie attackoftheqs = new Movie("attack of the Qs", 2);
            Movie FlyinCows = new Movie("FlyinCowss", 4);
            Genre comedy = new Genre("Comedy");
            Genre stuff = comedy + attackoftheqs + FlyinCows;
            Genre testcompare = new Genre("Comedy");
            Assert.AreEqual(testcompare.Name, stuff.Name);
        }
        [TestMethod]
        public void testMultiTitleAdd()
        {
            Movie attackoftheqs = new Movie("attack of the Qs", 2);
            Show FlyinCows = new Show("FlyinCowss", 4);
            Genre comedy = new Genre("Comedy");
            Genre stuff = comedy + attackoftheqs + FlyinCows;
            Genre testcompare = new Genre("Comedy");
            Assert.AreEqual(testcompare.Name, stuff.Name);
        }
        [TestMethod]
        public void testGenreGenreAdd()
        {
            Genre action = new Genre("Action");
            Genre comedy = new Genre("Comedy");
            Genre stuff = comedy + action;
            Genre testcompare = new Genre("ComedyAction");
            Assert.AreEqual(testcompare.Name, stuff.Name);
        }
        [TestMethod]
        public void testShowToString()
        {
            Show Batman = new Show("Batman", 0);
            Episode Batmanreturns = new Episode(0);
            Batman.Add(ref Batmanreturns);
            Batman.ToString();
            Assert.AreEqual(Batman.ToString(), "Batman 0");
        }
    }
}
