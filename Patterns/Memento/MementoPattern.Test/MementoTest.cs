using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MementoPattern.Test
{
    [TestClass]
    public class MementoTest
    {
        [TestMethod]
        public void MementoPositiveTest()
        {
            // player has completed level 1
            OriginatorPlayer player = new OriginatorPlayer
            {
                Level = 1,
                Score = 100,
                Health = "100%"
            };

            Console.WriteLine("----------- Player info after completing level 1 ---------------------");
            player.DisplayPlayerInfo();
            // when player completes any level then create checkpoint for that level.
            CareTaker careTaker = new CareTaker { LevelMarker = player.CreateMarker(player) };
            
            player.Level = 2;
            player.Score = 130;
            player.Health = "80%";
            Console.WriteLine("--------------- Player info in level 2 --------------------------------");
            player.DisplayPlayerInfo();

            // if players loses all the lifeline then restore the game from level 1
            player.RestoreLevel(careTaker.LevelMarker);
            Console.WriteLine("------------- Player info after restoring level 1 data ----------------");
            player.DisplayPlayerInfo();
            Console.ReadLine();
        }
    }
}
