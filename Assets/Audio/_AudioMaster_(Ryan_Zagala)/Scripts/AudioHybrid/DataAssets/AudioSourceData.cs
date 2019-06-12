using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

///namespace AudioHybrid.DataAssets
//{
    /// <summary>
    /// The exact data for an AudioSource. This scriptable object class will be used to set the settings for the individual audio types. Documentation of AudioSource can be found on Unity docs website.
    /// </summary>
    [CreateAssetMenu]
    public class AudioSourceData : ScriptableObject
    {
        [Header("Mixer Group: ")]
        public AudioMixerGroup audioMixerGroup;

        [Header("Audiosource Settings (2D and 3D): ")]
        public bool mute = false;
        public bool bypassEffects = false;
        public bool bypassListenerEffects = false;
        public bool bypassReverbZones = false;
        public bool playOnAwake = true;
        public bool loop = false;
        [Range(0, 256)] public int priority = 128;                                  // Range: 0 to 256
        [Range(0, 1.0f)] public float volume = 1;                                   // Range: 0 to 1
        [Range(-3.0f, 3.0f)] public float pitch = 1;                                // Range: -3 to 3
        [Range(-1.0f, 1.0f)] public float stereoPan = 0;                            // Range: -1 to 1
        [Range(0, 1.0f)] public float spatialBlend = 0;                             // Range: 0 to 1
        [Range(0, 1.1f)] public float reverbZoneMix = 1;                            // Range: 0 to 1.1

        [Header("Audiosource Settings (3D only): ")]
        [Range(0, 5.0f)] public float dopplerLevel = 1;                             // Range: 0 to 5
        [Range(0, 360)] public int spread = 0;                                      // Range: 0 to 360
        public VolumeRolloff volumeRolloff = VolumeRolloff.LOGARITHMIC_ROLLOFF;
        public float minDistance = 1;
        public float maxDistance = 500;

        /// <summary>
        /// Set the audio source settings for the audio source prefab instantiated (only use this for all audio sources of audio type)
        /// </summary>
        /// <param name="source"></param>
        public void SetAudioSourcePrefabData(AudioSource source)
        {
            source.outputAudioMixerGroup = audioMixerGroup;
            source.mute = mute;
            source.bypassEffects = bypassEffects;
            source.bypassListenerEffects = bypassListenerEffects;
            source.bypassReverbZones = bypassReverbZones;
            source.playOnAwake = playOnAwake;
            source.loop = loop;
            source.priority = priority;
            source.volume = volume;
            source.pitch = pitch;
            source.panStereo = stereoPan;
            source.spatialBlend = spatialBlend;
            source.reverbZoneMix = reverbZoneMix;
            source.dopplerLevel = dopplerLevel;
            source.spread = spread;

            switch (volumeRolloff)
            {
                case VolumeRolloff.LOGARITHMIC_ROLLOFF:
                    source.rolloffMode = AudioRolloffMode.Logarithmic;
                    break;
                case VolumeRolloff.LINEAR_ROLLOFF:
                    source.rolloffMode = AudioRolloffMode.Linear;
                    break;
                case VolumeRolloff.CUSTOM_ROLLOFF:
                    source.rolloffMode = AudioRolloffMode.Custom;
                    break;
            }

            source.minDistance = minDistance;
            source.maxDistance = maxDistance;
        }
    }

    /// <summary>
    /// An enumeration to select the type of Volume Rolloff for 3D sound effects. 
    /// </summary>
    public enum VolumeRolloff
    {
        LOGARITHMIC_ROLLOFF,
        LINEAR_ROLLOFF,
        CUSTOM_ROLLOFF
    };
//}