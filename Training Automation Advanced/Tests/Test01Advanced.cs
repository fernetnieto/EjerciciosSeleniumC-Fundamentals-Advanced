namespace Training_Automation_Advanced
{
    [TestFixture]
    public class Tests : TestBase  //extiende de TestBase
    {
        [Test]
        //homepage not logged
        //validate page title
        //validate login button exists
        //validate hyperlinks not accessible
        //validate page texts: main and secondary
        //validate disclaimer
        //validate footer
        //validate valid login
        public void TestAdvanced01() 
        {
            homePage.GoToHomePage();
            homePage.PerformHomePNotLoggedGeneral();
            homePage.PerformHomePNotLoggedLink();
            homePage.GoToLoginPage();
            loginPage.PerformLoginPValid();
        }
        [Test]
        //homepage not logged
        //validate links not accesible
        public void TestAdvanced02()
        {
            homePage.GoToHomePage();
            homePage.PerformHomePNotLoggedLink();
        }
        [Test]
        //loginpage
        //login vacio/Invalido/Valido
        public void TestAdvanced03()
        {
            homePage.GoToHomePage();
            homePage.GoToLoginPage();
            //acá ya estoy en la proxima pagina
            loginPage.PerformLoginPEmpty();
            loginPage.PerformLoginPInvalid();
            loginPage.PerformLoginPValid();
            //acá volví a la home page logueado correctamente
        }
       [Test]
        //homepage logged
        //validate login/out button
        //validate profile avatar and text
        //header and footer igual que unlogged
        public void TestAdvanced04()
        {
            homePage.GoToHomePage();
            homePage.GoToLoginPage();
            //aca ya estoy en la proxima pagina
            loginPage.PerformLoginPValid();
            //aca volvi a la home page logueado correctamente
            homePage.PerformHomePLoggedInOutBtn();
            homePage.PeformHomePLoggedAvatarandText();
            //Header and footer igual que unlogged
            homePage.PerformHomePLoggedGeneral();
        }
       [Test]
        //lorem page logged
        //validate hyperlink lorem accessible
        //validate lorem page general - title/news section/hidden text
        //validate sections
        public void TestAdvanced05()
        {
            homePage.GoToHomePage();
            homePage.GoToLoginPage();
            //acá ya estoy en la proxima pagina
            loginPage.PerformLoginPValid();
            //acá volví a la home page logueado correctamente
            homePage.GoToLoremPage();
            loremPage.PerformLoremPLoggedGeneral();
            loremPage.PerformLoremPLoggedSection();
        }
       [Test]
       //lorem page logged
       //validate youtube/facebook/selenium links
        public void TestAdvanced06()
        {
            homePage.GoToHomePage();
            homePage.GoToLoginPage();
            //acá ya estoy en la proxima pagina
            loginPage.PerformLoginPValid();
            //acá volví a la home page logueado correctamente
            homePage.GoToLoremPage();
            loremPage.PerformLoremPLoggedSection();
            loremPage.PerformLoremPLoggedYoutubeLink();
            loremPage.PerformLoremPLoggedFacebookLink();
            loremPage.PerformLoremPLoggedSeleniumLink();
        }
    }
}