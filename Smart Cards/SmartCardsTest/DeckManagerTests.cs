using Smart_Cards;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Smart_Cards.Tests {
	[TestClass()]
	public class DeckManagerTests {

		[TestMethod()]
		public void GetDeckFromIdTest() {
			DeckManager.ImportDecksFromJson();
			Deck testDeck = DeckManager.GetDeckFromId(0);
			Assert.IsNotNull(testDeck);
			Assert.IsInstanceOfType(testDeck, typeof(Deck));
		}

		[TestMethod()]
		public void GetNewDeckTest() {
			DeckManager.ImportDecksFromJson();
			int count_orig = DeckManager.getDeckList().Count;
			Deck newDeck = DeckManager.CreateNewDeck();
			int count_new = DeckManager.getDeckList().Count;
			Assert.IsNotNull(newDeck);
			Assert.IsInstanceOfType(newDeck, typeof(Deck));
			Assert.AreEqual(count_new, count_orig + 1);

		}

		[TestMethod()]
		public void DeleteDeckTest() {
			DeckManager.ImportDecksFromJson();
			Dictionary<int, Deck> list = DeckManager.getDeckList();
			int count_before = list.Count;
			DeckManager.DeleteDeck(list[1]);
			int count_after = DeckManager.getDeckList().Count;

			Assert.AreNotEqual(count_after, count_before);
			Assert.AreEqual(count_after, count_before - 1);
		}
	}
}
