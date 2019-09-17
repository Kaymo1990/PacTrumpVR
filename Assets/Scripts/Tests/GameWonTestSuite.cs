using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class GameWonTestSuite
    {
        // A Test behaves as an ordinary method
        [Test]
        public void GameComplete_IsFalse_ShouldBeFalseWhenGameStarts()
        {
            var gamecomplete = new GameComplete();
            Assert.False(gamecomplete.gameWon);
        }

        [Test]
        public void GameComplete_IsTrue_ShouldBeTrueWhenGameComplete()
        {
            var gamecomplete = new GameComplete();
            gamecomplete.gameStatus(true);
            Assert.True(gamecomplete.gameWon);
        }
    }
}
