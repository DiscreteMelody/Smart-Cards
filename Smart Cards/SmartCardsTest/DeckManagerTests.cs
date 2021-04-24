using Smart_Cards;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Smart_Cards.Tests {
	/*
	 * Author: LM
	 * Class created to perform unit tests of deck management functionality
	 * All methods begin by calling DeckManager.ImportDecksFromJson for 2 reasons: 
	 * 1) There is no official method to unit test file I/O functionality, the only way to test if it works is just to try it
	 * 2) DeckManager does not contain any data to test on until it reads in the file and the data does not persist between test methods, which requires that every test method read in the data independently
	 */
	[TestClass()]
	public class DeckManagerTests {

		/*
		 * Tests whether a Deck object can be retrieved from the master DeckList by its id
		 * Fails if the deck is null, the returned object is not an instance of the Deck class, or if the returned Deck does not have the specified id
		 */
		[TestMethod()]
		public void GetDeckFromIdTest() {
			DeckManager.ImportDecksFromJson();
			Deck testDeck = DeckManager.GetDeckFromId(0);

			Assert.IsNotNull(testDeck);
			Assert.IsInstanceOfType(testDeck, typeof(Deck));
			Assert.AreEqual(testDeck.Id, 0);
		}

		/*
		 * Tests whether a new Deck can be created, added to the DeckList, and returned
		 * Gets the length of the DeckList before and after adding a new Deck and keeps track of the returned deck
		 * Fails if the new deck is null, the returned object is not an instance of the Deck class, or if the DeckList length does not increase by 1 after adding the new Deck
		 */
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

		/*
		 * Tests whether a deck can be removed from the master DeckList
		 * Gets the entire DeckList and picks a random Deck from the list to delete. Keeps track of the length of the list before and after deleting
		 * Fails if the length of the list is the same before and after deletion (having both of these assert condition is probably unnecessary, but I figured better safe than sorry)
		 */
		[TestMethod()]
		public void DeleteDeckTest() {
			Random rand = new Random();

			DeckManager.ImportDecksFromJson();
			Dictionary<int, Deck> list = DeckManager.getDeckList();
			int index = rand.Next(list.Count);
			int count_before = list.Count;
			DeckManager.DeleteDeck(list[index]);
			int count_after = DeckManager.getDeckList().Count;

			Assert.AreNotEqual(count_after, count_before);
			Assert.AreEqual(count_after, count_before - 1);
		}
	}
}
