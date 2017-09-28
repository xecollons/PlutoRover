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
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        public Rover()
        {
            Orientation = Orientations.N;
            Position = new Coordinates() { X = 0, Y = 0 };
        }
        #endregion
        #region Public methods
        public void ProcessCommands(string commands)
        {
            var commandsArray = commands.Split();
            foreach (string command in commandsArray)
            {
                switch (command)
                {
                    case "F":
                        MoveForward();
                        break;
                    case "B":
                        break;
                    case "L":
                        break;
                    case "R":
                        break;
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
            switch (Orientation)
            {
                case Orientations.N:
                    Position.Y++;
                    break;
                case Orientations.S:
                    Position.Y--;
                    break;
                case Orientations.E:
                    Position.X++;
                    break;
                case Orientations.W:
                    Position.X--;
                    break;
            }
        }
        #endregion
    }
}