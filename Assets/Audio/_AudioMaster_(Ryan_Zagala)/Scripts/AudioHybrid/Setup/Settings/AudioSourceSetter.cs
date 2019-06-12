using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Unity.Entities;
//using AudioHybrid.Enums;
//using AudioHybrid.Setup.Singletons;

/// <summary>
/// A namespace for the Settings of the AudioHybrid.Setup namespace
/// </summary>
//namespace AudioHybrid.Setup.Settings
//{
    /// <summary>
    /// A class to attach to every gameobject entity with an AudioSource in order to set the AudioSource values according to the respective AudioSource data 
    /// </summary>
    public class AudioSourceSetter : MonoBehaviour
    {
        public AudioSourceType audioSourceType;     // Select which AudioSourceType is going to have the respective setting changed

        private AudioManager audioManager;          // The AudioManager singleton that carries the AudioManagerData scriptable object asset
        private AudioSource audioSource;            // The AudioSource that will have its values changed


        void Awake()
        {
            //gameObject.AddComponent<ConvertToEntity>().ConversionMode = ConvertToEntity.Mode.ConvertAndInjectGameObject;
        }
        
        /// <summary>
        /// Start is called before the first frame update
        /// </summary>
        void Start()
        {
            audioManager = GameObject.FindObjectOfType<AudioManager>();                                                     // Initialize the audioManager to the only object of type in the current scene
            audioSource = GetComponent<AudioSource>();                                                                      // Initialize as the AudioSource that is attached to the same gameobject as this script

            switch(audioSourceType)                                                                                         // A switch statement to help identify the AudioSource type
            {
                case AudioSourceType.GAMEPLAY:                                                                              // If this AudioSource is used as Gameplay sound
                    audioManager.audioManagerData.Gameplay_AudioSourceData.SetAudioSourcePrefabData(audioSource);           // Set the audiosource data of the prefab as the same as the scriptable object Gameplay AudioSourceData settings
                    break;
                case AudioSourceType.UI:                                                                                    // If this AudioSource is used as UI sound
                    audioManager.audioManagerData.UI_AudioSourceData.SetAudioSourcePrefabData(audioSource);                 // Set the audiosource data of the prefab as the same as the scriptable object UI AudioSourceData settings
                    break;
                case AudioSourceType.AMBIENT:                                                                               // If this AudioSource is used as Ambient sound
                    audioManager.audioManagerData.Ambient_AudioSourceData.SetAudioSourcePrefabData(audioSource);            // Set the audiosource data of the prefab as the same as the scriptable object Ambient AudioSourceData settings
                    break;
                case AudioSourceType.VOICE_ACTING:                                                                          // If this AudioSource is used as Voice Acting sound
                    audioManager.audioManagerData.VoiceActing_AudioSourceData.SetAudioSourcePrefabData(audioSource);        // Set the audiosource data of the prefab as the same as the scriptable object VoiceActing AudioSourceData settings
                    break;
                case AudioSourceType.BACKGROUND_MUSIC:                                                                      // If this AudioSource is used as Background Music sound
                    audioManager.audioManagerData.BackgroundMusic_AudioSourceData.SetAudioSourcePrefabData(audioSource);    // Set the audiosource data of the prefab as the same as the scriptable object BackgroundMusic AudioSourceData settings
                    break;
            }
        }
    }
//}
