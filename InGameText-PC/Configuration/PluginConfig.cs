using System.Runtime.CompilerServices;
using IPA.Config.Stores;
using UnityEngine;

[assembly: InternalsVisibleTo(GeneratedStore.AssemblyVisibilityTarget)]
namespace InGameText.Configuration
{
    internal class InGameTextConfig
    {
        public static InGameTextConfig Instance { get; set; }

        public bool TextEnabled = true;
        public string TextConfig { get; set; }

        public Color TextColor { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }

        public float RotationX { get; set; }
        public float RotationY { get; set; }
        public float RotationZ { get; set; }

        public float TextSize { get; set; }
    }
}