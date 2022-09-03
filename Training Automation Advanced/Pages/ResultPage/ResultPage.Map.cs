namespace Training_Automation_Advanced.Pages.ResultPage
{
    public partial class ResultPageMap : Base  //partial porque son 3 partes de 1 página
    {
        By resultPPersonalTitleTxt=By.XPath("//span[@id='Title']");
        protected IWebElement resultPPersonalTitleTXT => WaitAndFindElement(resultPPersonalTitleTxt);
        By resultPFirstNameTxt=By.XPath("//span[@id='FirstName']");
        protected IWebElement resultPFirstNameTXT => WaitAndFindElement(resultPFirstNameTxt);       
        By resultPLastNameTxt=By.XPath("//span[@id='LastName']");
        protected IWebElement resultPLastNameTXT => WaitAndFindElement(resultPLastNameTxt);
        By resultPNickNameTxt=By.XPath("//span[@id='NickName']");
        protected IWebElement resultPNickNameTXT => WaitAndFindElement(resultPNickNameTxt);
        By resultPDeveloperTxt=By.XPath("//span[@id='Developer']");
        protected IWebElement resultPDeveloperTXT => WaitAndFindElement(resultPDeveloperTxt);
        By resultPMobileTxt=By.XPath("//span[@id='Mobile']");
        protected IWebElement resultPMobileTXT => WaitAndFindElement(resultPMobileTxt);
        By resultPEmailTxt=By.XPath("//span[@id='Email']");
        protected IWebElement resultPEmailTXT => WaitAndFindElement(resultPEmailTxt);
        By resultPAboutTxt=By.XPath("//span[@id='About']");
        protected IWebElement resultPAboutTXT => WaitAndFindElement(resultPAboutTxt);        
        By resultPUrlTxt=By.XPath("//span[@id='Url']");
        protected IWebElement resultPUrlTXT => WaitAndFindElement(resultPUrlTxt);        


    }

}