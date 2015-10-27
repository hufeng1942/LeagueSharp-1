﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DZAwarenessAIO.Utility;
using DZAwarenessAIO.Utility.HudUtility;
using DZAwarenessAIO.Utility.Logs;
using DZAwarenessAIO.Utility.MenuUtility;
using LeagueSharp;
using LeagueSharp.Common;

namespace DZAwarenessAIO.Modules.SSTracker
{
    class SSTrackerBase : ModuleBase
    {
        public override void CreateMenu()
        {
            try
            {
                var RootMenu = Variables.Menu;
                var moduleMenu = new Menu("SS Tracker", "dz191.dza.sstracker");
                {
                    moduleMenu.AddBool("dz191.dza.sstracker.hud", "Track in Hud", true);
                    //moduleMenu.AddBool("dz191.dza.sstracker.minimap", "Track in minimap", true);
                    RootMenu.AddSubMenu(moduleMenu);
                }
            }
            catch (Exception e)
            {
                LogHelper.AddToLog(new LogItem("SSTracker_Base", e));
            }

        }

        public override void InitEvents()
        {
            SSTrackerModule.OnLoad();
        }

        public override ModuleTypes GetModuleType()
        {
            return ModuleTypes.General;
        }

        public override bool ShouldRun()
        {
            return HudDisplay.ShouldBeVisible;
        }

        public override void OnTick(){ }
    }
}
