using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AssetsManager
{
    class AssetService
    {
        public List<Asset> Assets { get; set; }
        public List <int> CheckID { get; set; }
      

        public AssetService()
        {
            Assets = new List<Asset>();
            CheckID = new List<int>();
        }
        

        
        public ConsoleKeyInfo AddNewAssetView(MenuActionService actionService)
        {

            var addNewAssetMenu = actionService.GetMenuActionsByMenuName("AddNewAssetMenu");

                Console.WriteLine();
                CustomerStatements.CallToAction(" Please choose Appropriate ASSET-CLASS");
                Console.WriteLine();
                for (int i = 0; i < addNewAssetMenu.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", addNewAssetMenu[i].Id, addNewAssetMenu[i].Name);
                }

        WrongKey:
            var operation = Console.ReadKey();

            switch (operation.KeyChar)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine(" - Wrong Key , Please choose again Appropiate ASSET=CLASS");
                    Console.WriteLine();
                    goto WrongKey;

            }
            return operation;
        }
        


        public void AllYourAssets()
        {
            foreach (var asset in Assets)
            {
               
                    Console.WriteLine($" ID: {asset.Id }, Asset name: {asset.Name}, Asset shortcut: {asset.Shortcut} ," +
                    $" Asset amount: {asset.Amount}, Price You Bought: {asset.InvestitionPrice}$, Money Invested: {asset.InvestedMoney}$, Current Price: {asset.CurrentPrice}$, " +
                    $"Asset Value: {asset.AssetValue}$, Asset Balance: {asset.AssetBalance}$");
                    Console.WriteLine();             

            }


        }





        public int AddNewAssets(char assetType)
        {
            int assetTypeId;
            Int32.TryParse(assetType.ToString(), out assetTypeId);
            Asset asset = new Asset();
            asset.TypeId = assetTypeId;
            Console.WriteLine();
            CustomerStatements.CallToAction(" Please enter id for new asset");
            Console.WriteLine();
            var id = Console.ReadLine();
            int assetId;
            while (!Int32.TryParse(id, out assetId))
            {
                Console.WriteLine("Id must be a number - try again");
                Console.WriteLine();
                id = Console.ReadLine();

            }

                while (CheckID.Contains(assetId))
                {
                
                CustomerStatements.CallToAction("This Id Asset is on the list, Please choose another Id");
                Console.WriteLine();
                id = Console.ReadLine();
                Int32.TryParse(id, out assetId);
                }
     
                asset.Id = assetId;
                CheckID.Add(assetId); // dodaje do listy id by później sprawdzić czy się nie powtarza


            Console.WriteLine();
            CustomerStatements.CallToAction(" Please enter name for new asset");
            Console.WriteLine();
            
            var assetName = Console.ReadLine();
            asset.Name = assetName;

            Console.WriteLine();
            CustomerStatements.CallToAction(" Please enter shortcut( for example 'BTC') for new asset");
            Console.WriteLine();
            
            var assetShortcut = Console.ReadLine();
            asset.Shortcut =assetShortcut ;

            Console.WriteLine();
            CustomerStatements.CallToAction(" Please enter Placement (for example : name of exchange, cryptocurrency address, real estate address) for new asset");
            Console.WriteLine();
            
            var assetPlacement = Console.ReadLine();
            asset.Placement = assetPlacement;
            
            Console.WriteLine();
            CustomerStatements.CallToAction($" Please enter amount of {assetName} you have");
            Console.WriteLine();
           
            var amount = Console.ReadLine();
            decimal assetAmount;
            while (!decimal.TryParse(amount, out assetAmount))
            {
                Console.WriteLine(" Amount must be a number - try again!!");
                Console.WriteLine();
                amount = Console.ReadLine();

            }

            asset.Amount = assetAmount;
            Console.WriteLine();
            CustomerStatements.CallToAction($" Please enter Price ( in $) you bought {assetName} at");
            Console.WriteLine();
            var bought = Console.ReadLine();
            decimal assetBought;

            while (!decimal.TryParse(bought, out assetBought))
            {
                Console.WriteLine();
                Console.WriteLine(" Amount must be a number - try again!!");
                bought = Console.ReadLine();

            }
            
            asset.InvestitionPrice = assetBought;
            Console.WriteLine();
            CustomerStatements.CallToAction($" Please enter current Price ( in $) of {assetName}");
            Console.WriteLine();
            var price = Console.ReadLine();
            decimal assetPrice;

            while (!decimal.TryParse(price, out assetPrice))
            {
                Console.WriteLine();
                Console.WriteLine(" Asset Price must be a number - try again!!");
                price = Console.ReadLine();

            }

            asset.CurrentPrice = assetPrice;


            // Checking Current Value of this asset

            decimal assetValue = assetAmount * assetPrice;
            asset.AssetValue= assetValue;

            // Checking how many invested in this asset 
            decimal assetInvestet = assetAmount * assetBought;
            asset.InvestedMoney = assetInvestet;
            
            //Checking profit or loss with this asset
            decimal assetBalance = assetValue - assetInvestet;
            asset.AssetBalance = assetBalance;

            // Adding asset to Assets List
            Assets.Add(asset);
            return assetId;
        }

      
        // Removing Asset
        public int RemoveAssetView()
        {

            CustomerStatements.CallToAction(" Please enter id for item you want to remove");
            var assetId = Console.ReadKey();
            int id;
            Int32.TryParse(assetId.KeyChar.ToString(), out id);
            
            return id;

        }


        public void RemoveAsset(int removeId)
        {

            Asset assetToRemove = new Asset();
            foreach (var asset in Assets)
            {
                if (asset.Id ==removeId)
                {
                    assetToRemove = asset;
                    break;
                }

            }
            Assets.Remove(assetToRemove);
        }


        // Choosing  Asset for view
        internal void AssetsByAssetTypeView(int typeId)
        {
            List<Asset> toShow = new List<Asset>();
            foreach (var asset in Assets)
            {
                if (asset.TypeId ==typeId)
                {
                    toShow.Add(asset);
                    Console.WriteLine($" TYPE: {asset.Id }, Asset name: {asset.Name}, Asset shortcut: {asset.Shortcut} ," +
                    $" Asset amount: {asset.Amount}, Price You Bought: {asset.InvestitionPrice}$, Money Invested: {asset.InvestedMoney}$, Current Price: {asset.CurrentPrice}$, " +
                    $"Asset Value: {asset.AssetValue}$, Asset Balance: {asset.AssetBalance}$");
                    Console.WriteLine();
                }
                
            }
           
        }

     
        public void AssetDetailView(int detailId)
        {

            Asset assetToShow = new Asset();
            foreach (var asset in Assets)
            {
                if (asset.Id == detailId)
                {
                    assetToShow= asset;
                    break;
                }

            }
            Console.WriteLine($" TYPE: {assetToShow.Id }, Asset name: {assetToShow.Name}, Asset shortcut: {assetToShow.Shortcut} ," +
                              $" Asset amount: {assetToShow.Amount}, Price You Bought: {assetToShow.InvestitionPrice}$," +
                              $" Money Invested: {assetToShow.InvestedMoney}$, Current Price: {assetToShow.CurrentPrice}$, " +
                              $"Asset Value: {assetToShow.AssetValue}$, Asset Balance: {assetToShow.AssetBalance}$");
            Console.WriteLine();
        }

        // Watching assets in particular categories

        public int AssetDetailSelectionView()
        {

            CustomerStatements.CallToAction(" Please enter id for asset you want to see");
            Console.WriteLine( ); 
            var assetId = Console.ReadKey();
            int id;
            Int32.TryParse(assetId.KeyChar.ToString(), out id);

            return id;
        }

        public int AssetTypeSelectionView()
        {
            CustomerStatements.CallToAction(" Please enter asset Type for asset you want to see Press:");
            CustomerStatements.CallToAction(" 1 for CRYPTOCURRENCY, 2 for STOCKS 3, 3 for REAL-ESTATES, 4 for OTHERS");
            Console.WriteLine();
            var assetId = Console.ReadKey();
            int id;
            Int32.TryParse(assetId.KeyChar.ToString(), out id);

            return id;
        }

       
        
        // Total asses value 

        public decimal FullWalletValue()
        {

            decimal walletValue = Assets.Sum(asset => asset.AssetValue);
            Console.WriteLine();
            Console.WriteLine(" Total value of Your Walletis :{0}", walletValue);
            Console.WriteLine();
            return walletValue;
        }


        // Assets value acording to category

        public int AddNewAssetBalanceView()
        {

            
            CustomerStatements.CallToAction(" Please choose Appropriate ASSET-CLASS for BALANCE");
            CustomerStatements.CallToAction(" 1 for CRYPTOCURRENCY, 2 for STOCKS 3, 3 for REAL-ESTATES, 4 for OTHERS");



        WrongKey:
          
            var assetId = Console.ReadKey();
            int id;
            int.TryParse(assetId.KeyChar.ToString(), out id);
            switch (id)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine(" - Wrong Key , Please choose again Appropiate ASSET=CLASS");
                    goto WrongKey;

            }

            return id;
        }

        public void AddNewBalance(int balanceId)
        {
          List<Asset> balanceToShow = new List<Asset>();

            foreach(var asset in Assets)
            {
                if (asset.TypeId == balanceId)
                {
                    balanceToShow.Add(asset);
                }
            }


            string assetName = default;
            switch (balanceId)
            {

                case 1:
                    assetName = "CRYPTOCURRENCIES";
                    break;
                case 2:
                    assetName = "STOCKS_BONDS";
                    break;
                case 3:
                    assetName = "REAL_ESTATES";
                    break;
                case 4:
                    assetName = "OTHERS";
                    break;
                default:
                    break;
            }

            decimal balance = balanceToShow.Sum(asset => asset.AssetValue);
            int count = balanceToShow.Count;
            Console.WriteLine();
            Console.WriteLine(" Total value of Your {0} is :{1}", assetName,balance);
            Console.WriteLine();
        }


        // Total Invested Money
        
        public decimal MoneyInvested()

        {

            decimal moneyInvested = Assets.Sum(asset => asset.InvestedMoney);
            Console.WriteLine();
            Console.WriteLine(" Total Money You invested is :{0}", moneyInvested);
            Console.WriteLine();

            return moneyInvested;

        }

        //Financial Result
        
        public void FinancialResult()
        {


            decimal result = FullWalletValue() - MoneyInvested();

            if (result>0)
            {
                CustomerStatements.CallToAction($" Your total PROFIT is:{result}");

            }else if(result<0)
            {
                CustomerStatements.CallToAction($" Your total LOSS is:{result}");
            }
            else
            {
                CustomerStatements.CallToAction($" Your NET result is 0");

            }

        }
        

    }
}
