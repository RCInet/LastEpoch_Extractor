﻿using System.Linq;

namespace LastEpochMods.Mods
{
    public class Ability_mods
    {
        public static void LoadSkillsHelper()
        {
            if ((Scenes.CurrentName != "") && (!Scenes.MenuNames.Contains(Scenes.CurrentName)))
            {
                SkillsHelper.Helper_Skills_Nodes();
            }
            else { Main.logger_instance.Msg("Go in game for launching Skills Helper"); }
        }
    }
}
