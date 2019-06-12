using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public struct AudioSourcePrefabComponent : IComponentData
{
    // For Gameplay
    public UnitAudioSourceSpawnGameplayState unitAudioSourceSpawnGameplayState;

    // For VoiceActing
    public UnitAudioSourceSpawnVoiceActingState unitAudioSourceSpawnVoiceActingState;

    // Position
    public float3 spawnAudioSourcePrefabPosition;
}