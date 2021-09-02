using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace TestProject0109
{
    public class Tests
    {
        PageObject pageobject = new PageObject();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            // Abrir navegado
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new EdgeDriver();

            var navigate = driver.Navigate();

            // Acessando o Site da Amazon
            navigate.GoToUrl(pageobject.url); //w

            // Maximinizar janela do navegador
            driver.Manage().Window.Maximize();

            //driver.FindElement(By.XPath("zxzxz"));
            //iphoneLista.Click();
            //iphoneLista.SendKeys("dsdsdsd");
            // Pesquisando IPHONE 
            var radioButton = driver.FindElement(By.Id(pageobject.txtIhpone));
            radioButton.SendKeys(pageobject.valorPesquisa);

            //Clicando na lupa
            driver.FindElement(By.Id(pageobject.btnLupa)).Click();
            Thread.Sleep(1500);


            //Clicando em um IPhone 
            driver.FindElement(By.XPath(pageobject.btnIphoneList)).Click();


            Thread.Sleep(1000);

            // Selecionando a quantidade do produto
            var dropdown = (driver.FindElement(By.Name(pageobject.quantity)));
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByValue("2");


            //Clicando em comprar
            driver.FindElement(By.Id(pageobject.comprarAgora)).Click();
            Thread.Sleep(1000);

            //Logando com usuario cadastrado
            driver.FindElement(By.Id("ap_email")).SendKeys(pageobject.email);

            driver.FindElement(By.XPath("//*[@id='continue']")).Click();

            Thread.Sleep(1000);

            //Colocando senha
            driver.FindElement(By.Id("ap_password")).SendKeys(pageobject.email);
            //pageobject.campoSenha.SendKeys(pageobject.email);
            Thread.Sleep(1000);
            // Clicandon em Logar
            driver.FindElement(By.XPath("//*[@id='signInSubmit']")).Click();
            //pageobject.logar.Click();
            Thread.Sleep(1500);


            //Clicando em Confirmar o Pedido
            //driver.FindElement(By.XPath("//*[@id='placeYourOrder']/span/input")).Click();


            Thread.Sleep(1000);

            // FINALIZA O TESTE
            driver.Quit();
        }
    }
}