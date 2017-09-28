using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlutoRover.Implementations;
using PlutoRover.Implementations.Helpers;

namespace PlutoRover.Tests
{
    [TestClass]
    public class Tests
    {
        /// <summary>
        /// Moves one step forward
        /// </summary>
        [TestMethod]
        public void MoveForward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover();
            oRover.ProcessCommands("F");
            Assert.IsTrue(oRover.Orientation == Orientations.N, "Orientation test failed");
            Assert.AreEqual(0, oRover.Position.X, "X position test failed");
            Assert.AreEqual(1, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void MoveBackward()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void TurnLeft()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void TurnLeftAndMoveForward()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void TurnLeftAndMoveBackward()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void TurnRight()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void TurnRightAndMoveForward()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void TurnRightAndMoveBackward()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void MoveOutOfWidthBounds()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void MoveOutOfHeightBounds()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void FindObstacle()
        {
            Assert.IsTrue(false);
        }
    }
}
