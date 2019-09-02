// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Vermaat.Crm.Specflow.Sample
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("AccountTests", Description="\tSome tests involving the account entity", SourceFile="AccountTests.feature", SourceLine=0)]
    public partial class AccountTestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AccountTests.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AccountTests", "\tSome tests involving the account entity", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Create a new Account", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=4)]
        public virtual void CreateANewAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a new Account", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table1.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table1.AddRow(new string[] {
                        "Main Phone",
                        "06123456789"});
            table1.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table1.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table1.AddRow(new string[] {
                        "Description",
                        "Test multi line"});
#line 6
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table2.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table2.AddRow(new string[] {
                        "Main Phone",
                        "06123456789"});
            table2.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table2.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table2.AddRow(new string[] {
                        "Description",
                        "Test multi line"});
#line 13
testRunner.Then("TestAccount has the following values", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Update an existing Account", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=21)]
        public virtual void UpdateAnExistingAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update an existing Account", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table3.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table3.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table3.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table3.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table3.AddRow(new string[] {
                        "Description",
                        "Test multi line"});
#line 23
testRunner.Given("an account named TestAccount with the following values", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table4.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands B.V."});
            table4.AddRow(new string[] {
                        "Main Phone",
                        "06987654321"});
            table4.AddRow(new string[] {
                        "Fax",
                        "4839432324"});
            table4.AddRow(new string[] {
                        "Description",
                        "Update multi line"});
#line 30
testRunner.When("TestAccount is updated with the following values", ((string)(null)), table4, "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table5.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands B.V."});
            table5.AddRow(new string[] {
                        "Main Phone",
                        "06987654321"});
            table5.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table5.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table5.AddRow(new string[] {
                        "Description",
                        "Update multi line"});
#line 36
testRunner.Then("TestAccount has the following values", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Check visiblity of form items", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=45)]
        public virtual void CheckVisiblityOfFormItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check visiblity of form items", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 46
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table6.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table6.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table6.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table6.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 47
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table6, "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "State"});
            table7.AddRow(new string[] {
                        "SIC Code",
                        "Visible"});
            table7.AddRow(new string[] {
                        "Ownership",
                        "Invisible"});
#line 53
testRunner.Then("TestAccount\'s form has the following form state", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Create Account - Check two option fields", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=58)]
        public virtual void CreateAccount_CheckTwoOptionFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Account - Check two option fields", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 59
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table8.AddRow(new string[] {
                        "Account Name",
                        "Checkbox"});
            table8.AddRow(new string[] {
                        "Do not allow Phone Calls",
                        "Do Not Allow"});
            table8.AddRow(new string[] {
                        "Do not allow Faxes",
                        "Do Not Allow"});
            table8.AddRow(new string[] {
                        "Do not allow Mails",
                        "Do Not Allow"});
#line 60
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table8, "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table9.AddRow(new string[] {
                        "Account Name",
                        "Checkbox"});
            table9.AddRow(new string[] {
                        "Do not allow Phone Calls",
                        "Do Not Allow"});
            table9.AddRow(new string[] {
                        "Do not allow Faxes",
                        "Do Not Allow"});
            table9.AddRow(new string[] {
                        "Do not allow Mails",
                        "Do Not Allow"});
#line 66
testRunner.Then("TestAccount has the following values", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Clearing values of Account", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=73)]
        public virtual void ClearingValuesOfAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clearing values of Account", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 74
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table10.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table10.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table10.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table10.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table10.AddRow(new string[] {
                        "Description",
                        "Test multi line"});
#line 75
testRunner.Given("an account named TestAccount with the following values", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table11.AddRow(new string[] {
                        "Industry",
                        ""});
            table11.AddRow(new string[] {
                        "Website",
                        ""});
            table11.AddRow(new string[] {
                        "Description",
                        ""});
#line 82
testRunner.When("TestAccount is updated with the following values", ((string)(null)), table11, "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table12.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table12.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table12.AddRow(new string[] {
                        "Website",
                        ""});
            table12.AddRow(new string[] {
                        "Industry",
                        ""});
            table12.AddRow(new string[] {
                        "Description",
                        ""});
#line 87
testRunner.Then("TestAccount has the following values", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Setting values while switching tabs", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=95)]
        public virtual void SettingValuesWhileSwitchingTabs()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Setting values while switching tabs", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 96
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table13.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table13.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table13.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table13.AddRow(new string[] {
                        "Credit Hold",
                        "Yes"});
            table13.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
#line 97
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table13, "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table14.AddRow(new string[] {
                        "Account Name",
                        "DynamicHands"});
            table14.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table14.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table14.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table14.AddRow(new string[] {
                        "Credit Hold",
                        "Yes"});
#line 104
testRunner.Then("TestAccount has the following values", ((string)(null)), table14, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Full Merge of two accounts into one", new string[] {
                "API",
                "Cleanup"}, SourceLine=112)]
        public virtual void FullMergeOfTwoAccountsIntoOne()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Full Merge of two accounts into one", null, new string[] {
                        "API",
                        "Cleanup"});
