#region Copyright & License Information
/*
 * Copyright 2007-2014 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

namespace OpenRA.Traits
{
	[Desc("Checks for pause related desyncs. Attach this to the world actor.")]
	public class DebugPauseStateInfo : ITraitInfo
	{
		public object Create(ActorInitializer init) { return new DebugPauseState(init.world); }
	}

	public class DebugPauseState : ISync
	{
		World world;
		[Sync] public bool Paused { get { return world.Paused; } }
		public DebugPauseState(World world) { this.world = world; }
	}
}
