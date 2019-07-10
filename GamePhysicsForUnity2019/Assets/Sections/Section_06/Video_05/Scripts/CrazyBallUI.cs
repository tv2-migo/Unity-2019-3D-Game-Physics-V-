﻿using RMC.UnityGamePhysics.Shared;
using UnityEngine;
using UnityEngine.UI;

namespace RMC.UnityGamePhysics.Sections.Section06.Video05
{
	public class CrazyBallUI : MonoBehaviour
	{
		/// <summary>
		/// Setup "Singleton" Design Pattern
		/// See http://bit.ly/Unity_Singleton
		/// </summary>
		private static CrazyBallUI _instance;
		public static CrazyBallUI Instance { get { return _instance; } }

		[SerializeField]
		private Text _timeText = null;

		[SerializeField]
		private Text _scoreText = null;

		[SerializeField]
		private Text _resultText = null;

		protected void Awake()
		{
			_instance = this;
		}

		public void ShowTime(float value)
		{
			value = Mathf.RoundToInt(value);
			_timeText.text = string.Format("Time: {0:00}", value);
		}

		public void ShowScore(int value)
		{
			_scoreText.text = string.Format("Score: {0:00}", value);
		}

		public void ShowResult(bool isWin)
		{
			if (isWin)
			{
				_resultText.text = string.Format("You Win!");
				SoundManager.Instance.PlayAudioClip(CrazyBallConstants.WinSound);
			}
			else
			{
				_resultText.text = string.Format("You Lose!");
				SoundManager.Instance.PlayAudioClip(CrazyBallConstants.LoseSound);
			}
		}
	}
}