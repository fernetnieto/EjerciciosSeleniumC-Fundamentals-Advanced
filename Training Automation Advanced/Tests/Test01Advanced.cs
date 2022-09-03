namespace Training_Automation_Advanced
{
    [TestFixture]
    public class Tests : TestBase  //extiende de TestBase
    {


        [Test]
        public void TestAdvanced01()
        {
            homePage.GoToHomePage();
            homePage.PerformHomePNotLoggedGeneral();
            homePage.GoToLoginPage();
            loginPage.PerformLoginPValid();
            homePage.PeformHomePLoggedAvatarandText();

        }
        
        [Test]
        public void TestAdvanced02()
        {
            homePage.GoToHomePage();
            homePage.PerformHomePNotLoggedLink();
            loginPage.PerformLoginPValid();

        }

        [Test]
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
        public void TestAdvanced04()
        {
            homePage.GoToHomePage();
            homePage.GoToLoginPage();
            //acá ya estoy en la proxima pagina
            loginPage.PerformLoginPValid();
            //acá volví a la home page logueado correctamente
            
            //validar logout button aparece y login no aparece
            //validar avatar y texto de perfil
            homePage.PerformHomePLoggedInOutBtn();
            homePage.PeformHomePLoggedAvatarandText();

            //Header and footer igual q unlogged
            homePage.PerformHomePLoggedGeneral();
            

        }
            

       [Test]
        public void TestAdvanced05()
        {

            homePage.GoToHomePage();
            homePage.GoToLoginPage();
            //acá ya estoy en la proxima pagina
            loginPage.PerformLoginPValid();
            //acá volví a la home page logueado correctamente
            //click links
            homePage.GoToLoremPage();
            loremPage.PerformLoremPLoggedGeneral();

        }

       [Test]
        public void TestAdvanced06()
        {

            homePage.GoToHomePage();
            homePage.GoToLoginPage();
            //acá ya estoy en la proxima pagina
            loginPage.PerformLoginPValid();
            //acá volví a la home page logueado correctamente
            //click links
            homePage.GoToLoremPage();
            loremPage.PerformLoremPLoggedSection();
            loremPage.PerformLoremPLoggedYoutubeLink();
            loremPage.PerformLoremPLoggedFacebookLink();
            loremPage.PerformLoremPLoggedSeleniumLink();

        }


    }


}