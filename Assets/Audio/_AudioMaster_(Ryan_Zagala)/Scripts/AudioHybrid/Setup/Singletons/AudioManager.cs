using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using AudioHybrid.DataAssets;

/// <summary>
/// The namespace for singletons for AudioHybrid
/// </summary>
//namespace AudioHybrid.Setup.Singletons
//{
    /// <summary>
    /// The class that is responsible for carrying the AudioManagerData in the Monobehavior for referencing prefabs and AudioSourceData
    /// </summary>
    public class AudioManager : MonoBehaviour
    {
        public AudioManagerData audioManagerData;   // The scriptable object data for an AudioManagerData

        /// <summary>
        /// Function that sets the gameplay volume level of Audiosource data to the parameter volume. This is only for UI to use for options menu.
        /// </summary>
        /// <param name="volume"></param>
        public void SetGameplayVolumeDataSettings(float volume)
        {
            audioManagerData.Gameplay_AudioSourceData.volume = volume;   // Set audio source data volume to the volume in the parameter
        }

        /// <summary>
        /// Function that sets the UI volume level of Audiosource data to the parameter volume. This is only for UI to use for options menu.
        /// </summary>
        /// <param name="volume"></param>
        public void SetUIVolumeDataSettings(float volume)
        {
            audioManagerData.UI_AudioSourceData.volume = volume;   // Set audio source data volume to the volume in the parameter
        }

        /// <summary>
        /// Function that sets the gameplay volume level of Audiosource data to the parameter volume. This is only for UI to use for options menu.
        /// </summary>
        /// <param name="volume"></param>
        public void SetAmbientVolumeDataSettings(float volume)
        {
            audioManagerData.Ambient_AudioSourceData.volume = volume;   // Set audio source data volume to the volume in the parameter
        }

        /// <summary>
        /// Function that sets the gameplay volume level of Audiosource data to the parameter volume. This is only for UI to use for options menu.
        /// </summary>
        /// <param name="volume"></param>
        public void SetVoiceActingVolumeDataSettings(float volume)
        {
            audioManagerData.VoiceActing_AudioSourceData.volume = volume;   // Set audio source data volume to the volume in the parameter
        }

        /// <summary>
        /// Function that sets the gameplay volume level of Audiosource data to the parameter volume. This is only for UI to use for options menu.
        /// </summary>
        /// <param name="volume"></param>
        public void SetBackgroundMusicVolumeDataSettings(float volume)
        {
            audioManagerData.BackgroundMusic_AudioSourceData.volume = volume;   // Set audio source data volume to the volume in the parameter
        }

        /// <summary>
        /// Function that will enable an gameplay audiosource prefab to instantiate at a specific desired frame of an animation once.
        /// </summary>
        /// <param name="element"></param>
        public void SpawnGameplayAudioSourcePrefabOnAnimationFrame(int element)
        {
            //Instantiate(audioManagerData.Gameplay_AudioSourcePrefabs[element], transform.position, Quaternion.identity);
            // ToDo: Still need a way to find position of the gameobject entity 
        }

        /// <summary>
        /// Function that will enable an voice acting audiosource prefab to instantiate at a specific desired frame of an animation once.
        /// </summary>
        /// <param name="element"></param>
        public void SpawnVoiceActingAudioSourcePrefabOnAnimationFrame(int element)
        {
            //Instantiate(audioManagerData.VoiceActing_AudioSourcePrefabs[element], transform.position, Quaternion.identity);
            // ToDo: Still need a way to find position of the gameobject entity
        }
    }
//}