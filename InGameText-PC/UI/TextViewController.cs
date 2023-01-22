using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.FloatingScreen;
using BeatSaberMarkupLanguage.ViewControllers;
using HMUI;
using InGameText.Configuration;
using SiraUtil.Logging;
using TMPro;
using Tweening;
using UnityEngine;
using Zenject;

namespace InGameText.UI.ViewControllers
{
    internal class TextViewController : BSMLAutomaticViewController, IInitializable
    {
        private SiraLog _siraLog = null!;
        private InGameTextConfig _config = null!;

        private FloatingScreen _floatingScreen = null!;
        private TextMeshProUGUI? _text;

        [Inject]
        internal void Construct(SiraLog siraLog, InGameTextConfig config)
        {
            _siraLog = siraLog;
            _config = config;
        }

        public void Initialize()
        {
            var posX = _config.PositionX;
            var posY = _config.PositionY;
            var posZ = _config.PositionZ;

            var rotX = _config.RotationX;
            var rotY = _config.RotationY;
            var rotZ = _config.RotationZ;

            var textConfig = _config.TextConfig;
            var textColor = _config.TextColor;
            var textSize = _config.TextSize;
            var textEnabled = _config.TextEnabled;

            var rot = Quaternion.Euler(rotX, rotY, rotZ);

            _floatingScreen = FloatingScreen.CreateFloatingScreen(new Vector2(0.0f, 0.0f), false, new Vector3(posX, posY, posZ), rot, curvatureRadius: 0f, false);
            _floatingScreen.enabled = textEnabled;

            var canvas = _floatingScreen.gameObject.AddComponent<Canvas>();

            var canvasTransform = canvas.transform;
            canvasTransform.position = Vector3.zero;

            if (canvasTransform is RectTransform canvasRectTransform)
            {
                _text = BeatSaberUI.CreateText<TextMeshProUGUI>(canvasRectTransform, textConfig, Vector2.zero);
                _text.alignment = TextAlignmentOptions.Center;
                _text.fontSize = textSize;
                _text.color = textColor;
                _text.enabled = textEnabled;
            }
        }
    }
}