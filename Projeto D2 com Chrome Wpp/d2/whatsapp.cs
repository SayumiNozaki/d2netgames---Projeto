using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyAutomationFramework;
using static javax.jws.soap.SOAPBinding;
using sun.security.krb5.@internal;
using System.Windows.Forms;
using System.Threading;

namespace d2
{
    internal class whatsapp : Web
    {
        public void SendMessage (string message, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\sayum\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(TimeSpan.FromSeconds(5));

            var elementoPesquisar = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div[2]/div[2]/div/div/p", to);

            elementoPesquisar.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            var elementoMensagem = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span/div/div[2]/div[1]/div[2]/div[1]/p", message);

            elementoMensagem.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            Thread.Sleep(TimeSpan.FromSeconds(5));
            CloseBrowser();


        }

    }
}
