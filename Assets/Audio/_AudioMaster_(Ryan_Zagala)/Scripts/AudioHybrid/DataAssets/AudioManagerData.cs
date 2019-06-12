using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//namespace AudioHybrid.DataAssets
//{
    /// <summary>
    /// A scriptable object class that will handle storing audio that contain the audioclips, audio source prefabs with the audio clips ready, and audio source data scriptable objects.
    /// </summary>
    [CreateAssetMenu]
    public class AudioManagerData : ScriptableObject
    {
        [Header("Gameplay Audio Settings: ")]
        public AudioClip[] Gameplay_AudioClips;
        public AudioSource[] Gameplay_AudioSourcePrefabs;
        public AudioSourceData Gameplay_AudioSourceData;

        [Header("UI Audio Settings: ")]
        public AudioClip[] UI_AudioClips;
        public AudioSource[] UI_AudioSourcePrefabs;
        public AudioSourceData UI_AudioSourceData;

        [Header("Ambient Audio Settings: ")]
        public AudioClip[] Ambient_AudioClips;
        public AudioSource[] Ambient_AudioSourcePrefabs;
        public AudioSourceData Ambient_AudioSourceData;

        [Header("Voice Acting Audio Settings: ")]
        public AudioClip[] VoiceActing_AudioClips;
        public AudioSource[] VoiceActing_AudioSourcePrefabs;
        public AudioSourceData VoiceActing_AudioSourceData;

        [Header("Background Music Audio Settings: ")]
        public AudioClip[] BackgroundMusic_AudioClips;
        public AudioSource[] BackgroundMusic_AudioSourcePrefabs;
        public AudioSourceData BackgroundMusic_AudioSourceData;
    }
//}