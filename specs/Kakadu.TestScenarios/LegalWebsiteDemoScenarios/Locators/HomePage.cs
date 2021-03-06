﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ClassLibrary1.Locators
{
  public class HomePage
  {
    public static IWebDriver Driver => FeatureContext.Current.Get<IWebDriver>();

    public static IWebElement WebinarRegistrationButton
      => Driver.FindElement(By.CssSelector(".btn.btn-hollow.btn-lg"));



  }
}
