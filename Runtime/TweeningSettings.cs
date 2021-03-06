﻿using UnityEngine;

namespace Zigurous.Tweening
{
    /// <summary>
    /// A behavior that allows tweening settings to be changed in the editor.
    /// </summary>
    [AddComponentMenu("Zigurous/Tweening/Tweening Settings")]
    public sealed class TweeningSettings : MonoBehaviour
    {
        [Tooltip("The default Ease assigned to every tween.")]
        [SerializeField]
        private Ease _defaultEase = Ease.QuadOut;

        /// <summary>
        /// The default Ease assigned to every tween.
        /// </summary>
        public Ease defaultEase
        {
            get => _defaultEase;
            set
            {
                _defaultEase = value;
                Tweening.defaultEase = value;
            }
        }

        [Tooltip("The default amount of seconds a tween takes to complete.")]
        [SerializeField]
        private float _defaultDuration = 0.3f;

        /// <summary>
        /// The default amount of seconds a tween takes to complete.
        /// </summary>
        public float defaultDuration
        {
            get => _defaultDuration;
            set
            {
                _defaultDuration = value;
                Tweening.defaultDuration = value;
            }
        }

        [Tooltip("The default amount of seconds before every tween starts.")]
        [SerializeField]
        private float _defaultDelay = 0.0f;

        /// <summary>
        /// The default amount of seconds before every tween starts.
        /// </summary>
        public float defaultDelay
        {
            get => _defaultDelay;
            set
            {
                _defaultDelay = value;
                Tweening.defaultDelay = value;
            }
        }

        [Tooltip("The default overshoot value used in easing functions.")]
        [SerializeField]
        private float _overshoot = 1.70158f;

        /// <summary>
        /// The overshoot value used in easing functions.
        /// </summary>
        public float overshoot
        {
            get => _overshoot;
            set
            {
                _overshoot = value;
                Tweening.overshoot = value;
            }
        }

        [Tooltip("The initial amount of tweens that memory is allocated for when the system starts. Additional memory will be allocated as needed.")]
        [SerializeField]
        private int _initialCapacity = 16;

        /// <summary>
        /// The initial amount of tweens that memory is allocated for when the
        /// system starts. Additional memory will be allocated as needed.
        /// </summary>
        public int initialCapacity
        {
            get => _initialCapacity;
            set
            {
                _initialCapacity = value;
                Tweening.initialCapacity = value;
            }
        }

        [Tooltip("Automatically starts tweens after being created, by default.")]
        [SerializeField]
        private bool _autoStart = true;

        /// <summary>
        /// Automatically starts tweens after being created, by default.
        /// </summary>
        public bool autoStart
        {
            get => _autoStart;
            set
            {
                _autoStart = value;
                Tweening.autoStart = value;
            }
        }

        [Tooltip("Automatically kills tweens after being completed, by default.")]
        [SerializeField]
        private bool _autoKill = true;

        /// <summary>
        /// Automatically kills tweens after being completed, by default.
        /// </summary>
        public bool autoKill
        {
            get => _autoKill;
            set
            {
                _autoKill = value;
                Tweening.autoKill = value;
            }
        }

        [Tooltip("Keeps tweens in memory to be re-used after being killed, by default.")]
        [SerializeField]
        private bool _recyclable = true;

        /// <summary>
        /// Keeps tweens in memory to be re-used after being killed, by default.
        /// </summary>
        public bool recyclable
        {
            get => _recyclable;
            set
            {
                _recyclable = value;
                Tweening.recyclable = value;
            }
        }

        private void OnValidate()
        {
            UpdateSettings();
        }

        private void Awake()
        {
            UpdateSettings();
        }

        private void UpdateSettings()
        {
            Tweening.defaultEase = this.defaultEase;
            Tweening.defaultDuration = this.defaultDuration;
            Tweening.defaultDelay = this.defaultDelay;
            Tweening.overshoot = this.overshoot;
            Tweening.initialCapacity = this.initialCapacity;
            Tweening.autoStart = this.autoStart;
            Tweening.autoKill = this.autoKill;
            Tweening.recyclable = this.recyclable;
        }

    }

}
