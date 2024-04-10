using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeExample2.Item
{
    internal class Item
    {
        #region  Variabol
        public int ItemCarogry { get; set; }
        public decimal ItemPrice { get; set; }
        public int ItemNaumber { get; set; }
        public string ItemName { get; set; }
        #endregion


        #region  Method 
        public string GetFormatCatogryNumber(int Number)
        {
            string NewNumber = Number.ToString();
            string ReturnNumber = string.Empty;

            for (int i = 0; i < 3 - NewNumber.Length; i++)
            {
                ReturnNumber += "0";
            }
            return ReturnNumber + NewNumber;

        }

        public string GetFormatPrice(decimal price)
        {
            string NewNumber = price.ToString();
            string ReturnNumber = string.Empty;

            for (int i = 0; i < 5 - NewNumber.Length; i++)
            {
                ReturnNumber += "0";
            }
            return ReturnNumber + NewNumber;

        }

        public string GetFormatNumber(int Number)
        {
            string NewNumber = Number.ToString();
            string ReturnNumber = string.Empty;

            for (int i = 0; i < 3 - NewNumber.Length; i++)
            {
                ReturnNumber += "0";
            }
            return ReturnNumber + NewNumber;

        } 
        #endregion
    }
}
