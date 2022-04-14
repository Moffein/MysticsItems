using BepInEx.Configuration;
using System;

namespace MysticsItems
{
    public static class GeneralConfigManager
    {
        // Gameplay
        //public static ConfigEntry<bool> backpackEnableSkillFixes;

        // Effects
        public static ConfigEntry<bool> gunpowderReduceVFX;
        public static ConfigEntry<float> gunpowderScreenshakeScale;
        public static ConfigEntry<bool> gunpowderDisableSound;

        // Mod Compatibility
        public static ConfigEntry<bool> betterUICompatEnableOverrides;
        public static ConfigEntry<bool> betterUICompatEnableItemStats;
        public static ConfigEntry<bool> itemStatsCompatEnabledByConfig;
        public static ConfigEntry<bool> properSaveCompatEnabledByConfig;
        public static ConfigEntry<bool> whatAmILookingAtCompatEnabledByConfig;
        public static ConfigEntry<bool> itemDisplaysSniper;
        
        // UI
        public static ConfigEntry<bool> rhythmHudUnderCrosshair;
        public static ConfigEntry<bool> rhythmHudOverSkills;
        public static ConfigEntry<bool> rhythmHudComboText;
        
        internal static void Init()
        {
            /*
            backpackEnableSkillFixes = MysticsItemsPlugin.configGeneral.Bind<bool>(
                "Gameplay",
                "BackpackEnableSkillFixes",
                true,
                "Make certain skills require pressing a key instead of holding it down while carrying the Hikers Backpack item to fix these skills consuming all charges at once."
            );
            */

            gunpowderReduceVFX = MysticsItemsPlugin.configGeneral.Bind("Effects", "GunpowderReduceVFX", false, "Reduce the visual effects of Contraband Gunpowder explosions");
            gunpowderScreenshakeScale = MysticsItemsPlugin.configGeneral.Bind("Effects", "GunpowderScreenshakeScale", 1f, "Adjust the intensity of Contraband Gunpowder explosion screenshake");
            gunpowderDisableSound = MysticsItemsPlugin.configGeneral.Bind("Effects", "GunpowderDisableSound", false, "Disable the sound effects of Contraband Gunpowder explosions");

            betterUICompatEnableOverrides = MysticsItemsPlugin.configGeneral.Bind("Mod Compatibility", "BetterUICompatEnableOverrides", true, "Allow this mod to override certain BetterUI calculations (for example, adding Scratch Ticket chance bonus to the Crit Chance stat display).");
            betterUICompatEnableItemStats = MysticsItemsPlugin.configGeneral.Bind("Mod Compatibility", "BetterUICompatEnableItemStats", true, "Enable BetterUI's ItemStats integration.");
            itemStatsCompatEnabledByConfig = MysticsItemsPlugin.configGeneral.Bind("Mod Compatibility", "ItemStatsCompatEnable", true, "Enable ItemStats integration");
            properSaveCompatEnabledByConfig = MysticsItemsPlugin.configGeneral.Bind("Mod Compatibility", "ProperSaveCompatEnable", true, "Enable ProperSave integration");
            whatAmILookingAtCompatEnabledByConfig = MysticsItemsPlugin.configGeneral.Bind("Mod Compatibility", "WhatAmILookingAtCompatEnable", true, "Enable WhatAmILookingAt integration");
            itemDisplaysSniper = MysticsItemsPlugin.configGeneral.Bind("Mod Compatibility", "ItemDisplaysSniper", true, "Make this mod's items show up on the Sniper added by SniperClassic mod");

            rhythmHudUnderCrosshair = MysticsItemsPlugin.configGeneral.Bind("UI", "RhythmItemHUDUnderCrosshair", true, "Enable Metronome's HUD indicator under the crosshair.");
            rhythmHudOverSkills = MysticsItemsPlugin.configGeneral.Bind("UI", "RhythmItemHUDOverSkills", true, "Enable Metronome's HUD indicator over skill cooldown icons.");
            rhythmHudComboText = MysticsItemsPlugin.configGeneral.Bind("UI", "RhythmItemHUDComboText", true, "Enable the combo counter near Metronome's HUD indicators.");
        }
    }
}