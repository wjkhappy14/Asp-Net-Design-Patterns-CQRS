﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Agathas.Storefront.Specs.Uat.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Applying Promotion Vouchers")]
    public partial class ApplyingPromotionVouchersFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ApplyingVouchers.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Applying Promotion Vouchers", "In order to recieve a discount to my basket\r\nAs a customer \r\nI want to be able to" +
                    " apply a promotional voucher to my basket", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "VoucherCode",
                        "Discount",
                        "Quota",
                        "Scope",
                        "BasketTotalMustMeet"});
            table1.AddRow(new string[] {
                        "XXX-XXX",
                        "5.00",
                        "Unlimited",
                        "HeadGear",
                        "50"});
            table1.AddRow(new string[] {
                        "YYY-YYY",
                        "10.00",
                        "SingleUse",
                        "Clothing",
                        "100"});
            table1.AddRow(new string[] {
                        "ZZZ-ZZZ",
                        "10%",
                        "SingleUse",
                        "All",
                        "0"});
#line 7
 testRunner.Given("the following promotions", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProductId",
                        "Price",
                        "Name",
                        "Category"});
            table2.AddRow(new string[] {
                        "1",
                        "10.50",
                        "Hat",
                        "HeadGear"});
            table2.AddRow(new string[] {
                        "2",
                        "44.65",
                        "Jumper",
                        "Clothing"});
#line 12
 testRunner.And("the following products", ((string)(null)), table2);
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Apply a promotional voucher to a valid basket")]
        public virtual void ApplyAPromotionalVoucherToAValidBasket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Apply a promotional voucher to a valid basket", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProductId"});
            table3.AddRow(new string[] {
                        "1"});
            table3.AddRow(new string[] {
                        "2"});
#line 19
 testRunner.Given("I have added the following items to my basket", ((string)(null)), table3);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "VoucherCode"});
            table4.AddRow(new string[] {
                        "XXX-XXX"});
#line 23
 testRunner.When("I apply the promotional voucher", ((string)(null)), table4);
#line 26
 testRunner.Then("the total amount payable on the basket should be £50.15");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Apply a promotional voucher to a valid basket, then make the basket total come un" +
            "der the voucher threshold")]
        public virtual void ApplyAPromotionalVoucherToAValidBasketThenMakeTheBasketTotalComeUnderTheVoucherThreshold()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Apply a promotional voucher to a valid basket, then make the basket total come un" +
                    "der the voucher threshold", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProductId"});
            table5.AddRow(new string[] {
                        "1"});
            table5.AddRow(new string[] {
                        "2"});
#line 30
 testRunner.Given("I have added the following items to my basket", ((string)(null)), table5);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "VoucherCode"});
            table6.AddRow(new string[] {
                        "XXX-XXX"});
#line 34
 testRunner.When("I apply the promotional voucher", ((string)(null)), table6);
#line 37
 testRunner.Then("the total amount payable on the basket should be £50.15");
#line 38
 testRunner.When("I remove product id \'1\'");
#line 39
 testRunner.Then("the total amount payable on the basket should be £44.65");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Apply a promotional voucher to an invalid basket")]
        public virtual void ApplyAPromotionalVoucherToAnInvalidBasket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Apply a promotional voucher to an invalid basket", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProductId"});
            table7.AddRow(new string[] {
                        "1"});
#line 44
 testRunner.Given("I have added the following items to my basket", ((string)(null)), table7);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "VoucherCode"});
            table8.AddRow(new string[] {
                        "XXX-XXX"});
#line 47
 testRunner.When("I apply the promotional voucher", ((string)(null)), table8);
#line 50
 testRunner.Then("the total amount payable on the basket should be £10.50");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Applying a promotional voucher to a valid basket, which has already had a voucher" +
            " applied")]
        public virtual void ApplyingAPromotionalVoucherToAValidBasketWhichHasAlreadyHadAVoucherApplied()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Applying a promotional voucher to a valid basket, which has already had a voucher" +
                    " applied", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProductId"});
            table9.AddRow(new string[] {
                        "1"});
            table9.AddRow(new string[] {
                        "2"});
#line 55
 testRunner.Given("I have added the following items to my basket", ((string)(null)), table9);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "VoucherCode"});
            table10.AddRow(new string[] {
                        "XXX-XXX"});
#line 59
 testRunner.When("I apply the promotional voucher", ((string)(null)), table10);
#line 62
 testRunner.Then("the total amount payable on the basket should be £50.15");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "VoucherCode"});
            table11.AddRow(new string[] {
                        "YYY-YYY"});
#line 63
 testRunner.When("I apply the promotional voucher", ((string)(null)), table11);
#line 66
 testRunner.Then("the total amount payable on the basket should be £50.15");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Removing a promotional voucher after applying it to a valid basket")]
        public virtual void RemovingAPromotionalVoucherAfterApplyingItToAValidBasket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Removing a promotional voucher after applying it to a valid basket", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "ProductId"});
            table12.AddRow(new string[] {
                        "1"});
            table12.AddRow(new string[] {
                        "2"});
#line 71
 testRunner.Given("I have added the following items to my basket", ((string)(null)), table12);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "VoucherCode"});
            table13.AddRow(new string[] {
                        "XXX-XXX"});
#line 75
 testRunner.When("I apply the promotional voucher", ((string)(null)), table13);
#line 78
 testRunner.Then("the total amount payable on the basket should be £50.15");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "VoucherCode"});
            table14.AddRow(new string[] {
                        "XXX-XXX"});
#line 79
 testRunner.When("I remove the promotional voucher", ((string)(null)), table14);
#line 82
 testRunner.Then("the total amount payable on the basket should be £55.15");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
