using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Entities;
using Unity.Mathematics;
//using AudioHybrid.Setup.Singletons;

public class AudioSourcePrefabSpawnSystem : ComponentSystem
{
    private AudioManager audioManagerInstance;

    protected override void OnCreate()
    {
        audioManagerInstance = GameObject.FindObjectOfType<AudioManager>();
        //Debug.Log("Audio Manager Instance: " + audioManagerInstance);
    }

    protected override void OnUpdate()
    {
        if (SceneManager.GetActiveScene().name == "AudioManagerTesting")
        {
            #region Testing
            Entities.ForEach((ref AnimationsComponent data) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion
        }
        else
        {
            // Humans
            #region TagGryphon
            Entities.ForEach((ref AnimationsComponent data, ref TagGryphon tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing

                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    /*
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                        */
                }
            });
            #endregion

            #region TagKnight_Element_0
            Entities.ForEach((ref AnimationsComponent data, ref TagKnight tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Knight_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion

            #region TagLegionnaire_Element_1
            Entities.ForEach((ref AnimationsComponent data, ref TagLegionnaire tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Grunt_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion

            #region TagMarksman_Element_2
            Entities.ForEach((ref AnimationsComponent data, ref TagMarksman tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Marksman_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion

            #region TagPaladin_Element_3
            Entities.ForEach((ref AnimationsComponent data, ref TagPaladin tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion

            #region TagSiegeEngine_Element_4
            Entities.ForEach((ref AnimationsComponent data, ref TagSiegeEngine tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    /*
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Paladin_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                        */
                }
            });
            #endregion

            #region TagSpellslinger_Element_5
            Entities.ForEach((ref AnimationsComponent data, ref TagSpellslinger tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[6].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[6];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Human_Spellslinger_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion

            // Orcs
            #region TagBrute_Element_6
            Entities.ForEach((ref AnimationsComponent data, ref TagBrute tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[7].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[7];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion

            #region TagDemolisher_Element_7
            Entities.ForEach((ref AnimationsComponent data, ref TagDemolisher tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[8].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[8];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    /*
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Grunt_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                        */
                }
            });
            #endregion

            #region TagRaider_Element_8
            Entities.ForEach((ref AnimationsComponent data, ref TagRaider tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[9].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[9];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Raider_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion

            #region TagSlugger_Element_9
            Entities.ForEach((ref AnimationsComponent data, ref TagSlugger tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[10].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[10];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Slugger_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion

            #region TagWarlock_Element_10
            Entities.ForEach((ref AnimationsComponent data, ref TagWarlock tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[11].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[11];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlock_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion

            #region TagWarlord_Element_11
            Entities.ForEach((ref AnimationsComponent data, ref TagWarlord tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[12].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[12];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion

            #region TagWyvern_Element_12
            Entities.ForEach((ref AnimationsComponent data, ref TagWyvern tag) =>
            {
                float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
                GameObject audioSourcePrefab;
                AudioSource source;
                float audioClipLength;

                // For Gameplay
                switch (data.unitAudioSourceSpawnGameplayState)
                {
                    case UnitAudioSourceSpawnGameplayState.ATTACK_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_01_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_ATTACK_02_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_CHANNELING_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEATH_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_DEFEND_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_GETHIT_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_IDLE_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_RUN_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_SHIELDBASH_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_VICTORY_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[13].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_WALK_AudioSourcePrefabs[13];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    /*
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[1].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[1];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[2].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[2];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[3].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[3];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[4].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[4];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[5].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_Orc_Warlord_AudioSourcePrefabs[5];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                        */
                }
            });
            #endregion
        }
    }
}