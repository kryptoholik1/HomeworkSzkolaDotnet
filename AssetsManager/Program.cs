using System;
using System.ComponentModel.Design;

namespace AssetsManager
{
    class Program
    {
        static void Main(string[] args)
        {
          


            //Programm presentation
            CustomerStatements.DataAndTime();
            CustomerStatements.Header("Welcome in AssetsManager", "This Program is a tool for managing your assets");
            Console.ReadLine();

            // New Objects of Our service
            MenuActionService actionService = new MenuActionService();
            AssetService assetService = new AssetService();
           
            // Menu
            actionService = Initialize(actionService); // tworzy wszystkie elementy menu których będę używać
            while (true)
            {
                CustomerStatements.CallToAction("There is main Menu. What would you like to do?:");

                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine("{0}. {1}", mainMenu[i].Id, mainMenu[i].Name);
                }

                var operation = Console.ReadKey();
               
                switch (operation.KeyChar)
                {
                    case '1':
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════"); 
                        var keyinfo = assetService.AddNewAssetView(actionService);
                        var id = assetService.AddNewAssets(keyinfo.KeyChar);
                        break;

                    case '2':
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        assetService.AllYourAssets();
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        break;


                    case '3':
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        var removeId = assetService.RemoveAssetView();
                        assetService.RemoveAsset(removeId);
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        break;
                    case '4':
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        var detailId = assetService.AssetDetailSelectionView();
                        assetService.AssetDetailView(detailId);
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        break;
                    case '5':
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        var assetId = assetService.AssetTypeSelectionView();
                        assetService.AssetsByAssetTypeView(assetId);
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");

                        break;
                    case '6':
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        assetService.FullWalletValue();
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        break;
                    case '7':
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        var balanceId = assetService.AddNewAssetBalanceView();
                        assetService.AddNewBalance(balanceId);
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        break;
                    case '8':
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        assetService.MoneyInvested();
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        break;

                    case '9':
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        assetService.FinancialResult();
                        Console.WriteLine(" ═══════════════════════════════════════════════════════════════════════════════════════");
                        break;

               


                    default:
                        Console.WriteLine();
                        CustomerStatements.CallToAction("Nieprawidłowy klawisz , spróbuj ponownie");
                        break;

                }
            }
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add Asset", "Main");
            actionService.AddNewAction(2, "List off all your Assets", "Main");
            actionService.AddNewAction(3, "Remove Asset", "Main");
            actionService.AddNewAction(4, "Show single Asset Details", "Main");
            actionService.AddNewAction(5, "Show List of Assets in type ( CRYPTOCURRENCY , STOCKS AND BONDS, REAL-ESTATES, OTHERS)", "Main");
            actionService.AddNewAction(6, "Total Assets Value", "Main");
            actionService.AddNewAction(7, "Assets Value in Category", "Main");
            actionService.AddNewAction(8, "Total Money Invested in $" , "Main");
            actionService.AddNewAction(9, "Total Financial result", "Main");
          // actionService.AddNewAction(9, "Profit Investments", "Main");
          // actionService.AddNewAction(10, "Lost Investments", "Main");              FUTURE IMPLEMENTATIONS
          // actionService.AddNewAction(11, "Update Asset", "Main");


            actionService.AddNewAction(1, "CRYPTOCURRENCY", "AddNewAssetMenu");
            actionService.AddNewAction(2, "STOCKS AND BOND", "AddNewAssetMenu");
            actionService.AddNewAction(3, "REAL-ESTATES", "AddNewAssetMenu");
            actionService.AddNewAction(4, "OTHERS", "AddNewAssetMenu");

            actionService.AddNewAction(1, "CRYPTOCURRENCY", "AddBalanceMenu");
            actionService.AddNewAction(2, "STOCKS AND BOND", "AddBalanceMenu");
            actionService.AddNewAction(3, "REAL-ESTATES", "AddBalanceMenu");
            actionService.AddNewAction(3, "OTHERS", "AddBalanceMenu");
            return actionService;
        }
    }
}
