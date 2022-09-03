namespace Training_Automation_Advanced.Pages.ResultPage
{
    public partial class ResultPageAsserter : ResultPageMap
    //se extiende de Map porque vamos a estar utilizando los elementos ubicados allí
    {
        public void AssertResultPTitle() => Assert.AreEqual(Title(),"Result Page");
        /*
        //public void AssertGoogleIMGVisible() => Assert.AreEqual(true,googleIMG.Displayed);
        //public void AssertSearchBARVisible() => Assert.AreEqual(true,searchBAR.Displayed);
        public void AssertHomePLoginBTNVisible() => Assert.AreEqual(true,homePLoginBTN.Displayed);

        //Validar que links no sean clickeables

        public void AssertHomePNotLoggedMainTxt() => Assert.AreEqual(homePNotLoggedMainTXT.Text,"Welcome to my Automation Testing Site");
        public void AssertHomePNotLoggedSecondTxt() => Assert.AreEqual(homePNotLoggedSecondTXT.Text,"Please click Login button to log into the application or sign up!");

        //Validar que footer -> position: fixed; bottom: 0;

        public void AssertHomePDisclaimerTxt() => Assert.AreEqual(homePDisclaimerTXT.Text,"Disclaimer: This project is a personal site meant to be used as a help test site to be able to perform some automation test on demand");
        */

        



    }
}
