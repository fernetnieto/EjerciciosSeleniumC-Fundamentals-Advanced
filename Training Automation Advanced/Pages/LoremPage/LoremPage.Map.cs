namespace Training_Automation_Advanced.Pages.LoremPage
{
    public partial class LoremPageMap : Base  //partial porque son 3 partes de 1 página
    {
        By loremPNewsTxt=By.XPath("//div[@id='news']/strong");
        protected IWebElement loremPNewsTXT => WaitAndFindElement(loremPNewsTxt);
        By loremPHiddenTxt=By.XPath("//h1[@id='hiddenText1']");
        protected IWebElement loremPHiddenTXT => WaitAndFindElement(loremPHiddenTxt);
        By loremPSection1Title=By.XPath("//a[@data-testid='TXTtitle1']");
        protected IWebElement loremPSection1TITLE => WaitAndFindElement(loremPSection1Title);
        By loremPSection2Title=By.XPath("//a[@data-testid='TXTtitle2']");
        protected IWebElement loremPSection2TITLE => WaitAndFindElement(loremPSection2Title);        
        By loremPSection3Title=By.XPath("//a[@data-testid='TXTtitle3']");
        protected IWebElement loremPSection3TITLE => WaitAndFindElement(loremPSection3Title);
        By loremPSection4Title=By.XPath("//a[@data-testid='TXTTitle4']");
        protected IWebElement loremPSection4TITLE => WaitAndFindElement(loremPSection4Title);
        By loremPYoutubeBtn=By.XPath("//a[@data-testid='TXTHyperLink1']");
        protected IWebElement loremPYoutubeBTN => WaitAndFindElement(loremPYoutubeBtn);
        By loremPFacebookBtn=By.XPath("//a[@data-testid='TXTHyperLink2']");
        protected IWebElement loremPFacebookBTN => WaitAndFindElement(loremPFacebookBtn);
        By loremPSeleniumBtn=By.XPath("//a[@data-testid='TXTHyperLink3']");
        protected IWebElement loremPSeleniumBTN => WaitAndFindElement(loremPSeleniumBtn);        
    }

}