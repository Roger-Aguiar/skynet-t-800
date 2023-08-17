#nullable disable
namespace MariaAssisAppointments.MariaAssisAppointments.Shared
{
    public class WebScrapper : Web
    {
        public int NumberOfAppointments { get; set; }

        public List<Pacs> GetAvailablePacs(string url)
        {
            List<Pacs> listOfPacs = new();

            if (driver == null)
            {
                StartBrowser();
                Navigate(url);
                WaitForLoad();
                var tableOfAvailablePacs = GetValue(TypeElement.Xpath, "//*[@id=\"form\"]/div[2]/div/table/tbody").element.FindElements(By.TagName("tr"));

                while (tableOfAvailablePacs.Count == 0)
                {
                    Thread.Sleep(5000);
                    Navigate(url);
                    WaitForLoad();
                    tableOfAvailablePacs = GetValue(TypeElement.Xpath, "//*[@id=\"form\"]/div[2]/div/table/tbody").element.FindElements(By.TagName("tr"));
                }

                foreach (var availablePacs in tableOfAvailablePacs)
                {
                    listOfPacs.Add(new Pacs()
                    {
                        Id = availablePacs.GetAttribute("id"),
                        Local = availablePacs.FindElement(By.TagName("td")).Text
                    });
                }
                CloseBrowser();
            }
            return listOfPacs;
        }

        public void SearchAppointment(List<People> customers)
        {
            var web = new Web();

            foreach (var customer in customers)
            {
                web.StartBrowser();
                web.Navigate("https://amcin.e-instituto.com.br/Vsoft.iDSPS.Agendamento/Agendamento/Consultar");
                web.WaitForLoad();
                web.AssignValue(TypeElement.Name, "cpf", customer.Cpf).element.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
        }
                
        public async void MakeAppointment(List<Pacs> listOfPacs, List<People> customers)
        {
            NumberOfAppointments = 0;
            var web = new Web();

            foreach (var person in customers)
            {
                var pac = from local in listOfPacs where local.Local == person.Pac select local.Id;

                if (pac.FirstOrDefault() != null)
                {
                    web.StartBrowser();
                    var link = $"https://amcin.e-instituto.com.br/Vsoft.iDSPS.Agendamento/Agendamento/Agendar/{pac.FirstOrDefault()}";
                    web.Navigate(link);
                    web.WaitForLoad();
                    web.AssignValue(TypeElement.Id, "via", "1ª Via");
                    web.AssignValue(TypeElement.Id, "tipo", "Quero que o sistema escolha o horário mais próximo");
                    web.AssignValue(TypeElement.Id, "nome", person.Name);
                    web.AssignValue(TypeElement.Id, "cpf", person.Cpf);
                    web.AssignValue(TypeElement.Id, "pai", person.FatherName);
                    web.AssignValue(TypeElement.Id, "mae", person.MotherName);
                    var captcha_key = web.GetValue(TypeElement.Id, "grecaptcharesponse").element.GetAttribute("data-sitekey");
                    var solve_captcha = new Solve();
                    var result = await solve_captcha.ReCaptchaV2Async("f19489630e32745e0e7a81d18237b05d", captcha_key, link);
                    web.ExecuteScript($"document.querySelector('#g-recaptcha-response').innerHTML = '{result.Request}';");
                    web.AssignValue(TypeElement.Id, "dataNascimento", person.Birthdate).element.SendKeys(OpenQA.Selenium.Keys.Enter);
                    NumberOfAppointments++;
                }
            }
        }

        public async void CheckData(People customer, User user)
        {
            var web = new Web();

            web.StartBrowser();
            var link = $"https://amcin.e-instituto.com.br/Vsoft.iDSPS.Agendamento/Agendamento/Agendar/{user.LinkPac}";
            web.Navigate(link);
            web.WaitForLoad();
            web.AssignValue(TypeElement.Id, "via", "1ª Via");
            web.AssignValue(TypeElement.Id, "tipo", "Quero que o sistema escolha o horário mais próximo");
            web.AssignValue(TypeElement.Id, "nome", customer.Name);
            web.AssignValue(TypeElement.Id, "cpf", customer.Cpf);
            web.AssignValue(TypeElement.Id, "pai", customer.FatherName);
            web.AssignValue(TypeElement.Id, "mae", customer.MotherName);
            var captcha_key = web.GetValue(TypeElement.Id, "grecaptcharesponse").element.GetAttribute("data-sitekey");
            var solve_captcha = new Solve();
            var result = await solve_captcha.ReCaptchaV2Async("f19489630e32745e0e7a81d18237b05d", captcha_key, link);
            web.ExecuteScript($"document.querySelector('#g-recaptcha-response').innerHTML = '{result.Request}';");
            web.AssignValue(TypeElement.Id, "dataNascimento", customer.Birthdate).element.SendKeys(OpenQA.Selenium.Keys.Enter);
        }
    }
}
