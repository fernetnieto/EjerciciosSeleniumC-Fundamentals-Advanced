

namespace Training_Automation_Advanced.Core
{
    public class Base
    {
        protected static IWebDriver driver;
        protected static Actions actions;
        protected static WebDriverWait wait;
        public void SetUpDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver=new ChromeDriver();
            driver.Manage().Window.Maximize();

            //fix para un error al correr tests
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback += (sender, certificate, chain, errors) =>{return true;};



        }

        public void ActionScrollToBottom()
        {
            actions = new Actions(driver);
            actions.KeyDown(Keys.Control).SendKeys(Keys.End).Perform();
            actions.KeyDown(Keys.Control).Release().Perform();

        }



        public void TearDownDriver()
        {
            Thread.Sleep(3000);
            driver.Close();
            //driver.Quit();
        }
        public string Title()
        {
            Thread.Sleep(3000);
            return driver.Title;
        }
        public void Navigate(string url)
        {
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl(url);
        }
        public void NavigateBack()
        {
            Thread.Sleep(3000);
            driver.Navigate().Back();
        }
        public IWebElement WaitAndFindElement(By locator)
        {
            Thread.Sleep(3000);
            return driver.FindElement(locator);
        }
        public void SetText(IWebElement element, string text)
        {
            Thread.Sleep(3000);
            element.Clear();
            element.SendKeys(text);
            
        }
        public void TypeEnter(IWebElement element)
        {
            Thread.Sleep(3000);
            element.SendKeys(Keys.Enter);
        }
        public string GetText(IWebElement element)
        {
            Thread.Sleep(3000);
            return element.Text;
        }
        public void ClickOnItem(IWebElement element)
        {
            Thread.Sleep(3000);
            element.Click();
        }

        //public string GetStyle(string element,string styleProperty)
        public string GetStyle(IWebElement element, string styleProperty)
        {
            Thread.Sleep(3000);
            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //string value = (string)js.ExecuteScript("return window.getComputedStyle(document.querySelectorAll('"+element+"')[0])."+styleProperty);
            //return value;
            //obtengo el valor de la propiedad de estilo deseada

            return element.GetCssValue(styleProperty);
        }

        //seleccionar en elemento select
        public void SelectOptionByText(SelectElement selectElement, string optionString)
        {
            Thread.Sleep(3000);
            selectElement.SelectByText(optionString);
        }

        public void SelectOtherTab()
        {
            string originalWindow = driver.CurrentWindowHandle;
            
            wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            //Wait for the new window or tab
            wait.Until(driver => driver.WindowHandles.Count == 2);
            //Loop through until we find a new window handle
            foreach(string window in driver.WindowHandles)
            {
                if(originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
            //Wait for the new tab to finish loading content
            wait.Until(driver => driver.Title);
        
        }


        public void CloseOtherTab()
        {
            string originalWindow = driver.CurrentWindowHandle;
            IWebDriver driver1 = driver;
            
            wait = new WebDriverWait(driver1,TimeSpan.FromSeconds(10));
            //Wait for the new window or tab
            wait.Until(driver1 => driver1.WindowHandles.Count == 2);
            //Loop through until we find a new window handle
            foreach(string window in driver1.WindowHandles)
            {
                if(originalWindow != window)
                {
                    driver1.SwitchTo().Window(window);
                    driver1.Close();
                    break;
                }
            }
                
        
        }
    }
}