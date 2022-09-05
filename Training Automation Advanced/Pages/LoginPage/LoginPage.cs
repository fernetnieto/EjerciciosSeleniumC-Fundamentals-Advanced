namespace Training_Automation_Advanced.Pages.LoginPage
{
    public partial class LoginPage : LoginPageAsserter
    {       
        public void PerformLoginPEmpty() 
        {
            SetText(loginPUserINPUT," ");
            SetText(loginPPasswordINPUT,"Password");
            ClickOnItem(loginPContinueBTN);
            AssertLoginPEmptyLogin();
        }
        public void PerformLoginPInvalid()
        {
            SetText(loginPUserINPUT,"fernando.e.nieto@accenture.com");
            SetText(loginPPasswordINPUT,"Test1235");  //correcta Test1234
            ClickOnItem(loginPContinueBTN);
            AssertLoginPInvalidLogin();
        }
        public void PerformLoginPValid()
        {
            SetText(loginPUserINPUT,"fernando.e.nieto@accenture.com");
            SetText(loginPPasswordINPUT,"Test1234");
            ClickOnItem(loginPContinueBTN);
            AssertLoginPValidLogin();
        }
    }
}