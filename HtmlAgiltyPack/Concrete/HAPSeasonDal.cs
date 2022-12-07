using EntityLayer.Concrete;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlAgiltyPack.Concrete
{
    public class HAPSeasonDal
    {
        public HAPSeasonDal()
        {
            HtmlWeb = new HtmlWeb();
            Season = new Season();

        }

        public HtmlWeb HtmlWeb { get; set; }
        public Season Season { get; set; }

        public Season GetSeasonInfos(int year)//sezon bilgilerinin çekildiği metod
        {
            //https://www.transfermarkt.com.tr/super-lig/startseite/wettbewerb/TR1/plus/?saison_id=2021
            string urlAdress = "https://www.transfermarkt.com.tr/super-lig/startseite/wettbewerb/TR1/plus/?saison_id=" + year;
            var doc = HtmlWeb.Load(urlAdress);
            Season.Champion = doc.DocumentNode.SelectSingleNode(xpath: "//*[@id=\"yw3\"]/table/tbody/tr[1]/td[3]/a").InnerText;//td3 de şampiyon adı yazıyor
            Season.SeasonYear = year;
            Season.GoalKing = doc.DocumentNode.SelectSingleNode(xpath: "//table[@class='inline-table']").InnerText.Replace("Santrafor", "").Replace("On Numara", "").Replace("Sağ Kanat", "").Replace("Sol Kanat", "").Replace("Merkez orta saha", "");
            //inner textte verilen oyuncunun mevkisi verileri çekerken sorun çıkarttığı için hepsinin "" (null) olarak ayarladım
            Season.GoalKingScore = Convert.ToInt16(doc.DocumentNode.SelectSingleNode(xpath: "//*[@id=\"yw2\"]/table/tbody/tr[1]/td[5]").InnerText);
            //td5 deattığı gol sayısı yazıyor
            return Season;
        }

    }
}
