﻿using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolyTechFramework
{
    public abstract class PolyTechMod : BaseUnityPlugin
    {
        public static string PluginGuid;
        public static string PluginName;
        public static string PluginVersion; 

        public virtual void enableMod()
        {
            Logger.LogError("enableMod() Function Not Implemented, Please Have Mod Author Fix");
            if (Profiles.m_ActiveProfile.m_NeverShowAgain.Contains(PopUpWarningCategory.OLDER_PHYSICS_ENGINE)) return;
            PopUpMessage.Display("Something tried to automatically enable a mod, but the mod doesn't support this feature. Try setting them manually.", () => {});
        }

        public virtual void disableMod()
        {
            Logger.LogError("disableMod() Function Not Implemented, Please Have Mod Author Fix");
            if (Profiles.m_ActiveProfile.m_NeverShowAgain.Contains(PopUpWarningCategory.OLDER_PHYSICS_ENGINE)) return;
            PopUpMessage.Display("Something tried to automatically disable a mod, but the mod doesn't support this feature. Try setting them manually.", () => {});
        }

        public virtual string getSettings()
        {
            Logger.LogError("getSettings() Function Not Implemented, Please Have Mod Author Fix");
            return null;
        }

        public virtual void setSettings(string settings)
        {
            Logger.LogError("setSettings() Function Not Implemented, Please Have Mod Author Fix");
            if (Profiles.m_ActiveProfile.m_NeverShowAgain.Contains(PopUpWarningCategory.OLDER_PHYSICS_ENGINE)) return;   
            PopUpMessage.Display("Something tried to automatically set the settings for a mod, but the mod doesn't support this feature. Try setting them manually.", () => {});
        }

        public virtual byte[] saveData(){
            return new byte[] {};
        }

        public virtual void loadData(byte[] bytes){
            return;
        }
        public bool isEnabled;
        public bool isCheat;
        public string repositoryUrl;
        public string[] authors;
        public bool shouldSaveData;
    }
}
