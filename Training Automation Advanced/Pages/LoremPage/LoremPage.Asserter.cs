namespace Training_Automation_Advanced.Pages.LoremPage
{
    public partial class LoremPageAsserter : LoremPageMap
    //se extiende de Map porque vamos a estar utilizando los elementos ubicados allí
    {
        public void AssertLoremPTitle() => Assert.AreEqual("Lorem Ipsum Page",Title(),"No se encuentra en la pagina deseada.");
        public void AssertLoremPNews()
        {
            Assert.AreEqual(true,loremPNewsTXT.Displayed,"No se encuentra la seccion news.");
            Assert.AreEqual("Notice: This is a testing site meant to be used for automation test trainings",GetText(loremPNewsTXT),"Texto de news no coincide.");
            
        }
        public void AssertLoremPHiddenText()
        {           
            string visibilityAttribute = loremPHiddenTXT.GetCssValue("visibility");
            Assert.AreEqual("hidden",visibilityAttribute,"Elemento hiddenText1 se encuentra visible.");
            //linea de abajo retorna vacio en GetText(loremPHiddenTXT) elemento con visibility hidden
            //Assert.AreEqual("Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...",GetText(loremPHiddenTXT),"Elemento hiddenText1 con texto incorrecto.");
        }

        public void AssertLoremPSection1Title() => Assert.AreEqual(true,loremPSection1TITLE.Displayed,"Seccion 1 no se encuentra."); 
        public void AssertLoremPSection2Title() => Assert.AreEqual(true,loremPSection2TITLE.Displayed,"Seccion 2 no se encuentra.");
        public void AssertLoremPSection3Title() => Assert.AreEqual(true,loremPSection3TITLE.Displayed,"Seccion 3 no se encuentra.");
        public void AssertLoremPSection4Title() => Assert.AreEqual(true,loremPSection4TITLE.Displayed,"Seccion 4 no se encuentra.");
        public void AssertLoremPYoutubeLinkVisible() => Assert.AreEqual(true,loremPYoutubeBTN.Displayed,"Caja Youtube no encontrada.");
        public void AssertLoremPFacebookLinkVisible() => Assert.AreEqual(true,loremPFacebookBTN.Displayed,"Caja Facebook no encontrada.");
        public void AssertLoremPSeleniumLinkVisible() => Assert.AreEqual(true,loremPSeleniumBTN.Displayed,"Caja Selenium no encontrada.");
        public void AssertLoremPYoutubeCorrectTab() => Assert.AreEqual("YouTube",Title(),"Pagina incorrecta.");    
        public void AssertLoremPFacebookCorrectTab() => Assert.AreEqual("Facebook - log in or sign up",Title(),"Pagina incorrecta.");
        public void AssertLoremPSeleniumCorrectTab() => Assert.AreEqual("Selenium",Title(),"Pagina incorrecta.");


    }


}