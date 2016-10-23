using UnityEngine;
using UnityEditor;
using NUnit.Framework;
using Core.Game;

namespace Tests.Core.Game
{
    public class GameTests
    {

        [Test]
        [Category("Core Game Tests")]
        public void Test1_StartGame()
        {
            //Arrange
            var gameObject = new GameController();
            gameObject.StartGame();

            //Assert
            //The object has a new name
            Assert.AreEqual(gameObject.State, "Running");
        }
    }
}