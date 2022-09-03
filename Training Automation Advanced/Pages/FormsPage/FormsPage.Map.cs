namespace Training_Automation_Advanced.Pages.FormsPage
{
    public partial class FormsPageMap : Base  //partial porque son 3 partes de 1 página
    {

        By formsPFirstNameInput=By.XPath("//input[@id='TXTUser']");
        protected IWebElement formsPFirsNameINPUT => WaitAndFindElement(formsPFirstNameInput);
        By formsPLastNameInput=By.XPath("//input[@id='TXTPass']");
        protected IWebElement formsPLastNameINPUT => WaitAndFindElement(formsPLastNameInput);
        By formsPNickNameInput=By.XPath("//input[@id='TXTNick']");
        protected IWebElement formsPNickNameINPUT => WaitAndFindElement(formsPNickNameInput);
        By formsPEmailInput=By.XPath("//input[@id='TXTEmail']");
        protected IWebElement formsPEmailINPUT => WaitAndFindElement(formsPEmailInput);       
        By formsPUrlInput=By.XPath("//input[@id='TXTUrl']");
        protected IWebElement formsPUrlINPUT => WaitAndFindElement(formsPUrlInput);
        By formsPMobileInput=By.XPath("//input[@id='TXTMobile']");
        protected IWebElement formsPMobileINPUT => WaitAndFindElement(formsPMobileInput);
        //Select
        By formsPPersonalTitleSel=By.XPath("//select[@id='SELTitle']");
        protected IWebElement formsPPersonalTitlePreWEBE => WaitAndFindElement(formsPPersonalTitleSel);
        protected SelectElement formsPPersonalTitleSEL => new SelectElement(formsPPersonalTitlePreWEBE);
        //
        By formsPAboutYouInput=By.XPath("//input[@id='TXTAbout']");
        protected IWebElement formsPAboutYouINPUT => WaitAndFindElement(formsPAboutYouInput);
        By formsPDeveloperYesRadio=By.XPath("//input[@id='RADButDevYes']");
        protected IWebElement formsPDeveloperYesRADIO => WaitAndFindElement(formsPDeveloperYesRadio);
        By formsPDeveloperNoRadio=By.XPath("//input[@id='RADButDevNo']");
        protected IWebElement formsPDeveloperNoRADIO => WaitAndFindElement(formsPDeveloperNoRadio);
        By formsPSubmitBtn=By.XPath("//input[@id='BTNSubmit']");
        protected IWebElement formsPSubmitBTN => WaitAndFindElement(formsPSubmitBtn);
                            

    }

}