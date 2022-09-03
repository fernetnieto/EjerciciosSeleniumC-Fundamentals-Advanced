
namespace Training_Automation_Advanced.Core
{
    public class TestBase : Base  //extiende de Base
    {

        public static HomePage homePage;  //creo el objeto pagina
        public static LoginPage loginPage;
        public static LoremPage loremPage;
        //public static FormsPage formsPage;

        [SetUp]
        public void SetUp()  
        {
            SetUpDriver();
            homePage=new HomePage();  //inicializo las variables de pagina en el setup
            loginPage=new LoginPage();
            loremPage=new LoremPage();
            //formsPage=new FormsPage();
        }

        [TearDown]
        public void TearDown()  
        {
            //TearDownDriver();
        }

    }
}