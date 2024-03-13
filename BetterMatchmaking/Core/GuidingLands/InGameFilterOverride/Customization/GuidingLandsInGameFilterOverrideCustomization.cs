﻿using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterMatchmaking;

internal class GuidingLandsInGameFilterOverrideCustomization : SingletonAccessor
{
	public ExpeditionObjectiveFilterCustomization ExpeditionObjective { get; set; } = new();
	public LanguageFilterCustomization Language { get; set; } = new();


	public GuidingLandsInGameFilterOverrideCustomization()
	{
		InstantiateSingletons();
	}

	public GuidingLandsInGameFilterOverrideCustomization Init()
	{
		ExpeditionObjective.Init();
		Language.Init();

		return this;
	}

	public bool RenderImGui()
	{
		var changed = false;
		if(ImGui.TreeNode(LocalizationManager_I.ImGui.InGameFilterOverride))
		{
			changed = ExpeditionObjective.RenderImGui() || changed;
			changed = Language.RenderImGui() || changed;

			ImGui.TreePop();
		}

		return changed;
	}
}
