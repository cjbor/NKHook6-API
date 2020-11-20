﻿using NKHook6.API.Towers;

namespace NKHook6.API.Events._Towers
{
	public partial class TowerEvents
	{
		public class DeselectedEvent : EventBaseCancellable
		{
			public Tower tower;

			public DeselectedEvent(Tower tower) : base("TowerDeselectedEvent")
			{
				this.tower = tower;
			}
		}
	}
}
