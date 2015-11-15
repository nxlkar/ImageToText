using System;
using System.Collections;
using AsciiArt;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SymbolSelectorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] public void Symbol1SelectorTest
    ()
        {
            var i = 24;
            string expected = "#";
            string stringResult = SymbolSelector.ChooseSymbol(i);            
            Assert.AreEqual(expected,stringResult);


            // # < 25
            // @ < 30
            // Ø < 40
            // $ < 45
            // & < 50
            // ¤ < 55
            // ~ < 60
            // · < 65
            // ¨ < 70
            // ´ < 80
            // else " 
        }

        [TestMethod]
        public void Symbol2SelectorTest
            ()
        {
            var i = 29;
            string expected = "@";
            String stringResult = SymbolSelector.ChooseSymbol(i);
            Assert.AreEqual(expected, stringResult);


            // # < 25
            // @ < 30
            // Ø < 40
            // $ < 45
            // & < 50
            // ¤ < 55
            // ~ < 60
            // · < 65
            // ¨ < 70
            // ´ < 80
            // else " 
        }

        [TestMethod]
        public void Symbol3SelectorTest
            ()
        {
            var i = 39;
            string expected = "Ø";
            String stringResult = SymbolSelector.ChooseSymbol(i);
            Assert.AreEqual(expected, stringResult);


            
            // Ø < 40
            // $ < 45
            // & < 50
            // ¤ < 55
            // ~ < 60
            // · < 65
            // ¨ < 70
            // ´ < 80
            // else " 
        }

        [TestMethod]
        public void Symbol4SelectorTest
            ()
        {
            var i = 44;
            string expected = "$";
            String stringResult = SymbolSelector.ChooseSymbol(i);
            Assert.AreEqual(expected, stringResult);


            
            // $ < 45
            // & < 50
            // ¤ < 55
            // ~ < 60
            // · < 65
            // ¨ < 70
            // ´ < 80
            // else " 
        }

        [TestMethod]
        public void Symbol5SelectorTest
            ()
        {
            var i = 49;
            string expected = "&";
            String stringResult = SymbolSelector.ChooseSymbol(i);
            Assert.AreEqual(expected, stringResult);




            // & < 50
            // ¤ < 55
            // ~ < 60
            // · < 65
            // ¨ < 70
            // ´ < 80
            // else " 
        }

        [TestMethod]
        public void Symbol6SelectorTest
            ()
        {
            var i = 54;
            string expected = "¤";
            String stringResult = SymbolSelector.ChooseSymbol(i);
            Assert.AreEqual(expected, stringResult);


            // ¤ < 55
            // ~ < 60
            // · < 65
            // ¨ < 70
            // ´ < 80
            // else " 
        }

        [TestMethod]
        public void Symbol7SelectorTest
            ()
        {
            var i = 59;
            string expected = "~";
            String stringResult = SymbolSelector.ChooseSymbol(i);
            Assert.AreEqual(expected, stringResult);

            // ~ < 60
            // · < 65
            // ¨ < 70
            // ´ < 80
            // else " 
        }

        [TestMethod]
        public void Symbol8SelectorTest
            ()
        {
            var i = 64;
            string expected = "·";
            String stringResult = SymbolSelector.ChooseSymbol(i);
            Assert.AreEqual(expected, stringResult);

            // · < 65
            // ¨ < 70
            // ´ < 80
            // else " 
        }

        [TestMethod]
        public void Symbol9SelectorTest
            ()
        {
            var i = 69;
            string expected = "¨";
            String stringResult = SymbolSelector.ChooseSymbol(i);
            Assert.AreEqual(expected, stringResult);

            // ¨ < 70
            // ´ < 80
            // else " 
        }

        [TestMethod]
        public void Symbol10SelectorTest
            ()
        {
            var i = 79;
            string expected = "´";
            String stringResult = SymbolSelector.ChooseSymbol(i);
            Assert.AreEqual(expected, stringResult);

            // ´ < 80
            // else " 
        }

        [TestMethod]
        public void Symbol11SelectorTest
            ()
        {
            var i = 90;
            string expected = " ";
            String stringResult = SymbolSelector.ChooseSymbol(i);
            Assert.AreEqual(expected, stringResult);
            
        }
    }
}
