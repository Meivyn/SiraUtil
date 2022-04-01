﻿using System;

namespace SiraUtil.Objects.Multiplayer
{
    /// <summary>
    /// Registers a redecorator for the lobby avatar controller.
    /// </summary>
    public sealed class LobbyAvatarRegistration : TemplateRedecoratorRegistration<MultiplayerLobbyAvatarController, MultiplayerLobbyInstaller>
    {
        /// <summary>
        /// Creates a new redecorator registration.
        /// </summary>
        /// <param name="redecorateCall">This is called when the object is being redecorated.</param>
        /// <param name="priority">The redecoration priority.</param>
        /// <param name="chain">Whether to chain this redecoration with others. Every redecoration is now aggregated.
        /// The chain will start if the highest priority object has chaining enabled and will stop once a registration
        /// in the aggregate has chaining disabled.</param>
        public LobbyAvatarRegistration(Func<MultiplayerLobbyAvatarController, MultiplayerLobbyAvatarController> redecorateCall, int priority = 0, bool chain = true) : base("_multiplayerLobbyAvatarControllerPrefab", redecorateCall, priority, chain) { }
    }
}
