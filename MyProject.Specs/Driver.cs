using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyProject.Specs
                   
{
    public class Driver
    {
        
        public static IWebDriver Instance{ get; set; }
        public static string BaseAddress
        {
            get { return "https://mobilewebserver9-switchstudios.installprogram.eu/MobileWebGames/game/mgs/7_4_3_4657?lobbyURL=https%3A%2F%2Fmobilewebserver9-switchstudios.installprogram.eu%2FLobby%2Fen%2FIslandParadise%2FGames%2F3ReelSlots&moduleID=2&clientID=40302&gameName=switchEuropeanRoulette&gameTitle=Roulette&LanguageCode=en&clientTypeID=40&casinoID=5007&lobbyName=IslandParadise&loginType=PlayerService&bankingURL=https%3A%2F%2Fmobilewebserver9-switchstudios.installprogram.eu%2FLobby%2Fen%2FIslandParadise%2FBanking&xmanEndPoints=https%3A%2F%2Fmobilewebserver9-SwitchStudios.installprogram.eu%2FXMan%2Fx.x&routerEndPoints=&disablePoweredBy=false&currencyFormat=&isPracticePlay=true&logoutURL=https%3A%2F%2Fmobilewebserver9-switchstudios.installprogram.eu%2FLobby%2Fen%2FIslandParadise%2FLogout&host=Desktop&activityStatementURL=undefined"; }
        }
        public static void Intitialize ()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();

        }
        public static void Navigate()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }
        public static void Close()
        {
            Instance.Close();
        }

    }
}
