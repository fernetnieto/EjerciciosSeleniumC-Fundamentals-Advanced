namespace Training_Automation_Advanced.Pages.FormsPage
{
    public partial class FormsPage : FormsPageAsserter
    {
        public void GoToFormsPage()  //ya tenemos funcion para navegar especificamente por esta pagina
        {
            Navigate("https://testappautomation.herokuapp.com/forms/");
            //Navigate("https://testappautomation.herokuapp.com");
            //ClickOnItem();
        }
        public void PerformFormsPageGeneralAsserts()  //por lo gral se hacen validaciones generales de la pagina
        //en este caso se puede ver que estoy utilziando los metodo que declaré en la Asserter
        {
            /*
            AssertHomePTitle();
            AssertHomePLoginBTNVisible();
            //falta links no clickeables
            AssertHomePNotLoggedMainTxt();
            AssertHomePNotLoggedSecondTxt();
            //falta footer position: fixed; bottom: 0;
            AssertHomePDisclaimerTxt();
            */


        }
        
        /*public void SearchInBAR(string searchText)  //buscar algo en particular en un elemento en particular
        //haciendo uso como en el caso de Navigate, de funciones de Base
        {
            SetText(searchBAR,searchText);
        }*/


    }
}