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
            Assert.IsTrue(oRover.Orientation == Orientations.N, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(0, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(1, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Moves three steps forward. Testing multiple commands
        /// </summary>
        [TestMethod]
        public void MoveForward3Steps()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover();
            oRover.ProcessCommands("FFF");
            Assert.IsTrue(oRover.Orientation == Orientations.N, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(0, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(3, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Moves one step backward
        /// </summary>
        [TestMethod]
        public void MoveBackward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(2, 2, Orientations.N);
            oRover.ProcessCommands("B");
            Assert.IsTrue(oRover.Orientation == Orientations.N, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(2, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(1, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Turns left
        /// </summary>
        [TestMethod]
        public void TurnLeft()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover();
            oRover.ProcessCommands("L");
            Assert.IsTrue(oRover.Orientation == Orientations.W, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(0, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(0, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Turns left and moves one step forward 
        /// </summary>
        [TestMethod]
        public void TurnLeftAndMoveForward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(2, 2, Orientations.N);
            oRover.ProcessCommands("LF");
            Assert.IsTrue(oRover.Orientation == Orientations.W, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(1, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(2, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Turns left and moves one step backward
        /// </summary>
        [TestMethod]
        public void TurnLeftAndMoveBackward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(2, 2, Orientations.N);
            oRover.ProcessCommands("LB");
            Assert.IsTrue(oRover.Orientation == Orientations.W, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(3, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(2, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Turns right
        /// </summary>
        [TestMethod]
        public void TurnRight()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover();
            oRover.ProcessCommands("R");
            Assert.IsTrue(oRover.Orientation == Orientations.E, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(0, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(0, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Turns right and moves one step forward 
        /// </summary>
        [TestMethod]
        public void TurnRightAndMoveForward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover();
            oRover.ProcessCommands("RF");
            Assert.IsTrue(oRover.Orientation == Orientations.E, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(1, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(0, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Turns right and moves one step backward
        /// </summary>
        [TestMethod]
        public void TurnRightAndMoveBackward()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(2, 2, Orientations.N);
            oRover.ProcessCommands("RB");
            Assert.IsTrue(oRover.Orientation == Orientations.E, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(1, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(2, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Moves out of width bounds and appears in the other side of the surface
        /// </summary>
        [TestMethod]
        public void MoveOutOfWidthBounds()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(98, 2, Orientations.E);
            oRover.ProcessCommands("FFF");
            Assert.IsTrue(oRover.Orientation == Orientations.E, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(1, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(2, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Moves out of height bounds and appears in the other side of the surface
        /// </summary>
        [TestMethod]
        public void MoveOutOfHeightBounds()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Rover oRover = new Rover(2, 98, Orientations.N);
            oRover.ProcessCommands("FFF");
            Assert.IsTrue(oRover.Orientation == Orientations.N, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(2, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(1, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
        }

        /// <summary>
        /// Finds an obstacle and stops
        /// </summary>
        [TestMethod]
        public void FindObstacle()
        {
            Surface.Width = 100;
            Surface.Height = 100;
            Surface.ObstaclesList = new System.Collections.Generic.List<Coordinates>();
            Surface.ObstaclesList.Add(new Coordinates() { X = 2, Y = 4 });
            Rover oRover = new Rover(2, 2, Orientations.N);
            oRover.ProcessCommands("FFFFFF");
            Assert.IsTrue(oRover.Orientation == Orientations.N, "Orientation test failed. Current orientation is " + oRover.Orientation);
            Assert.AreEqual(2, oRover.Position.X, "X position test failed. Position X = " + oRover.Position.X);
            Assert.AreEqual(3, oRover.Position.Y, "Y position test failed. Position Y = " + oRover.Position.Y);
            Assert.IsTrue(oRover.HasFoundObstacle, "Obstacle test failed");
        }
    }
}
