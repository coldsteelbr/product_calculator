using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Calculator.PriceLists
{
    class StonePriceListRubles
    {
        
        private Dictionary<String, Dictionary<String, decimal>> mPriceList = new Dictionary<string, Dictionary<string, decimal>>();

        public StonePriceListRubles()
        {
            string MarbleCreamRoseGreyGranite = "Мрамор кремовый, розовый, серый гранит";
            string MarbleWhite = "Мрамор белый";
            string Granites = "Граниты";
            string GraniteIzerbel = "Гранит Изербельский";
            string Coquina = "Ракушечник";

            Dictionary<String, decimal> CreamMarbleGroup = new Dictionary<string, decimal>();
            CreamMarbleGroup.Add("20", 3500);
            CreamMarbleGroup.Add("30", 5700);
            CreamMarbleGroup.Add("40", 6400);
            CreamMarbleGroup.Add("50", 7500);
            CreamMarbleGroup.Add("60", 8000);
            CreamMarbleGroup.Add("70", 10000);
            CreamMarbleGroup.Add("80", 11500);
            CreamMarbleGroup.Add("90", -1);
            CreamMarbleGroup.Add("100", 13000);
            CreamMarbleGroup.Add("150", 14200);
            CreamMarbleGroup.Add("180", 15000);
            CreamMarbleGroup.Add("190", 17000);

            Dictionary<String, decimal> MarbleWhiteGroup = new Dictionary<string, decimal>();
            MarbleWhiteGroup.Add("20", 5000);
            MarbleWhiteGroup.Add("30", 7000);
            MarbleWhiteGroup.Add("40", 9000);
            MarbleWhiteGroup.Add("50", 11000);
            MarbleWhiteGroup.Add("60", 12000);
            MarbleWhiteGroup.Add("70", 14000);
            MarbleWhiteGroup.Add("80", 17000);
            MarbleWhiteGroup.Add("90", -1);
            MarbleWhiteGroup.Add("100", 20000);
            MarbleWhiteGroup.Add("150", -1);
            MarbleWhiteGroup.Add("180", -1);
            MarbleWhiteGroup.Add("190", -1);

            Dictionary<String, decimal> GraniteGroup = new Dictionary<string, decimal>();
            GraniteGroup.Add("20", 5500);
            GraniteGroup.Add("30", 7000);
            GraniteGroup.Add("40", 8000);
            GraniteGroup.Add("50", 8900);
            GraniteGroup.Add("60", -1);
            GraniteGroup.Add("70", -1);
            GraniteGroup.Add("80", 12000);
            GraniteGroup.Add("90", -1);
            GraniteGroup.Add("100", -1);
            GraniteGroup.Add("150", -1);
            GraniteGroup.Add("180", -1);
            GraniteGroup.Add("190", -1);

            Dictionary<String, decimal> IzerbelGroup = new Dictionary<string, decimal>();
            IzerbelGroup.Add("20", 2500);
            IzerbelGroup.Add("30", 3000);
            IzerbelGroup.Add("40", 4000);
            IzerbelGroup.Add("50", 5500);
            IzerbelGroup.Add("60", 6000);
            IzerbelGroup.Add("70", 7500);
            IzerbelGroup.Add("80", 8000);
            IzerbelGroup.Add("90", -1);
            IzerbelGroup.Add("100", 9000);
            IzerbelGroup.Add("150", 11000);
            IzerbelGroup.Add("180", 12000);
            IzerbelGroup.Add("190", 15000);

            Dictionary<String, decimal> CoquinaGroup = new Dictionary<string, decimal>();
            CoquinaGroup.Add("20", 3500);
            CoquinaGroup.Add("30", 4100);
            CoquinaGroup.Add("40", 5200);
            CoquinaGroup.Add("50", 6300);
            CoquinaGroup.Add("60", 7400);
            CoquinaGroup.Add("70", 8500);
            CoquinaGroup.Add("80", 9000);
            CoquinaGroup.Add("90", -1);
            CoquinaGroup.Add("100", -1);
            CoquinaGroup.Add("150", -1);
            CoquinaGroup.Add("180", -1);
            CoquinaGroup.Add("190", -1);

            mPriceList.Add(MarbleCreamRoseGreyGranite, CreamMarbleGroup);
            mPriceList.Add(MarbleWhite, MarbleWhiteGroup);
            mPriceList.Add(Granites, GraniteGroup);
            mPriceList.Add(GraniteIzerbel, IzerbelGroup);
            mPriceList.Add(Coquina, CoquinaGroup);
        }
    }

    class StonePriceListDollars
    {

        private Dictionary<String, Dictionary<String, decimal>> mPriceList = new Dictionary<string, Dictionary<string, decimal>>();

        public StonePriceListDollars()
        {
            string Travertine = "Травертин";
            string EmperadorDark = "Имперадор Дарк";
            string LabrodariteBluePerl = "ЛабродаритБлюПерл";
            string GraniteTanBrown = "Гранит Тан Браун";
            

            Dictionary<String, decimal> TravertineGroup = new Dictionary<string, decimal>();
            TravertineGroup.Add("20", 272);
            TravertineGroup.Add("30", -1);


            Dictionary<String, decimal> EmperadorDarkGroup = new Dictionary<string, decimal>();
            EmperadorDarkGroup.Add("20", 260);
            EmperadorDarkGroup.Add("30", -1);


            Dictionary<String, decimal> LabrodariteBluePerlGroup = new Dictionary<string, decimal>();
            LabrodariteBluePerlGroup.Add("20", 264);
            LabrodariteBluePerlGroup.Add("30", 358);


            Dictionary<String, decimal> GraniteTanBrownGroup = new Dictionary<string, decimal>();
            GraniteTanBrownGroup.Add("20", 156);
            GraniteTanBrownGroup.Add("30", 200);


            mPriceList.Add(Travertine, TravertineGroup);
            mPriceList.Add(EmperadorDark, EmperadorDarkGroup);
            mPriceList.Add(LabrodariteBluePerl, LabrodariteBluePerlGroup);
            mPriceList.Add(GraniteTanBrown, GraniteTanBrownGroup);
            
        }
    }

    class Coefficients {
        // TODO
    }
}