#line 113
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table15.AddRow(new string[] {
                        "Account Name",
                        "Merging Source"});
            table15.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
#line 114
testRunner.Given("an account named MergeSource with the following values", ((string)(null)), table15, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table16.AddRow(new string[] {
                        "Account Name",
                        "Merging Target"});
            table16.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table16.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 118
testRunner.Given("an account named MergeTarget with the following values", ((string)(null)), table16, "Given ");
#line 123
testRunner.When("MergeSource is fully merged into MergeTarget", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table17.AddRow(new string[] {
                        "Account Name",
                        "Merging Source"});
            table17.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table17.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table17.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
#line 124
testRunner.Then("MergeTarget has the following values", ((string)(null)), table17, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Partial Merge of two accounts into one", new string[] {
                "API",
                "Cleanup"}, SourceLine=131)]
        public virtual void PartialMergeOfTwoAccountsIntoOne()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Partial Merge of two accounts into one", null, new string[] {
                        "API",
                        "Cleanup"});
#line 132
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table18.AddRow(new string[] {
                        "Account Name",
                        "Merging Source"});
            table18.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
#line 133
testRunner.Given("an account named MergeSource with the following values", ((string)(null)), table18, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table19.AddRow(new string[] {
                        "Account Name",
                        "Merging Target"});
            table19.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table19.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
#line 137
testRunner.Given("an account named MergeTarget with the following values", ((string)(null)), table19, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property"});
            table20.AddRow(new string[] {
                        "Main Phone"});
#line 142
testRunner.When("The following fields of MergeSource are fully merged into MergeTarget", ((string)(null)), table20, "When ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table21.AddRow(new string[] {
                        "Account Name",
                        "Merging Target"});
            table21.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table21.AddRow(new string[] {
                        "Industry",
                        "Consulting"});
            table21.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
#line 145
testRunner.Then("MergeTarget has the following values", ((string)(null)), table21, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Use DefaultData for default values", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=152)]
        public virtual void UseDefaultDataForDefaultValues()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Use DefaultData for default values", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 153
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
#line 154
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table22, "When ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table23.AddRow(new string[] {
                        "Account Name",
                        "test"});
#line 156
testRunner.Then("TestAccount has the following values", ((string)(null)), table23, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Creating child contact from account", new string[] {
                "API",
                "Chrome",
                "Cleanup"}, SourceLine=161)]
        public virtual void CreatingChildContactFromAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating child contact from account", null, new string[] {
                        "API",
                        "Chrome",
                        "Cleanup"});
#line 162
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table24.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
            table24.AddRow(new string[] {
                        "Website",
                        "https://dynamichands.nl"});
            table24.AddRow(new string[] {
                        "Address 1: Street 1",
                        "Street 1"});
            table24.AddRow(new string[] {
                        "Address 1: Street 2",
                        "Street 2"});
            table24.AddRow(new string[] {
                        "Address 1: Street 3",
                        "Street 3"});
            table24.AddRow(new string[] {
                        "Address 1: City",
                        "City"});
            table24.AddRow(new string[] {
                        "Address 1: State/Province",
                        "State"});
            table24.AddRow(new string[] {
                        "Account Name",
                        "ParentAccount"});
#line 163
testRunner.Given("an account named TestAccount with the following values", ((string)(null)), table24, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table25.AddRow(new string[] {
                        "First Name",
                        "Child"});
            table25.AddRow(new string[] {
                        "Last Name",
                        "Record"});
            table25.AddRow(new string[] {
                        "Address 1: Street 1",
                        "SomethingElse"});
            table25.AddRow(new string[] {
                        "Address 1: Street 2",
                        ""});
#line 173
testRunner.When("a related contact from TestAccount named ChildContact is created with the followi" +
                    "ng values", ((string)(null)), table25, "When ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table26.AddRow(new string[] {
                        "First Name",
                        "Child"});
            table26.AddRow(new string[] {
                        "Last Name",
                        "Record"});
            table26.AddRow(new string[] {
                        "Business Phone",
                        "0612345678"});
            table26.AddRow(new string[] {
                        "Address 1: Street 1",
                        "SomethingElse"});
            table26.AddRow(new string[] {
                        "Address 1: Street 2",
                        ""});
            table26.AddRow(new string[] {
                        "Address 1: Street 3",
                        "Street 3"});
            table26.AddRow(new string[] {
                        "Address 1: City",
                        "City"});
            table26.AddRow(new string[] {
                        "Address 1: State/Province",
                        "State"});
#line 179
testRunner.Then("ChildContact has the following values", ((string)(null)), table26, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Connect records via a N:N Relationship", new string[] {
                "API",
                "Cleanup"}, SourceLine=190)]
        public virtual void ConnectRecordsViaANNRelationship()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Connect records via a N:N Relationship", null, new string[] {
                        "API",
                        "Cleanup"});
