
using BarcodeExample2.Item;

namespace BorcodeExample2
{
    class MyClass
    {
        static void Main(string[] args)
        {

            // item Catogry --> 3
            // item Price   --> 5
            // item Number  --> 5
            // item Name 

            // Barcodes
            string sBarcodes = @"0010250000020-0110300000200-0210050000320-0120550000520";

            // split - array
            string[] sBarcodesArray = sBarcodes.Split('-');

            // object new
            Item Oitem = new Item();

            // Array List
            List<Item> listsBarcodes = new List<Item>();

            // loop
            foreach (string item in sBarcodesArray)
            {
                Oitem = new Item();

                Oitem.ItemCarogry = Convert.ToInt32(sBarcodes.Substring(0, 3));
                Oitem.ItemPrice = Convert.ToInt32(sBarcodes.Substring(3, 5));
                Oitem.ItemNaumber = Convert.ToInt32(sBarcodes.Substring(8, 5));

                // Pleas Enter a UserName 
                Console.WriteLine("Pleas Enter UserName");
                Oitem.ItemName = Console.ReadLine();

                listsBarcodes.Add(Oitem);
            }

            // return
            string NewBorcode = string.Empty;
            Item MyItem = new Item();

            // loop
            foreach (var item in listsBarcodes)
            {
                NewBorcode = $"-{MyItem.GetFormatCatogryNumber(Oitem.ItemCarogry)}" +
                    $"{MyItem.GetFormatPrice(Oitem.ItemPrice)} {MyItem.GetFormatNumber(Oitem.ItemNaumber)}";
            }

        }
    }
}
