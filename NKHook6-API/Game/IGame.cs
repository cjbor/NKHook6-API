﻿namespace NKHook6.API.Game
{
    /// <summary>
    /// The game instance
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Get the player
        /// </summary>
        /// <returns>The player</returns>
        IPlayer getPlayer();
        /// <summary>
        /// Get any player in the game instance
        /// </summary>
        /// <param name="index">The index of the player to get</param>
        /// <returns>A player</returns>
        IPlayer getPlayer(int index);
        /// <summary>
        /// Get the health
        /// </summary>
        /// <returns>The health</returns>
        double getHealth();
        /// <summary>
        /// Set the game's health
        /// </summary>
        /// <param name="value">The value to set the health</param>
        void setHealth(double value);
    }
}
