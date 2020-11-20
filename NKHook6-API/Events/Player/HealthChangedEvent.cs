﻿using NKHook6.API.Towers;
using System.Runtime.InteropServices;

namespace NKHook6.API.Events._Player
{
	public partial class PlayerEvents
	{
		public class HealthChangedEvent : EventBaseCancellable
		{
			public Game game;
			public double oldCash;
			public double newCash;
			public Tower tower;

			public HealthChangedEvent(Game game, double oldCash, double newCash, [Optional] Tower tower) : base("HealthChangedEvent")
			{
				this.game = game;
				this.oldCash = oldCash;
				this.newCash = newCash;
				this.tower = tower;
			}
		}
	}
}
