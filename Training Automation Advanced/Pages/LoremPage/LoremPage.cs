namespace Training_Automation_Advanced.Pages.LoremPage
{
    public partial class LoremPage : LoremPageAsserter
    {
        
        /*public void SearchInBAR(string searchText)  //buscar algo en particular en un elemento en particular
        //haciendo uso como en el caso de Navigate, de funciones de Base
        {
            SetText(searchBAR,searchText);
        }*/


        //click link/s
        //Valida que logged se permita acceder a link
        public void PerformLoremPLoggedGeneral()
        {

            AssertLoremPTitle();
            AssertLoremPNews();
            AssertLoremPHiddenText();
        
        }
        public void PerformLoremPLoggedSection()
        {
            AssertLoremPSection1Title();
            AssertLoremPSection2Title();
            AssertLoremPSection3Title();
            AssertLoremPSection4Title();

        }

        public void PerformLoremPLoggedYoutubeLink()
        {
            
            AssertLoremPYoutubeLinkVisible();
            ActionScrollToBottom();
            ClickOnItem(loremPYoutubeBTN);  //esta abre en nueva tab
            SelectOtherTab();
            AssertLoremPYoutubeCorrectTab();
            SelectOtherTab();
            CloseOtherTab();

        }


        public void PerformLoremPLoggedFacebookLink()
        {
            
            AssertLoremPFacebookLinkVisible();
            ActionScrollToBottom();
            ClickOnItem(loremPFacebookBTN);  //esta abre en nueva tab (manual abre en la misma, auto abre en otra o.O)
            SelectOtherTab();
            AssertLoremPFacebookCorrectTab();
            SelectOtherTab();
            CloseOtherTab();

        }

        public void PerformLoremPLoggedSeleniumLink()
        {
            
            AssertLoremPSeleniumLinkVisible();
            ActionScrollToBottom();
            ClickOnItem(loremPSeleniumBTN);  //esta abre en nueva tab
            SelectOtherTab();
            AssertLoremPSeleniumCorrectTab();
            SelectOtherTab();
            CloseOtherTab();

        }
    }
}