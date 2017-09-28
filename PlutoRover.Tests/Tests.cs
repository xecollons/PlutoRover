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

        /// <summary>
        /// Moves one step forward
        /// </summary>
        [TestMethod]
        public void MoveForward3Steps()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover();
            oRover.ProcessCommands("FFF");
            Assert.IsTrue(oRover.Orientation == Orientations.N, "Orientation test failed");
            Assert.AreEqual(0, oRover.Position.X, "X position test failed");
            Assert.AreEqual(3, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void MoveBackward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(2, 2, Orientations.N);
            oRover.ProcessCommands("B");
            Assert.IsTrue(oRover.Orientation == Orientations.N, "Orientation test failed");
            Assert.AreEqual(2, oRover.Position.X, "X position test failed");
            Assert.AreEqual(1, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void TurnLeft()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover();
            oRover.ProcessCommands("L");
            Assert.IsTrue(oRover.Orientation == Orientations.W, "Orientation test failed");
            Assert.AreEqual(0, oRover.Position.X, "X position test failed");
            Assert.AreEqual(0, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void TurnLeftAndMoveForward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(2, 2, Orientations.N);
            oRover.ProcessCommands("LF");
            Assert.IsTrue(oRover.Orientation == Orientations.W, "Orientation test failed");
            Assert.AreEqual(1, oRover.Position.X, "X position test failed");
            Assert.AreEqual(2, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void TurnLeftAndMoveBackward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(2, 2, Orientations.N);
            oRover.ProcessCommands("LB");
            Assert.IsTrue(oRover.Orientation == Orientations.W, "Orientation test failed");
            Assert.AreEqual(3, oRover.Position.X, "X position test failed");
            Assert.AreEqual(2, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void TurnRight()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover();
            oRover.ProcessCommands("R");
            Assert.IsTrue(oRover.Orientation == Orientations.E, "Orientation test failed");
            Assert.AreEqual(0, oRover.Position.X, "X position test failed");
            Assert.AreEqual(0, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void TurnRightAndMoveForward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover();
            oRover.ProcessCommands("RF");
            Assert.IsTrue(oRover.Orientation == Orientations.E, "Orientation test failed");
            Assert.AreEqual(1, oRover.Position.X, "X position test failed");
            Assert.AreEqual(0, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void TurnRightAndMoveBackward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(2, 2, Orientations.N);
            oRover.ProcessCommands("RB");
            Assert.IsTrue(oRover.Orientation == Orientations.E, "Orientation test failed");
            Assert.AreEqual(1, oRover.Position.X, "X position test failed");
            Assert.AreEqual(2, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void MoveOutOfWidthBounds()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(98, 2, Orientations.E);
            oRover.ProcessCommands("FFF");
            Assert.IsTrue(oRover.Orientation == Orientations.E, "Orientation test failed");
            Assert.AreEqual(1, oRover.Position.X, "X position test failed");
            Assert.AreEqual(2, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void MoveOutOfHeightBounds()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(2, 98, Orientations.N);
            oRover.ProcessCommands("FFF");
            Assert.IsTrue(oRover.Orientation == Orientations.E, "Orientation test failed");
            Assert.AreEqual(2, oRover.Position.X, "X position test failed");
            Assert.AreEqual(1, oRover.Position.Y, "Y position test failed");
        }

        [TestMethod]
        public void FindObstacle()
        {
            Assert.IsTrue(false);
        }
    }
}
