﻿using ChristmasStory.Utility;
using NewHorizons.Utility;
using ChristmasStory.Components;


namespace ChristmasStory.Characters.Villagers
{
	
	internal class HornfelsCharacterController : TravelerCharacterController
	{
		public override Conditions.PERSISTENT DoneCondition => Conditions.PERSISTENT.HORNFELS_FISH_TOLD;

		public override void Start()
		{
			dialogue = SearchUtilities.Find("TimberHearth_Body/Sector_TH/Hornfels_Village_Final/Hornfels_Dialogue_Final").GetComponent<CharacterDialogueTree>();

			base.Start();
		}

		protected override void Dialogue_OnStartConversation()
		{

		}

		protected override void Dialogue_OnEndConversation()
		{
			if (Conditions.Get(Conditions.CONDITION.HORNFELS_FISH_TOLD))
			{
				SearchUtilities.Find("TimberHearth_Body/Sector_TH/Sector_Village/Sector_Observatory/Interactables_Observatory/AnglerFishExhibit/AnglerFishTankPivot/Beast_Anglerfish/Ernesto_Dialogue").SetActive(true);
				SearchUtilities.Find("TimberHearth_Body/Sector_TH/Sector_Village/Sector_Observatory/Interactables_Observatory/AnglerFishExhibit/AnglerFishTankPivot/Beast_Anglerfish/B_angler_root/B_angler_body01/B_angler_body02/B_angler_antenna01/B_angler_antenna02/B_angler_antenna03/B_angler_antenna04/B_angler_antenna05/B_angler_antenna06/B_angler_antenna07/B_angler_antenna08/B_angler_antenna09/B_angler_antenna10/B_angler_antenna11/B_angler_antenna12_end/Lure_PointLight_FogLight").GetComponent<UnityEngine.Light>().intensity = 5f;
			}
			if (Conditions.Get(Conditions.CONDITION.START_END_EVENT))
			{
				PlayerEffectController.AddLock(2);
				PlayerEffectController.CloseEyes(3);
				PlayerEffectController.OpenEyes(4);

				SearchUtilities.Find("TimberHearth_Body/Sector_TH/GhostBird/Signal_Prisoner").SetActive(false);
				SearchUtilities.Find("TimberHearth_Body/Sector_TH/Traveller_HEA_Feldspar/Signal_Signal_Harmonica").SetActive(false);
				SearchUtilities.Find("TimberHearth_Body/Sector_TH/Traveller_HEA_Riebeck/Signal_Banjo").SetActive(false);
				SearchUtilities.Find("TimberHearth_Body/Sector_TH/Villager_HEA_Esker_ANIM_Rocking/Signal_Esker").SetActive(false);
				SearchUtilities.Find("TimberHearth_Body/Sector_TH/Traveller_HEA_Chert_ANIM_Chatter_Chipper/Signal_Drums").SetActive(false);
				SearchUtilities.Find("TimberHearth_Body/Sector_TH/Traveller_HEA_Gabbro/Signal_Flute").SetActive(false);
				SearchUtilities.Find("TimberHearth_Body/Sector_TH/Nomai_ANIM_SkyWatching_Idle/Signal_Nomai").SetActive(false);
				SearchUtilities.Find("TimberHearth_Body/Sector_TH/Hornfels_Village_Final/Hornfels_Dialogue_Final").SetActive(false);

				EndGameController.Instance.Invoke("StartErnestoShine", 2f);
			}
		}		
		protected override void OnChangeState(STATE oldState, STATE newState) { }
	}
}
