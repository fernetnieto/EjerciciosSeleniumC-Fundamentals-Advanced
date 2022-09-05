namespace Training_Automation_Advanced.Pages.LoremPage
{
    public partial class LoremPage : LoremPageAsserter
    {
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
            CloseNotMainTab();
        }
        public void PerformLoremPLoggedFacebookLink()
        {            
            AssertLoremPFacebookLinkVisible();
            ActionScrollToBottom();
            ClickOnItem(loremPFacebookBTN);  //esta abre en nueva tab (manual abre en la misma, auto abre en otra o.O)
            SelectOtherTab();
            AssertLoremPFacebookCorrectTab();
            CloseNotMainTab();
        }
        public void PerformLoremPLoggedSeleniumLink()
        {   
            AssertLoremPSeleniumLinkVisible();
            ActionScrollToBottom();
            ClickOnItem(loremPSeleniumBTN);  //esta abre en nueva tab
            SelectOtherTab();
            AssertLoremPSeleniumCorrectTab();
            CloseNotMainTab();
        }
    }
}