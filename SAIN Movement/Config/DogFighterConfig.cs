﻿using BepInEx.Configuration;

namespace SAIN_Audio.Movement.Config
{
    internal class DogFighterConfig
    {
        public static ConfigEntry<bool> DodgeToggle { get; private set; }
        public static ConfigEntry<bool> ScavDodgeToggle { get; private set; }

        public static ConfigEntry<bool> LeanToggle { get; private set; }
        public static ConfigEntry<bool> ScavLeanToggle { get; private set; }

        public static ConfigEntry<bool> MoveSpeedToggle { get; private set; }
        public static ConfigEntry<bool> ScavMoveSlowerToggle { get; private set; }

        public static ConfigEntry<float> DogFighterStart { get; private set; }
        public static ConfigEntry<float> DogFighterEnd { get; private set; }

        public static void Init(ConfigFile Config)
        {
            string dogfighter = "1. DogFighter";

            DodgeToggle = Config.Bind(dogfighter,
                "Strafing at close range",
                true, new ConfigDescription(
                "Bots will randomly strafe to evade shots in close quarters when engaging enemies", null, new ConfigurationManagerAttributes
                { IsAdvanced = false, Order = 10 }));
            ScavDodgeToggle = Config.Bind(dogfighter,
                "Scavs Strafing",
                false, new ConfigDescription(
                "Allows Scavs to also strafe", null, new ConfigurationManagerAttributes
                { IsAdvanced = false, Order = 9 }));

            LeanToggle = Config.Bind(dogfighter,
                "Dynamic Lean",
                true, new ConfigDescription(
                "Enables Fully Dynamic Lean based on corner angles between a bot and their enemy.", null, new ConfigurationManagerAttributes
                { IsAdvanced = false, Order = 8 }));
            ScavLeanToggle = Config.Bind(dogfighter,
                "Scav Dynamic Lean",
                false, new ConfigDescription(
                "Enables Scavs using Dynamic Lean", null, new ConfigurationManagerAttributes
                { IsAdvanced = false, Order = 7 }));

            MoveSpeedToggle = Config.Bind(dogfighter,
                "Experimental Modified MoveSpeed",
                false, new ConfigDescription(
                "Bots will move slower at peace, speed up when in combat, and move as fast as possible when in close range battle", null, new ConfigurationManagerAttributes
                { IsAdvanced = false, Order = 6 }));
            ScavMoveSlowerToggle = Config.Bind(dogfighter,
                "Experimental Slower Scavs",
                false, new ConfigDescription(
                "Scavs will walk around at a slower pace than other bot types when not in combat", null, new ConfigurationManagerAttributes
                { IsAdvanced = false, Order = 5 }));

            DogFighterStart = Config.Bind(dogfighter,
                "Dog Fighter Start",
                20.0f, new ConfigDescription(
                "Requires Raid Restart, The distance to start Dog Fight Behavior", new AcceptableValueRange<float>
                (1f, 200.0f), new ConfigurationManagerAttributes
                { IsAdvanced = true, Order = 2 }));
            DogFighterEnd = Config.Bind(dogfighter,
                "Dog Fighter End",
                25.0f, new ConfigDescription(
                "Requires Raid Restart, The distance to end Dog Fight Behavior", new AcceptableValueRange<float>
                (2f, 210.0f), new ConfigurationManagerAttributes
                { IsAdvanced = true, Order = 1 }));

        }
    }
}