﻿using System;

namespace ChristmasStory.Utility
{
    internal static class Conditions
    {
        public enum CONDITION
        {
            SHIP_DESTROYED,
            SHIP_NEAR_VILLAGE,

            // Chert
            CHERT_SHIP_NEAR,
            CHERT_SHIP_FAR,
            HOLDING_CORE,
            HOLDING_DLC_ITEM,
            HOLDING_JUNK_ITEM,
            CHERT_CORE_DONE,
            CHERT_DLC_ITEM_DONE,
            CHERT_ALL_DONE,
            CHERT_START_DONE,

            // Esker
            ESKER_SHIP_NEAR,
            ESKER_SHIP_FAR,
            ESKER_START_DONE,
            ESKER_SHIP_DONE,

            // Feldspar
            FELDSPAR_SHIP_NEAR,
            FELDSPAR_SHIP_FAR,
            FELDSPAR_START_DONE,
            FELDSPAR_SHIP_DONE,

            // Self
            NPC_PLAYER_SHIP_NEAR,
            NPC_PLAYER_SHIP_FAR,
            NPC_PLAYER_START_DONE,
            NPC_PLAYER_SHIP_DONE,

            // Riebeck
            RIEBECK_SHIP_NEAR,
            RIEBECK_SHIP_FAR,
            RIEBECK_START_DONE,
            RIEBECK_SHIP_DONE,

			// Solanum
			SOLANUM_START,
			SOLANUM_START_DONE,
			HOLDING_INVITE_STONE
		}

        public enum PERSISTENT
        {
            CHERT_DONE,
			CHERT_PHRASE_TOLD,
			CHERT_PHRASE_KNOWN_NEXT_LOOP,

			ESKER_DONE,
            FELDSPAR_DONE,
            GABBRO_DONE,
            SELF_DONE,
            RIEBECK_DONE,
            SOLANUM_DONE,
        }

        public static bool Get(PERSISTENT condition) => PlayerData.GetPersistentCondition(condition.ToString());

        public static void Set(PERSISTENT condition, bool value) => PlayerData.SetPersistentCondition(condition.ToString(), value);

        public static bool Get(CONDITION condition) => DialogueConditionManager.SharedInstance.GetConditionState(condition.ToString());

        public static void Set(CONDITION condition, bool value) => DialogueConditionManager.SharedInstance.SetConditionState(condition.ToString(), value);


        public static void ResetAllConditions()
        {
            foreach (CONDITION condition in Enum.GetValues(typeof(CONDITION)))
            {
                Set(condition, false);
            }

            foreach (PERSISTENT condition in Enum.GetValues(typeof(PERSISTENT)))
            {
                Set(condition, false);
            }
        }
    }
}
