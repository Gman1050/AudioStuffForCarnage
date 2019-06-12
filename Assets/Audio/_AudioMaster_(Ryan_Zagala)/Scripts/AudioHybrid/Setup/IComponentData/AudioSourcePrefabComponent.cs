using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;

public struct AudioSourcePrefabComponent : IComponentData
{
    #region OldImplementation
    /*
    // For All
    // For Gameplay
    public GeneralAudioSourceSpawnGameplayState audioSourceSpawnGeneralGameplayState;

    // Human
    // For Gameplay
    public HumanGruntAudioSourceSpawnGameplayState audioSourceSpawnHumanGruntGameplayState;
    public KnightAudioSourceSpawnGameplayState audioSourceSpawnKnightGameplayState;
    public MarksmenAudioSourceSpawnGameplayState audioSourceSpawnMarksmenGameplayState;
    public PaladinAudioSourceSpawnGameplayState audioSourceSpawnPaladinGameplayState;
    public SoldierAudioSourceSpawnGameplayState audioSourceSpawnSoldierGameplayState;
    public SpellslingerAudioSourceSpawnGameplayState audioSourceSpawnSpellslingerGameplayState;

    // Voice Acting Audio Stuff
    public HumanGruntAudioSourceSpawnVoiceActingState audioSourceSpawnHumanGruntVoiceActingState;
    public KnightAudioSourceSpawnVoiceActingState audioSourceSpawnKnightVoiceActingState;
    public MarksmenAudioSourceSpawnVoiceActingState audioSourceSpawnMarksmenVoiceActingState;
    public PaladinAudioSourceSpawnVoiceActingState audioSourceSpawnPaladinVoiceActingState;
    public SoldierAudioSourceSpawnVoiceActingState audioSourceSpawnSoldierVoiceActingState;
    public SpellslingerAudioSourceSpawnVoiceActingState audioSourceSpawnSpellslingerVoiceActingState;

    // Orcs
    // Gameplay Audio Stuff
    public OrcGruntAudioSourceSpawnGameplayState audioSourceSpawnOrcGruntGameplayState;
    public RaiderAudioSourceSpawnGameplayState audioSourceSpawnRaiderGameplayState;
    public SluggerAudioSourceSpawnGameplayState audioSourceSpawnSluggerGameplayState;
    public WarlockAudioSourceSpawnGameplayState audioSourceSpawnWarlockGameplayState;
    public WarlordAudioSourceSpawnGameplayState audioSourceSpawnWarlordGameplayState;

    // Voice Acting Audio Stuff
    public OrcGruntAudioSourceSpawnVoiceActingState audioSourceSpawnOrcGruntVoiceActingState;
    public RaiderAudioSourceSpawnVoiceActingState audioSourceSpawnRaiderVoiceActingState;
    public SluggerAudioSourceSpawnVoiceActingState audioSourceSpawnSluggerVoiceActingState;
    public WarlockAudioSourceSpawnVoiceActingState audioSourceSpawnWarlockVoiceActingState;
    public WarlordAudioSourceSpawnVoiceActingState audioSourceSpawnWarlordVoiceActingState;
    */
    #endregion

    // For Gameplay
    public UnitAudioSourceSpawnGameplayState unitAudioSourceSpawnGameplayState;

    // For VoiceActing
    public UnitAudioSourceSpawnVoiceActingState unitAudioSourceSpawnVoiceActingState;

    // Position
    public float3 spawnAudioSourcePrefabPosition;
}

/*
public enum UnitAudioSourceSpawnGameplayState
{
    NONE,
    IDLE,
    ATTACK_01,
    ATTACK_02,
    WALK,
    RUN,
    VICTORY,
    GETHIT,
    DEATH,
    DEFEND,
    SHIELDBASH,
    CHANNELING
};

public enum UnitAudioSourceSpawnVoiceActingState
{
    NONE,
    LINE_01,
    LINE_02,
    LINE_03,
    LINE_04,
    LINE_05,
    LINE_06
};
*/