#line 191
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table27.AddRow(new string[] {
                        "Account Name",
                        "NN Relationship"});
            table27.AddRow(new string[] {
                        "Main Phone",
                        "0612345678"});
#line 192
testRunner.Given("an account named NNAccount with the following values", ((string)(null)), table27, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table28.AddRow(new string[] {
                        "First Name",
                        "John"});
            table28.AddRow(new string[] {
                        "Last Name",
                        "Smith"});
#line 196
testRunner.And("a contact named Contact1 with the following values", ((string)(null)), table28, "And ");
#line hidden
            TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table29.AddRow(new string[] {
                        "First Name",
                        "Bart"});
            table29.AddRow(new string[] {
                        "Last Name",
                        "Pond"});
#line 200
testRunner.And("a contact named Contact2 with the following values", ((string)(null)), table29, "And ");
#line hidden
            TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table30.AddRow(new string[] {
                        "First Name",
                        "Eric"});
            table30.AddRow(new string[] {
                        "Last Name",
                        "Foreman"});
#line 204
testRunner.And("a contact named Contact3 with the following values", ((string)(null)), table30, "And ");
#line hidden
            TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value"});
            table31.AddRow(new string[] {
                        "Contact1"});
            table31.AddRow(new string[] {
                        "Contact2"});
            table31.AddRow(new string[] {
                        "Contact3"});
#line 208
testRunner.When("the following records of type contact are connected to NNAccount", ((string)(null)), table31, "When ");
#line hidden
            TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value"});
            table32.AddRow(new string[] {
                        "Contact1"});
            table32.AddRow(new string[] {
                        "Contact2"});
            table32.AddRow(new string[] {
                        "Contact3"});
#line 213
testRunner.Then("NNAccount has the following connected records of type contact", ((string)(null)), table32, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Single form notification", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=219)]
        public virtual void SingleFormNotification()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Single form notification", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 220
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table33.AddRow(new string[] {
                        "Account Name",
                        "Single Notification"});
            table33.AddRow(new string[] {
                        "Credit Limit",
                        "10000"});
#line 221
testRunner.Given("an account named NotificationAccount with the following values", ((string)(null)), table33, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                        "Message",
                        "Level"});
            table34.AddRow(new string[] {
                        "The credit limit of this account is under 1.000.000",
                        "Warning"});
#line 225
testRunner.Then("NotificationAccount has the following form notifications", ((string)(null)), table34, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Multiple form notifications", new string[] {
                "Chrome",
                "Cleanup"}, SourceLine=229)]
        public virtual void MultipleFormNotifications()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Multiple form notifications", null, new string[] {
                        "Chrome",
                        "Cleanup"});
#line 230
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table35.AddRow(new string[] {
                        "Account Name",
                        "Multiple Notifications"});
            table35.AddRow(new string[] {
                        "Credit Limit",
                        "10000"});
            table35.AddRow(new string[] {
                        "Industry",
                        "Brokers"});
#line 231
testRunner.Given("an account named NotificationAccount with the following values", ((string)(null)), table35, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "Message",
                        "Level"});
            table36.AddRow(new string[] {
                        "The credit limit of this account is under 1.000.000",
                        "Warning"});
            table36.AddRow(new string[] {
                        "This account is from the broker industry. Additional rules applicable.",
                        "Warning"});
#line 236
testRunner.Then("NotificationAccount has the following form notifications", ((string)(null)), table36, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Verify error popup", new string[] {
                "Cleanup",
                "ExpectedError",
                "Chrome"}, SourceLine=241)]
        public virtual void VerifyErrorPopup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify error popup", null, new string[] {
                        "Cleanup",
                        "ExpectedError",
                        "Chrome"});
#line 242
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table37.AddRow(new string[] {
                        "Account Name",
                        "Test"});
            table37.AddRow(new string[] {
                        "Website",
                        "https://error.com"});
#line 243
testRunner.When("an account named TestAccount is created with the following values", ((string)(null)), table37, "When ");
#line 247
testRunner.Then("the following error message appears: \'Website refers to error.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Assigning alias to a lookup value", new string[] {
                "API",
                "Cleanup"}, SourceLine=250)]
        public virtual void AssigningAliasToALookupValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Assigning alias to a lookup value", null, new string[] {
                        "API",
                        "Cleanup"});
#line 251
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table38.AddRow(new string[] {
                        "Account Name",
                        "Multiple Notifications"});
            table38.AddRow(new string[] {
                        "Credit Limit",
                        "10000"});
            table38.AddRow(new string[] {
                        "Industry",
                        "Brokers"});
#line 252
testRunner.Given("an account named TestAccount with the following values", ((string)(null)), table38, "Given ");
#line 257
testRunner.When("all asynchronous processes for TestAccount are finished", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 258
testRunner.Then("TestAccount\'s Auto Generated is named AutoGenRecord", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property",
                        "Value"});
            table39.AddRow(new string[] {
                        "Credit Limit",
                        "10000"});
#line 259
testRunner.And("AutoGenRecord has the following values", ((string)(null)), table39, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
