using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsManager
{
    class Asset
    {
  
        public int Id { get; set; }            
        public string Shortcut { get; set; }
        public string Name { get; set; }

        public string AssetClass { get; set; }
        public string Placement { get; set; }
        public decimal Amount { get; set; }
        public decimal InvestitionPrice { get; set; }

        public decimal InvestedMoney { get; set; }
        public decimal CurrentPrice { get; set; }
        
        public decimal AssetValue { get; set;}

        public decimal AssetBalance { get; set;}
        public int CategoryID { get; set; }
        public int TypeId { get; set; }
    }
}
