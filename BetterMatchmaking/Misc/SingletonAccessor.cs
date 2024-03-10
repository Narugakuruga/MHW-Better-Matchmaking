﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BetterMatchmaking;

internal class SingletonAccessor
{
	[JsonIgnore]
	protected LocalizationManager LocalizationManager_I { get; set; }
	[JsonIgnore]
	protected ConfigManager ConfigManager_I { get; set; }
	[JsonIgnore]
	protected CustomizationWindow CustomizationWindow_I { get; set; }
	[JsonIgnore]
	protected DebugManager DebugManager_I { get; set; }



	[JsonIgnore]
	protected Core Core_I { get; set; }
	[JsonIgnore]
	protected RegionLockFix RegionLockFix_I { get; set; }
	[JsonIgnore]
	protected MaxSearchResultLimit MaxSearchResultLimit_I { get; set; }
	[JsonIgnore]
	protected SessionPlayerCountFilter SessionPlayerCountFilter_I { get; set; }
	

	
	[JsonIgnore]
	protected PlayerTypeFilter PlayerTypeFilter_I { get; set; }
	[JsonIgnore]
	protected QuestPreferenceFilter QuestPreferenceFilter_I { get; set; }
	[JsonIgnore]
	protected LanguageFilter LanguageFilter_I { get; set; }



	protected QuestTypeFilter QuestTypeFilter_I { get; set; }
	[JsonIgnore]
	protected DifficultyFilter DifficultyFilter_I { get; set; }

	protected void InstantiateSingletons()
	{
		LocalizationManager_I = LocalizationManager.Instance;
		ConfigManager_I = ConfigManager.Instance;
		CustomizationWindow_I = CustomizationWindow.Instance;
		DebugManager_I = DebugManager.Instance;

		Core_I = Core.Instance;
		RegionLockFix_I = RegionLockFix.Instance;
		MaxSearchResultLimit_I = MaxSearchResultLimit.Instance;
		SessionPlayerCountFilter_I = SessionPlayerCountFilter.Instance;

		PlayerTypeFilter_I = PlayerTypeFilter.Instance;
		QuestPreferenceFilter_I = QuestPreferenceFilter.Instance;
		LanguageFilter_I = LanguageFilter.Instance;

		QuestTypeFilter_I = QuestTypeFilter.Instance;

		DifficultyFilter_I = DifficultyFilter.Instance;

	}
}
