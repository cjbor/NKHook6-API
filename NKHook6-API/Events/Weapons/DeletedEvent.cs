﻿using NKHook6.API.Towers.Weapons;

namespace NKHook6.API.Events._Weapons
{
	public partial class WeaponEvents
	{
		public class DeletedEvent : EventBaseCancellable
		{
			public IWeapon weapon;

			public DeletedEvent(IWeapon weapon) : base("WeaponDeletedEvent")
			{
				this.weapon = weapon;
			}
		}
	}
}
