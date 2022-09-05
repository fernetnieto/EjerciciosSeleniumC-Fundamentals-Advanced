namespace Training_Automation_Advanced.Pages.Homepage
{
    public partial class HomePageAsserter : HomePageMap
    //se extiende de Map porque vamos a estar utilizando los webelementos ubicados allí
    {
        public void AssertHomePTitle() => Assert.AreEqual("Homme Page",Title(),"Titulo incorrecto.");
        public void AssertHomePLoginBTNVisible() => Assert.AreEqual(true,homePLoginBTN.Displayed,"Boton de Login no se muestra."); 
        public void AssertHomePLoginBTNNotVisible()
        {
            try
            {
                Assert.AreEqual(false,homePLoginBTN.Displayed,"Boton de Login no se muestra.");
            }
            catch(NoSuchElementException)
            {
                System.Console.WriteLine("Boton de Login no se muestra.");
            }
        }
        public void AssertHomePLogoutBTNVisible() => Assert.AreEqual(true,homePLogoutBTN.Displayed,"Boton de Logout no se muestra.");   
        public void AssertHomePAvatarVisible() => Assert.AreEqual(true,homePAvatarIMG.Displayed,"No se muestra la imagen de avatar.");
        public void AssertHomePProfileTXTAtLeft()
        {
            //obtengo estilos con funcion implementada en Base y con ese valor realizo assert
            string floatAttribute = GetStyle(homePAvatarIMG,"float");
            Assert.AreEqual("right",floatAttribute,"Texto de bienvenida no se encuentra a la izq de la imagen de avatar.");
            string profileText = GetText(homePProfileTXT);
            Assert.AreEqual("Welcome fernando.e.nieto !",profileText,"Incorrect profile text.");   
        }   
        //Valida que unlogged no se permita acceder a links
        public void AssertHomePNotLoggedClickOnLorem() =>  Assert.AreEqual("Please click Login button to log into the application or sign up!",GetText(homePNotLoggedSecondTXT),"Sitio accesible deslogueado.");
        public void AssertHomePNotLoggedClickOnForms() => Assert.AreEqual("Please click Login button to log into the application or sign up!",GetText(homePNotLoggedSecondTXT),"Sitio accesible deslogueado");
        public void AssertHomePNotLoggedMainTxt() => Assert.AreEqual("Welcome to my Atomation Testing Site",homePNotLoggedMainTXT.Text,"Not logged main text no coincide.");
        public void AssertHomePNotLoggedSecondTxt() => Assert.AreEqual("Please click Login button to log into the application or sign up!",homePNotLoggedSecondTXT.Text,"Not logged second text no coincide.");
        //Validar que footer -> position: fixed; bottom: 0;
        public void AssertHomePVerifyFooter()
        {
            //obtengo estilos con funcion implementada en Base y con ese valor realizo assert
            string positionAttribute = GetStyle(homePFOOTER,"position");
            string bottomAttribute = GetStyle(homePFOOTER,"bottom");
            Assert.AreEqual("fixed",positionAttribute,"Footer not fixed.");
            Assert.AreEqual("0px",bottomAttribute,"Footer not at bottom.");
        }
        public void AssertHomePDisclaimerTxt() => Assert.AreEqual("Disclaimer: This project is a personal site meant to be used as a help test site to be able to perform some automation test on demand.",homePDisclaimerTXT.Text,"Disclaimer no coincide.");
    }
}