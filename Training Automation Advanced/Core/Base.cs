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
        public void ActionScrollToBottom()  //funcion para scrollear hasta el fondo de la pagina
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
            Thread.Sleep(2000);
            return driver.Title;
        }
        public void Navigate(string url)
        {
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl(url);
        }
        public void NavigateBack()
        {
            Thread.Sleep(2000);
            driver.Navigate().Back();
        }
        public IWebElement WaitAndFindElement(By locator)
        {
            Thread.Sleep(2000);
            return driver.FindElement(locator);
        }
        public void SetText(IWebElement element, string text)
        {
            Thread.Sleep(2000);
            element.Clear();
            element.SendKeys(text);
        }
        public void TypeEnter(IWebElement element)
        {
            Thread.Sleep(2000);
            element.SendKeys(Keys.Enter);
        }
        public string GetText(IWebElement element)
        {
            Thread.Sleep(2000);
            return element.Text;
        }
        public void ClickOnItem(IWebElement element)
        {
            Thread.Sleep(2000);
            element.Click();
        }
        //getstyle recibe un webelement y el nombre de una propiedad de estilo
        //devuelve el valor de esa propiedad del elemento
        public string GetStyle(IWebElement element, string styleProperty)
        {
            Thread.Sleep(2000);
            return element.GetCssValue(styleProperty);
        }
        //seleccionar en elemento select
        public void SelectOptionByText(SelectElement selectElement, string optionString)
        {
            Thread.Sleep(2000);
            selectElement.SelectByText(optionString);
        }
        //selectothertab cambia de tab
        //se asume que se manejan como maximo 2 tabs/windows 
        public void SelectOtherTab()
        {
            string originalWindow = driver.CurrentWindowHandle;
            wait = new WebDriverWait(driver,TimeSpan.FromSeconds(3));
            //Wait for the new window or tab
            wait.Until(driver => driver.WindowHandles.Count == 2);
            //Loop through until we find a new window handle
            foreach(string window in driver.WindowHandles)
            {
                if(originalWindow != window)
                {
                    Thread.Sleep(1000);
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
            //Wait for the new tab to finish loading content
            wait.Until(driver => driver.Title);
            Thread.Sleep(1000);
        }
        //closenotmaintab cierra la tab/window recientemente abierta
        //se asume que se manejan como maximo 2 tabs/windows 
        public void CloseNotMainTab()
        {
            Thread.Sleep(1000);
            wait = new WebDriverWait(driver,TimeSpan.FromSeconds(3));
            wait.Until(driver => driver.WindowHandles.Count == 2);
            string mainWindow = driver.WindowHandles[0];
            string closingWindow = driver.WindowHandles[1];
            //Loop through until we find a new window handle            
            foreach(string window in driver.WindowHandles)
            {
                if(closingWindow == window)
                {
                    driver.Close();
                    driver.SwitchTo().Window(mainWindow);
                    Thread.Sleep(1000);
                    break;
                }
            }
        }
    }
}