using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject0109
{
    class PageObject
    {
        public string email = "automacaoteste@gmail.com";
        public string comprarAgora = "buy-now-button";
        public string quantity = "quantity";
        public string btnIphoneList = "//*[@id='search']/div[1]/div[1]/div/span[3]/div[2]/div[3]/div/span/div/div/div/div/div[2]/div[1]/h2/a";
        public string btnLupa = "nav-search-submit-text";
        public string txtIhpone = "twotabsearchtextbox";
        public string valorPesquisa = "iphone 11";

        // URL do site
        public string url = "https://www.amazon.com.br/";

        //public IWebElement logar { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='signInSubmit']")]

        //public IWebElement logar22 { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='signInSubmit']")]
        //public IWebElement campoSenha { get; set; }
        //[FindsBy(How = How.Id, Using = "ap_password")]
        //ap_password
    }
}
