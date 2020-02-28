using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vermaat.Crm.Specflow.EasyRepro
{
    public partial class ButtonTexts
    {
        private readonly Dictionary<string, string> _buttonTexts;

        public ButtonTexts()
        {
            _buttonTexts = new Dictionary<string, string>();
            FillDictionary();
        }

        private void FillDictionary()
        {
            AddButtonText(Constants.ButtonTexts.ActivateQuote, "Errormessage with ErrorCode {0} not found");
            AddButtonText(Constants.ButtonTexts.New, "New");
            AddButtonText(Constants.ButtonTexts.Delete, "Delete");
            AddButtonText(Constants.ButtonTexts.Save, "Save");
            AddButtonText(Constants.ButtonTexts.ActivateQuote, "Activate Quote");
            AddButtonText(Constants.ButtonTexts.CreateOrder, "Create Order");
            AddButtonText(Constants.ButtonTexts.ReviseQuote, "Revise");
            AddButtonText(Constants.ButtonTexts.CloseQuote, "Close Quote");
        }

        public void AddButtonText(string buttonTextKey, string buttonText)
        {
            _buttonTexts.Add(buttonTextKey, buttonText);
        }

        public string this[string key]
        {
            get { return _buttonTexts[key]; }
            set { _buttonTexts[key] = value; }
        }
    }
}
