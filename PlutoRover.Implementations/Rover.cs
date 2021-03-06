﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlutoRover.Implementations.Helpers;

namespace PlutoRover.Implementations
{
    public class Rover
    {
        #region Properties
        /// <summary>
        /// Orientation of the Rover
        /// </summary>
        public Orientations Orientation { get; set; }

        /// <summary>
        /// Current position
        /// </summary>
        public Coordinates Position { get; set; }

        /// <summary>
        /// Returns if an obstacle has been found
        /// </summary>
        public bool HasFoundObstacle { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        public Rover()
        {
            HasFoundObstacle = false;
            Orientation = Orientations.N;
            Position = new Coordinates() { X = 0, Y = 0 };
        }

        public Rover(int xPos, int yPos, Orientations orientation)
        {
            HasFoundObstacle = false;
            Position = new Coordinates() { X = xPos, Y = yPos };
            Orientation = orientation;
        }
        #endregion
        #region Public methods
        public void ProcessCommands(string commands)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'F':
                        MoveForward();
                        break;
                    case 'B':
                        MoveBackward();
                        break;
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                }
                if (HasFoundObstacle)
                {
                    return;
                }
            }
        }
        #endregion
        #region Private Methods
        /// <summary>
        /// Moves the Rover forward
        /// </summary>
        private void MoveForward()
        {
            Coordinates nextPosition = GetForwardPosition(Position);
            if (Surface.ObstaclesList != null && Surface.ObstaclesList.Any(x => x.X == nextPosition.X && x.Y == nextPosition.Y))
            {
                HasFoundObstacle = true;
                return;
            }
            Position = nextPosition;
        }
        private Coordinates GetForwardPosition(Coordinates currentPosition)
        {
            Coordinates coords = new Coordinates();
            switch (Orientation)
            {
                case Orientations.N:
                    coords.Y = (currentPosition.Y + 1) % Surface.Height;
                    coords.X = currentPosition.X;
                    break;
                case Orientations.S:
                    coords.Y = currentPosition.Y == 0 ? Surface.Height - 1 : currentPosition.Y - 1;
                    coords.X = currentPosition.X;
                    break;
                case Orientations.E:
                    coords.X = (currentPosition.X + 1) % Surface.Width;
                    coords.Y = currentPosition.Y;
                    break;
                case Orientations.W:
                    coords.X = currentPosition.X == 0 ? Surface.Width - 1 : currentPosition.X - 1;
                    coords.Y = currentPosition.Y;
                    break;
            }
            return coords;
        }
        /// <summary>
        /// Moves the Rover forward
        /// </summary>
        private void MoveBackward()
        {
            Coordinates nextPosition = GetBackwardPosition(Position);
            if (Surface.ObstaclesList != null && Surface.ObstaclesList.Any(x => x.X == nextPosition.X && x.Y == nextPosition.Y))
            {
                HasFoundObstacle = true;
                return;
            }
            Position = nextPosition;
        }

        private Coordinates GetBackwardPosition(Coordinates currentPosition)
        {
            Coordinates coords = new Coordinates();
            switch (Orientation)
            {
                case Orientations.N:
                    coords.Y = currentPosition.Y == 0 ? Surface.Height - 1 : currentPosition.Y - 1;
                    coords.X = currentPosition.X;
                    break;
                case Orientations.S:
                    coords.Y = (currentPosition.Y + 1) % Surface.Height;
                    coords.X = currentPosition.X;
                    break;
                case Orientations.E:
                    coords.X = currentPosition.X == 0 ? Surface.Width - 1 : currentPosition.X - 1;
                    coords.Y = currentPosition.Y;
                    break;
                case Orientations.W:
                    coords.X = (currentPosition.X + 1) % Surface.Width;
                    coords.Y = currentPosition.Y;
                    break;
            }
            return coords;
        }
        /// <summary>
        /// Turns the Rover Left
        /// </summary>
        private void TurnLeft()
        {
            Orientation = (Orientation - 1) < Orientations.N ? Orientations.W : Orientation - 1;
        }

        /// <summary>
        /// Turns the Rover right
        /// </summary>
        private void TurnRight()
        {
            Orientation = (Orientation + 1) > Orientations.W ? Orientations.N : Orientation + 1;
        }
        #endregion
    }
}
