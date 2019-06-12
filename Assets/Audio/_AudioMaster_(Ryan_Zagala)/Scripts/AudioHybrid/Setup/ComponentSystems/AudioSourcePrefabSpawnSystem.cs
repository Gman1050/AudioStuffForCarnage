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
        #region OldEntitiesForEach
        /*
        Entities.ForEach((ref AudioSourcePrefabComponent data) =>
        {
            float3 spawnPostion = data.spawnAudioSourcePrefabPosition;
            GameObject audioSourcePrefab;
            AudioSource source;
            float audioClipLength;

            #region General Gameplay
            // Gameplay Audio Stuff
            switch (data.audioSourceSpawnGeneralGameplayState)
            {
                case GeneralAudioSourceSpawnGameplayState.SpawnAlertAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    PostUpdateCommands.CreateEntity();
                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    //MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnBowAttackAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnBuildingAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnCaptureAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnChannelingAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnDeathAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnDefendAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnDestroyBuildingAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnFreezingSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnGatheringAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnHoldPositionAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnMeteorSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnMovementAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnMovingDamageSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnPoisonSpeelAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnPrayingAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnSpawnAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                case GeneralAudioSourceSpawnGameplayState.SpawnSwordAttackAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnGeneralGameplayState = GeneralAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;

            }
            #endregion

            #region Human Grunt
            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnHumanGruntVoiceActingState)
            {
                case HumanGruntAudioSourceSpawnVoiceActingState.SpawnGrunt_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;         // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnHumanGruntVoiceActingState = HumanGruntAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case HumanGruntAudioSourceSpawnVoiceActingState.SpawnGrunt_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;         // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnHumanGruntVoiceActingState = HumanGruntAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case HumanGruntAudioSourceSpawnVoiceActingState.SpawnGrunt_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;         // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnHumanGruntVoiceActingState = HumanGruntAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case HumanGruntAudioSourceSpawnVoiceActingState.SpawnGrunt_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;         // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnHumanGruntVoiceActingState = HumanGruntAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
            }
            #endregion

            #region Knight
            // Gameplay Audio Stuff
            switch (data.audioSourceSpawnKnightGameplayState)
            {
                case KnightAudioSourceSpawnGameplayState.SpawnIncreaseAttackSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnKnightGameplayState = KnightAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case KnightAudioSourceSpawnGameplayState.SpawPlaceBannerAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnKnightGameplayState = KnightAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case KnightAudioSourceSpawnGameplayState.SpawnRageOfWarSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnKnightGameplayState = KnightAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                    
                    //case KnightAudioSourceSpawnGameplayState.SpawnUnknownSpellAudioSourcePrefab:
                    //   audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    //    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    //    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    //    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    //    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    //    data.audioSourceSpawnKnightGameplayState = KnightAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    //    break;
                   
            }
            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnKnightVoiceActingState)
            {
                case KnightAudioSourceSpawnVoiceActingState.SpawnKnight_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;         // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnKnightVoiceActingState = KnightAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case KnightAudioSourceSpawnVoiceActingState.SpawnKnight_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;         // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnKnightVoiceActingState = KnightAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case KnightAudioSourceSpawnVoiceActingState.SpawnKnight_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;         // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnKnightVoiceActingState = KnightAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case KnightAudioSourceSpawnVoiceActingState.SpawnKnight_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;         // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnKnightVoiceActingState = KnightAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case KnightAudioSourceSpawnVoiceActingState.SpawnKnight_Line4_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;         // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnKnightVoiceActingState = KnightAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case KnightAudioSourceSpawnVoiceActingState.SpawnKnight_Line5_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;         // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnKnightVoiceActingState = KnightAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
            }
            #endregion

            #region Marksmen
            // Gameplay Audio Stuff
            switch (data.audioSourceSpawnMarksmenGameplayState)
            {
                case MarksmenAudioSourceSpawnGameplayState.SpawnPlaceBannerAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnMarksmenGameplayState = MarksmenAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case MarksmenAudioSourceSpawnGameplayState.SpawnTeleportAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnMarksmenGameplayState = MarksmenAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case MarksmenAudioSourceSpawnGameplayState.SpawnMoraleBoostAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnMarksmenGameplayState = MarksmenAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case MarksmenAudioSourceSpawnGameplayState.SpawnClearFogOfWaterAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnMarksmenGameplayState = MarksmenAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
            }
            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnMarksmenVoiceActingState)
            {
                case MarksmenAudioSourceSpawnVoiceActingState.SpawnMarksman_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnMarksmenVoiceActingState = MarksmenAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case MarksmenAudioSourceSpawnVoiceActingState.SpawnMarksman_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnMarksmenVoiceActingState = MarksmenAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case MarksmenAudioSourceSpawnVoiceActingState.SpawnMarksman_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnMarksmenVoiceActingState = MarksmenAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case MarksmenAudioSourceSpawnVoiceActingState.SpawnMarksman_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnMarksmenVoiceActingState = MarksmenAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case MarksmenAudioSourceSpawnVoiceActingState.SpawnMarksman_Line4_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnMarksmenVoiceActingState = MarksmenAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case MarksmenAudioSourceSpawnVoiceActingState.SpawnMarksman_Line5_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnMarksmenVoiceActingState = MarksmenAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
            }
            #endregion

            #region Paladin
            // Gameplay Audio Stuff
            switch (data.audioSourceSpawnPaladinGameplayState)
            {
                case PaladinAudioSourceSpawnGameplayState.SpawnTargetedHealingSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnPaladinGameplayState = PaladinAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case PaladinAudioSourceSpawnGameplayState.SpawnForceFieldSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnPaladinGameplayState = PaladinAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;

                case PaladinAudioSourceSpawnGameplayState.SpawnAOEHealingSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnPaladinGameplayState = PaladinAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case PaladinAudioSourceSpawnGameplayState.SpawnGlobalHealingAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnPaladinGameplayState = PaladinAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
            }
            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnPaladinVoiceActingState)
            {
                case PaladinAudioSourceSpawnVoiceActingState.SpawnPaladin_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnPaladinVoiceActingState = PaladinAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case PaladinAudioSourceSpawnVoiceActingState.SpawnPaladin_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnPaladinVoiceActingState = PaladinAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case PaladinAudioSourceSpawnVoiceActingState.SpawnPaladin_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnPaladinVoiceActingState = PaladinAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case PaladinAudioSourceSpawnVoiceActingState.SpawnPaladin_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnPaladinVoiceActingState = PaladinAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case PaladinAudioSourceSpawnVoiceActingState.SpawnPaladin_Line4_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnPaladinVoiceActingState = PaladinAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case PaladinAudioSourceSpawnVoiceActingState.SpawnPaladin_Line5_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnPaladinVoiceActingState = PaladinAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
            }
            #endregion

            #region Soldier
            // Gameplay Audio Stuff

            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnSoldierVoiceActingState)
            {
                case SoldierAudioSourceSpawnVoiceActingState.SpawnSoldier_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSoldierVoiceActingState = SoldierAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Onc
                    break;

                case SoldierAudioSourceSpawnVoiceActingState.SpawnSoldier_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSoldierVoiceActingState = SoldierAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Onc                 
                    break;
                case SoldierAudioSourceSpawnVoiceActingState.SpawnSoldier_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSoldierVoiceActingState = SoldierAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Onc                 
                    break;
                case SoldierAudioSourceSpawnVoiceActingState.SpawnSoldier_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSoldierVoiceActingState = SoldierAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Onc                 
                    break;
            }
            #endregion

            #region Spellslinger
            // Gameplay Audio Stuff
            switch (data.audioSourceSpawnSpellslingerGameplayState)
            {
                case SpellslingerAudioSourceSpawnGameplayState.SpawnAOEHealingSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSpellslingerGameplayState = SpellslingerAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case SpellslingerAudioSourceSpawnGameplayState.SpawnForceFieldSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSpellslingerGameplayState = SpellslingerAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case SpellslingerAudioSourceSpawnGameplayState.SpawnGlobalHealingAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSpellslingerGameplayState = SpellslingerAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case SpellslingerAudioSourceSpawnGameplayState.SpawnTargetedHealingSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSpellslingerGameplayState = SpellslingerAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;

            }

            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnSpellslingerVoiceActingState)
            {
                case SpellslingerAudioSourceSpawnVoiceActingState.SpawnSpellslinger_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSpellslingerVoiceActingState = SpellslingerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case SpellslingerAudioSourceSpawnVoiceActingState.SpawnSpellslinger_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSpellslingerVoiceActingState = SpellslingerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case SpellslingerAudioSourceSpawnVoiceActingState.SpawnSpellslinger_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSpellslingerVoiceActingState = SpellslingerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case SpellslingerAudioSourceSpawnVoiceActingState.SpawnSpellslinger_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSpellslingerVoiceActingState = SpellslingerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case SpellslingerAudioSourceSpawnVoiceActingState.SpawnSpellslinger_Line4_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSpellslingerVoiceActingState = SpellslingerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case SpellslingerAudioSourceSpawnVoiceActingState.SpawnSpellslinger_Line5_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSpellslingerVoiceActingState = SpellslingerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
            }
            #endregion

            #region OrcGrunt
            // Gameplay Audio Stuff

            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnOrcGruntVoiceActingState)
            {
                case OrcGruntAudioSourceSpawnVoiceActingState.SpawnGrunt_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnOrcGruntVoiceActingState = OrcGruntAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case OrcGruntAudioSourceSpawnVoiceActingState.SpawnGrunt_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnOrcGruntVoiceActingState = OrcGruntAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case OrcGruntAudioSourceSpawnVoiceActingState.SpawnGrunt_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnOrcGruntVoiceActingState = OrcGruntAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case OrcGruntAudioSourceSpawnVoiceActingState.SpawnGrunt_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnOrcGruntVoiceActingState = OrcGruntAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case OrcGruntAudioSourceSpawnVoiceActingState.SpawnGrunt_Line4_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnOrcGruntVoiceActingState = OrcGruntAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
            }
            #endregion

            #region Raider
            // Gameplay Audio Stuff

            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnRaiderVoiceActingState)
            {
                case RaiderAudioSourceSpawnVoiceActingState.SpawnRaider_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnRaiderVoiceActingState = RaiderAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case RaiderAudioSourceSpawnVoiceActingState.SpawnRaider_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnRaiderVoiceActingState = RaiderAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case RaiderAudioSourceSpawnVoiceActingState.SpawnRaider_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnRaiderVoiceActingState = RaiderAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case RaiderAudioSourceSpawnVoiceActingState.SpawnRaider_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnRaiderVoiceActingState = RaiderAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case RaiderAudioSourceSpawnVoiceActingState.SpawnRaider_Line4_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnRaiderVoiceActingState = RaiderAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
            }
            #endregion

            #region Slugger
            // Gameplay Audio Stuff
            switch (data.audioSourceSpawnSluggerGameplayState)
            {
                case SluggerAudioSourceSpawnGameplayState.SpawnSpawnRobotsAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSluggerGameplayState = SluggerAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case SluggerAudioSourceSpawnGameplayState.SpawnFortifyAllyArmorAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSluggerGameplayState = SluggerAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case SluggerAudioSourceSpawnGameplayState.SpawnThrowWrenchAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSluggerGameplayState = SluggerAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case SluggerAudioSourceSpawnGameplayState.SpawnSpawnGiantRobotAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSluggerGameplayState = SluggerAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
            }

            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnSluggerVoiceActingState)
            {
                case SluggerAudioSourceSpawnVoiceActingState.SpawnSlugger_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSluggerVoiceActingState = SluggerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case SluggerAudioSourceSpawnVoiceActingState.SpawnSlugger_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSluggerVoiceActingState = SluggerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case SluggerAudioSourceSpawnVoiceActingState.SpawnSlugger_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSluggerVoiceActingState = SluggerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case SluggerAudioSourceSpawnVoiceActingState.SpawnSlugger_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSluggerVoiceActingState = SluggerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case SluggerAudioSourceSpawnVoiceActingState.SpawnSlugger_Line4_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSluggerVoiceActingState = SluggerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case SluggerAudioSourceSpawnVoiceActingState.SpawnSlugger_Line5_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnSluggerVoiceActingState = SluggerAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
            }
            #endregion

            #region Warlock
            // Gameplay Audio Stuff
            switch (data.audioSourceSpawnWarlockGameplayState)
            {
                case WarlockAudioSourceSpawnGameplayState.SpawnSpawnHelperEntityAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlockGameplayState = WarlockAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case WarlockAudioSourceSpawnGameplayState.SpawnDebuffSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlockGameplayState = WarlockAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case WarlockAudioSourceSpawnGameplayState.SpawnBounceSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlockGameplayState = WarlockAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
                case WarlockAudioSourceSpawnGameplayState.SpawnMindControlSpellAudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlockGameplayState = WarlockAudioSourceSpawnGameplayState.NONE;                        // Spawn Once
                    break;
            }
            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnWarlockVoiceActingState)
            {
                case WarlockAudioSourceSpawnVoiceActingState.SpawnWarlock_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlockVoiceActingState = WarlockAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case WarlockAudioSourceSpawnVoiceActingState.SpawnWarlock_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlockVoiceActingState = WarlockAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case WarlockAudioSourceSpawnVoiceActingState.SpawnWarlock_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlockVoiceActingState = WarlockAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case WarlockAudioSourceSpawnVoiceActingState.SpawnWarlock_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlockVoiceActingState = WarlockAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case WarlockAudioSourceSpawnVoiceActingState.SpawnWarlock_Line4_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlockVoiceActingState = WarlockAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
            }
            #endregion

            #region Warlord
            // Gameplay Audio Stuff

            // Voice Acting Audio Stuff
            switch (data.audioSourceSpawnWarlordVoiceActingState)
            {
                case WarlordAudioSourceSpawnVoiceActingState.SpawnWarlord_Line0_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlordVoiceActingState = WarlordAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case WarlordAudioSourceSpawnVoiceActingState.SpawnWarlord_Line1_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlordVoiceActingState = WarlordAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case WarlordAudioSourceSpawnVoiceActingState.SpawnWarlord_Line2_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlordVoiceActingState = WarlordAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case WarlordAudioSourceSpawnVoiceActingState.SpawnWarlord_Line3_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlordVoiceActingState = WarlordAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case WarlordAudioSourceSpawnVoiceActingState.SpawnWarlord_Line4_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlordVoiceActingState = WarlordAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
                case WarlordAudioSourceSpawnVoiceActingState.SpawnWarlord_Line5_AudioSourcePrefab:
                    audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    MonoBehaviour.Destroy(audioSourcePrefab, audioClipLength);                                                  // Destroy after the clip is done playing
                    data.audioSourceSpawnWarlordVoiceActingState = WarlordAudioSourceSpawnVoiceActingState.NONE;                        // Spawn Once
                    break;
            }
            #endregion
        });
        */
        #endregion

        if (SceneManager.GetActiveScene().name == "AudioManagerTest2")
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                        break;
                }

                // For VoiceActing
                switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                        source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                        audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                        MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                        data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                        break;
                }
            });
            #endregion
        }
        /*
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagKnight
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagLegionnaire
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagMarksman
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagPaladin
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagSiegeEngine
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagSpellslinger
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            // Orcs
            #region TagBrute
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagDemolisher
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagRaider
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagSlugger
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagWarlock
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagWarlord
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion

            #region TagWyvern
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
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.ATTACK_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.CHANNELING:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEATH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.DEFEND:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.GETHIT:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.IDLE:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.RUN:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.SHIELDBASH:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.VICTORY:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnGameplayState.WALK:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.Gameplay_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE;    // Spawn Once
                    break;
                }

            // For VoiceActing
            switch (data.unitAudioSourceSpawnVoiceActingState)
                {
                    case UnitAudioSourceSpawnVoiceActingState.LINE_01:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_02:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_03:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_04:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_05:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                    case UnitAudioSourceSpawnVoiceActingState.LINE_06:
                        audioSourcePrefab = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0].gameObject;        // Get the audioSourcePrefab to instantiate
                    source = audioManagerInstance.audioManagerData.VoiceActing_AudioSourcePrefabs[0];                              // Get the reference to audio source of that prefab
                    audioClipLength = source.clip.length;                                                                       // Get the length of the audio clip in the audio source

                    MonoBehaviour.Instantiate(audioSourcePrefab, spawnPostion, Quaternion.identity);                            // Instantiate prefab with spawnPosition and Quanternion.identity
                    data.unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.NONE;    // Spawn Once
                    break;
                }
            });
            #endregion
        }
        */
    }
}