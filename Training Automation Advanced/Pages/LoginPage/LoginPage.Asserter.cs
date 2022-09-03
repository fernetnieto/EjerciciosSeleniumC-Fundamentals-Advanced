namespace Training_Automation_Advanced.Pages.LoginPage
{
    public partial class LoginPageAsserter : LoginPageMap
    //se extiende de Map porque vamos a estar utilizando los elementos ubicados allí
    {
   
        //validar login con user empty
        public void AssertLoginPEmptyLogin()
        {
            Assert.AreEqual(true,loginPNoEmailTXT.Displayed,"Mensaje de error no desplegado.");
            Assert.IsTrue(Title().Contains("Log in"),"Pagina Web ha cambiado.");
            
            //public void AssertHomePLoginBTNVisible() => Assert.AreEqual(true,homePLoginBTN.Displayed);
            //ClickOnItem(homePLoremLINK);
            //string texto1 = GetText(homePNotLoggedSecondTXT);
            //Assert.AreEqual(texto1,"Please click Login button to log into the application or sign up!");
            //Navigate("https://testappautomation.herokuapp.com");
        }

        //validar login con pass incorrecta
        public void AssertLoginPInvalidLogin()
        {

            Assert.AreEqual(true,loginPWrongEmailPassTXT.Displayed,"Mensaje de error no desplegado.");
            Assert.IsTrue(Title().Contains("Log in"),"Pagina web incorrecta.");        
        }

        //validar login valido
        public void AssertLoginPValidLogin()
        {

            Assert.IsTrue(Title().Contains("Homme Page"),"Pagina web incorrecta."); 
        }
    }


}