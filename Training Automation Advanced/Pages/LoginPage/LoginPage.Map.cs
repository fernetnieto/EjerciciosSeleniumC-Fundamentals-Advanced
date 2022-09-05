namespace Training_Automation_Advanced.Pages.LoginPage
{
    public partial class LoginPageMap : Base  //partial porque son 3 partes de 1 página
    {
        By loginPUserInput=By.XPath("//input[@id='username']");
        protected IWebElement loginPUserINPUT => WaitAndFindElement(loginPUserInput);
        By loginPPasswordInput=By.XPath("//input[@id='password']");
        protected IWebElement loginPPasswordINPUT => WaitAndFindElement(loginPPasswordInput);
        By loginPContinueBtn=By.XPath("//button[text()='Continue']");
        protected IWebElement loginPContinueBTN => WaitAndFindElement(loginPContinueBtn);
        By loginPNoEmailTxt=By.XPath("//span[@id='error-element-username']");
        protected IWebElement loginPNoEmailTXT => WaitAndFindElement(loginPNoEmailTxt);
        By loginPWrongEmailPassTxt=By.XPath("//span[@id='error-element-password']");
        protected IWebElement loginPWrongEmailPassTXT => WaitAndFindElement(loginPWrongEmailPassTxt);
    }
}