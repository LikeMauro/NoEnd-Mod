using OWML.Common;
using OWML.ModHelper;
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

        private void Update()
        {
            ModHelper.Console.WriteLine($"hi");

            if (Keyboard.current.numpad1Key.wasPressedThisFrame)
            {
                FindObjectOfType<DeathManager>().BeginEscapedTimeLoopSequence(TimeloopEscapeType.Ship);
            }
            if (Keyboard.current.numpad2Key.wasPressedThisFrame)
            {
                FindObjectOfType<DeathManager>().BeginEscapedTimeLoopSequence(TimeloopEscapeType.Quantum);
            }
            if (Keyboard.current.numpad3Key.wasPressedThisFrame)
            {
                FindObjectOfType<DeathManager>().BeginEscapedTimeLoopSequence(TimeloopEscapeType.Ringworld);
            }
            if (Keyboard.current.numpad4Key.wasPressedThisFrame)
            {
                FindObjectOfType<DeathManager>().BeginEscapedTimeLoopSequence(TimeloopEscapeType.Dreamworld);
            }
            if (Keyboard.current.numpad5Key.wasPressedThisFrame)
            {
                FindObjectOfType<DeathManager>().KillPlayer(deathType: DeathType.BigBang);
            }
        }
    }
}
