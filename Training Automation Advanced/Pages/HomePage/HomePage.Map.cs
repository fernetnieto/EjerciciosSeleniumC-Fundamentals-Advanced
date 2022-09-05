namespace Training_Automation_Advanced.Pages.Homepage
{
    public partial class HomePageMap : Base  //partial porque son 3 partes de 1 pagina
    {
        //selectores y respectivos webelements
        By homePLoginBtn=By.XPath("//button[@id='loginBTN']");
        public IWebElement homePLoginBTN => WaitAndFindElement(homePLoginBtn);
        By homePLogoutBtn=By.XPath("//button[@id='logoutBTN']");
        protected IWebElement homePLogoutBTN => WaitAndFindElement(homePLogoutBtn);
        By homePAvatarImg=By.XPath("//img[@id='profileIMG']");
        protected IWebElement homePAvatarIMG => WaitAndFindElement(homePAvatarImg);
        By homePProfileTxt=By.XPath("//p[@id='profileTXT']");
        protected IWebElement homePProfileTXT => WaitAndFindElement(homePProfileTxt);
        By homePLoremLink=By.XPath("//a[contains(@href,'lorem')]");
        protected IWebElement homePLoremLINK => WaitAndFindElement(homePLoremLink);
        By homePFormsLink=By.XPath("//a[contains(@href,'forms')]");
        protected IWebElement homePFormsLINK => WaitAndFindElement(homePFormsLink);
        By homePNotLoggedMainTxt=By.XPath("//h1[@id='notLoggedTitleTXT']");
        protected IWebElement homePNotLoggedMainTXT => WaitAndFindElement(homePNotLoggedMainTxt);
        By homePNotLoggedSecondTxt=By.XPath("//h3[@id='notLoggedScreen']");
        protected IWebElement homePNotLoggedSecondTXT => WaitAndFindElement(homePNotLoggedSecondTxt);
        By homePFooter=By.XPath("//footer[contains(@class,'footerClass')]");
        protected IWebElement homePFOOTER => WaitAndFindElement(homePFooter);
        By homePDisclaimerTxt=By.XPath("//p[@id='footerbox']/small");
        protected IWebElement homePDisclaimerTXT => WaitAndFindElement(homePDisclaimerTxt);
    }

}