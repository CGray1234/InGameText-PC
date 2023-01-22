using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;
using HMUI;
using IPA.Loader;
using SiraUtil.Logging;
using SiraUtil.Web.SiraSync;
using SiraUtil.Zenject;
using Tweening;
using UnityEngine;
using Zenject;
using BeatSaberMarkupLanguage.Components.Settings;
using IPA.Utilities;
using UnityEngine.UI;
using System;
using InGameText;
using InGameText.Configuration;

namespace InGameText.UI.ViewControllers
{
	[HotReload(RelativePathToLayout = @"./settings.bsml")]
	[ViewDefinition("InGameText.UI.settings.bsml")]
	internal class IGTViewController : BSMLAutomaticViewController
	{
		private SiraLog _siraLog = null!;
		private InGameTextConfig _pluginConfig = null!;
		private PluginMetadata _pluginMetadata = null!;
		private ISiraSyncService _siraSyncService = null!;

		[Inject]
		private void Construct(SiraLog siraLog, InGameTextConfig pluginConfig, UBinder<Plugin, PluginMetadata> pluginMetadata, ISiraSyncService siraSyncService)
		{
			_siraLog = siraLog;
			_pluginConfig = pluginConfig;
			_pluginMetadata = pluginMetadata.Value;
			_siraSyncService = siraSyncService;
		}

		[UIValue("Enabled")]
		private bool textEnabled
		{
			get => _pluginConfig.TextEnabled;
			set
			{
				_pluginConfig.TextEnabled = value;
				NotifyPropertyChanged();
			}
		}

		[UIValue("TextConfig")]
		private string textSetting
        {
			get => _pluginConfig.TextConfig;
			set
			{
				_pluginConfig.TextConfig = value;
				NotifyPropertyChanged();
			}
		}

		[UIValue("TextColor")]
		private Color textColor
        {
			get => _pluginConfig.TextColor;
			set
			{
				_pluginConfig.TextColor = value;
				NotifyPropertyChanged();
			}
		}

		[UIValue("TextSize")]
		private float textSize
        {
			get => _pluginConfig.TextSize;
			set
			{
				_pluginConfig.TextSize = value;
				NotifyPropertyChanged();
			}
		}

		[UIValue("PosX")]
		private float posX
        {
			get => _pluginConfig.PositionX;
			set
			{
				_pluginConfig.PositionX = value;
				NotifyPropertyChanged();
			}
		}

		[UIValue("PosY")]
		private float posY
		{
			get => _pluginConfig.PositionY;
			set
			{
				_pluginConfig.PositionY = value;
				NotifyPropertyChanged();
			}
		}

		[UIValue("PosZ")]
		private float posZ
		{
			get => _pluginConfig.PositionZ;
			set
			{
				_pluginConfig.PositionZ = value;
				NotifyPropertyChanged();
			}
		}

		[UIValue("RotX")]
		private float rotX
		{
			get => _pluginConfig.RotationX;
			set
			{
				_pluginConfig.RotationX = value;
				NotifyPropertyChanged();
			}
		}

		[UIValue("RotY")]
		private float rotY
		{
			get => _pluginConfig.RotationY;
			set
			{
				_pluginConfig.RotationY = value;
				NotifyPropertyChanged();
			}
		}

		[UIValue("RotZ")]
		private float rotZ
		{
			get => _pluginConfig.RotationZ;
			set
			{
				_pluginConfig.RotationZ = value;
				NotifyPropertyChanged();
			}
		}
	}
}