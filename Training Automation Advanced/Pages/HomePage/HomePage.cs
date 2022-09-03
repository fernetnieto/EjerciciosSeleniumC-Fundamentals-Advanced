namespace Training_Automation_Advanced.Pages.Homepage
{
    public partial class HomePage : HomePageAsserter
    {
        public void GoToHomePage()  //ya tenemos funcion para navegar especificamente por esta pagina
        {
            Navigate("https://testappautomation.herokuapp.com");
            Thread.Sleep(3000);
        }
        
        public void GoToLoginPage()  //navegar desde homepage a loginpage
        {
            ClickOnItem(homePLoginBTN);
            Thread.Sleep(3000);
            
        }

        public void GoToLoremPage()
        {
            ClickOnItem(homePLoremLINK);
            Thread.Sleep(3000);
        }
        
        public void PerformHomePNotLoggedGeneral()  //validaciones generales de la pagina
        //utilizando los metodo que declare en la Asserter
        {
            AssertHomePTitle();
            AssertHomePLoginBTNVisible();
            AssertHomePNotLoggedMainTxt();
            AssertHomePNotLoggedSecondTxt();
            AssertHomePDisclaimerTxt();
            AssertHomePVerifyFooter();


        }

        public void PerformHomePNotLoggedLink()
        {
            ClickOnItem(homePLoremLINK);
            AssertHomePNotLoggedClickOnLorem();
            GoToHomePage();
            ClickOnItem(homePFormsLINK);
            AssertHomePNotLoggedClickOnForms();
            GoToHomePage();
        }

        public void PerformHomePLoggedInOutBtn()
        {
            AssertHomePLoginBTNNotVisible();
            AssertHomePLogoutBTNVisible();
        }

        public void PeformHomePLoggedAvatarandText()
        {
            AssertHomePAvatarVisible();
            AssertHomePProfileTXTAtLeft();
        }

        //Header and footer igual q unlogged
        public void PerformHomePLoggedGeneral()
        {
            AssertHomePTitle();
            AssertHomePLogoutBTNVisible();
            AssertHomePDisclaimerTxt();
            AssertHomePVerifyFooter();
        }
            
  
            

    }
}