﻿using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
	public partial class TowerEvents
	{
		public class UpgradeEvent : EventBaseCancellable
		{
			public ITowerEntity tower;
			public UpgradeEvent(ITowerEntity tower) : base("TowerUpgradeEvent")
			{
				this.tower = tower;
			}
		}
	}
}
