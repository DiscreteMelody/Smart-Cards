using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Cards
{
    public enum NavigationScreen
    {
        DeckList,
        AddDeck,
        EditDeck,
        StudyDeck,
        Help
    }
    public static class NavigationManager
    {
        private static NavMenu NavMenuBar;

        private static DeckListPanel DeckListScreen;
        private static AddNewDeckPanel AddDeckScreen;
        private static EditPanel EditDeckScreen;
        private static StudyPanel StudyDeckScreen;
        private static HelpPanel HelpScreen;

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

        public static void SetActiveScreen(NavigationScreen ScreenToActivate, int OptionalDeckParameter = 0)
        {
            switch(ScreenToActivate)
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
                    StudyDeckScreen.SetDeckToStudy(OptionalDeckParameter);
                    StudyDeckScreen.BringToFront();
                    break;
                case NavigationScreen.Help:
                    HelpScreen.BringToFront();
                    NavMenuBar.HighlightHelpButton();
                    break;
            }
        }
    }

    
}
