using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards
{
    //Enum to keep track of all the screens in the app - BH
    public enum NavigationScreen
    {
        DeckList,
        AddDeck,
        EditDeck,
        StudyDeck,
        Help,
        Share
    }
    /*
     * Class containing methods to handle user navigation throughout the app
     */
    public static class NavigationManager
    {
        private static PrimaryForm PF;
        private static NavMenu NavMenuBar;

        private static DeckListPanel DeckListScreen;
        private static AddNewDeckPanel AddDeckScreen;
        private static EditPanel EditDeckScreen;
        private static StudyPanel StudyDeckScreen;
        private static HelpPanel HelpScreen;
        private static SharePanel ShareScreen;

        /*
         * Author: LM
         * Receives reference to parent PrimaryForm in order to check visual order of panels
         */
        public static void GetParent(PrimaryForm pf) {
            PF = pf;
		}

        /*
         * Author: BH
         * Overloads to InitializeControl methods to get navigation references for all of the PrimaryForm's child panels on application start
         */
        public static void InitializeControl(NavMenu ControlToInitialize)
        {
            NavMenuBar = ControlToInitialize;
        }
        public static void InitializeControl(DeckListPanel ControlToInitialize)
        {
            DeckListScreen = ControlToInitialize;
        }
        public static void InitializeControl(AddNewDeckPanel ControlToInitialize)
        {
            AddDeckScreen = ControlToInitialize;
        }
        public static void InitializeControl(EditPanel ControlToInitialize)
        {
            EditDeckScreen = ControlToInitialize;
        }
        public static void InitializeControl(StudyPanel ControlToInitialize)
        {
            StudyDeckScreen = ControlToInitialize;
        }
        public static void InitializeControl(HelpPanel ControlToInitialize)
        {
            HelpScreen = ControlToInitialize;
        }
        public static void InitializeControl(SharePanel ControlToInitialize) {
            ShareScreen = ControlToInitialize;
        }

        /*
         * Author: LS, LM
         * Notes: Levi wrote the majority of the method, Lucas updated it to include the autosave functionality
         * Determine which screen to bring to front of PrimaryForm in order to simulate navigation through the app
         * If the EditDeck screen is currently in front at the time of navigation, then automatically save whichever deck is currently being edited before navigating away
         */
        public static void SetActiveScreen(NavigationScreen ScreenToActivate, int OptionalDeckParameter = 0)
        {
            bool isEditFront = PF.IsFrontPanel(EditDeckScreen);
            if (isEditFront) {
                EditDeckScreen.SaveCurrentDeck();
            }
            switch (ScreenToActivate)
            {
                case NavigationScreen.DeckList:
                    DeckListScreen.ResetSearch();
                    DeckListScreen.LoadDeckPanels();
                    DeckListScreen.BringToFront();
                    NavMenuBar.HighlightDeckListButton();
                    break;
                case NavigationScreen.AddDeck:
                    AddDeckScreen.BringToFront();
                    NavMenuBar.HighlightAddDeckButton();
                    break;
                case NavigationScreen.EditDeck:
                    EditDeckScreen.SetDeckToEdit(OptionalDeckParameter);
                    EditDeckScreen.BringToFront();
                    break;
                case NavigationScreen.StudyDeck:
                    StudyDeckScreen.BringToFront();
                    StudyDeckScreen.SetDeckToStudy(OptionalDeckParameter);
                    break;
                case NavigationScreen.Help:
                    HelpScreen.BringToFront();
                    NavMenuBar.HighlightHelpButton();
                    break;
                case NavigationScreen.Share:
                    ShareScreen.SetDeckList();
                    ShareScreen.BringToFront();
                    NavMenuBar.HighlightShareButton();
                    break;
            }
        }

        /*
         * Author: LM
         * Override of the SetActiveScreen method to allow control over whether or not autosaving occurs
         * Used when a deck is deleted or the save button is clicked on the EditDeck screen becuase autosaving is not desired in either situation
         */
        public static void SetActiveScreen(NavigationScreen ScreenToActivate, bool autoSave, int OptionalDeckParameter = 0) {
            bool isEditFront = PF.IsFrontPanel(EditDeckScreen);
            if (isEditFront && autoSave) {
                EditDeckScreen.SaveCurrentDeck();
            }
            switch (ScreenToActivate) {
                case NavigationScreen.DeckList:
                    DeckListScreen.ResetSearch();
                    DeckListScreen.LoadDeckPanels();
                    DeckListScreen.BringToFront();
                    NavMenuBar.HighlightDeckListButton();
                    break;
                case NavigationScreen.AddDeck:
                    AddDeckScreen.BringToFront();
                    NavMenuBar.HighlightAddDeckButton();
                    break;
                case NavigationScreen.EditDeck:
                    EditDeckScreen.SetDeckToEdit(OptionalDeckParameter);
                    EditDeckScreen.BringToFront();
                    break;
                case NavigationScreen.StudyDeck:
                    StudyDeckScreen.BringToFront();
                    StudyDeckScreen.SetDeckToStudy(OptionalDeckParameter);
                    break;
                case NavigationScreen.Help:
                    HelpScreen.BringToFront();
                    NavMenuBar.HighlightHelpButton();
                    break;
                case NavigationScreen.Share:
                    ShareScreen.SetDeckList();
                    ShareScreen.BringToFront();
                    NavMenuBar.HighlightShareButton();
                    break;
            }
        }
    }

    
}
