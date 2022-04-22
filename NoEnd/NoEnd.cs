using OWML.Common;
using OWML.ModHelper;
using UnityEngine;
using UnityEngine.InputSystem;


namespace NoEnd
{
    public class NoEnd : ModBehaviour
    {
        private void Awake()
        {
            // You won't be able to access OWML's mod helper in Awake.
            // So you probably don't want to do anything here.
            // Use Start() instead.
        }

        private void Start()
        {
            ModHelper.Console.WriteLine($"Mod loaded!");

            ModHelper.HarmonyHelper.AddPrefix<DeathManager>("KillPlayer", typeof(NoEnd), nameof(NoEnd.NoTimeLoopEnd));
            ModHelper.HarmonyHelper.AddPrefix<DeathManager>("BeginEscapedTimeLoopSequence", typeof(NoEnd), nameof(NoEnd.NoEscapeSequence));
        }
        
        private void Update()
        {
            if (Keyboard.current.pKey.wasPressedThisFrame)
            {
                TimeLoop.SetTimeLoopEnabled(false);
            }

        }

        private static bool NoTimeLoopEnd(DeathType __0)
        {
            return __0 != DeathType.TimeLoop;
        }

        private static bool NoEscapeSequence()
        {
            return false;
        }
    }
}
