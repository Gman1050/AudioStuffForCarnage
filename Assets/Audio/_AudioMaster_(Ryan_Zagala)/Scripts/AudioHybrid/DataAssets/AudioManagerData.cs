using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class AudioManagerData : ScriptableObject
{
    [Header("Gameplay Audio Settings: ")]
    public AudioSource[] Gameplay_IDLE_AudioSourcePrefabs;
    public AudioSource[] Gameplay_WALK_AudioSourcePrefabs;
    public AudioSource[] Gameplay_RUN_AudioSourcePrefabs;
    public AudioSource[] Gameplay_ATTACK_01_AudioSourcePrefabs;
    public AudioSource[] Gameplay_ATTACK_02_AudioSourcePrefabs;
    public AudioSource[] Gameplay_VICTORY_AudioSourcePrefabs;
    public AudioSource[] Gameplay_GETHIT_AudioSourcePrefabs;
    public AudioSource[] Gameplay_DEATH_AudioSourcePrefabs;
    public AudioSource[] Gameplay_DEFEND_AudioSourcePrefabs;
    public AudioSource[] Gameplay_SHIELDBASH_AudioSourcePrefabs;
    public AudioSource[] Gameplay_CHANNELING_AudioSourcePrefabs;
    public AudioSourceData Gameplay_AudioSourceData;

    [Header("UI Audio Settings: ")]
    public AudioSource[] UI_AudioSourcePrefabs;
    public AudioSourceData UI_AudioSourceData;

    [Header("Ambient Audio Settings: ")]
    public AudioSource[] Ambient_AudioSourcePrefabs;
    public AudioSourceData Ambient_AudioSourceData;

    [Header("Voice Acting Audio Settings: ")]
    public AudioSourceData VoiceActing_AudioSourceData;
    [Header("Humans: ")]
    public AudioSource[] VoiceActing_Human_Grunt_AudioSourcePrefabs;
    public AudioSource[] VoiceActing_Human_Knight_AudioSourcePrefabs;
    public AudioSource[] VoiceActing_Human_Marksman_AudioSourcePrefabs;
    public AudioSource[] VoiceActing_Human_Paladin_AudioSourcePrefabs;
    public AudioSource[] VoiceActing_Human_Soldier_AudioSourcePrefabs;
    public AudioSource[] VoiceActing_Human_Spellslinger_AudioSourcePrefabs;
    [Header("Orcs: ")]
    public AudioSource[] VoiceActing_Orc_Grunt_AudioSourcePrefabs;
    public AudioSource[] VoiceActing_Orc_Raider_AudioSourcePrefabs;
    public AudioSource[] VoiceActing_Orc_Slugger_AudioSourcePrefabs;
    public AudioSource[] VoiceActing_Orc_Warlock_AudioSourcePrefabs;
    public AudioSource[] VoiceActing_Orc_Warlord_AudioSourcePrefabs;

    [Header("Background Music Audio Settings: ")]
    public AudioSource[] BackgroundMusic_AudioSourcePrefabs;
    public AudioSourceData BackgroundMusic_AudioSourceData;
}