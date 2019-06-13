using System;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

[RequiresEntityConversion]
public class AddUnitSingletons : MonoBehaviour, IConvertGameObjectToEntity
{
    public float unitspeed = 50.0f;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        /*
        var select = new Selectable
        {
            SelectSize = 5.0f
        };
        dstManager.AddComponentData(entity, select);

        var targetinput = new Target
        {
            Destination = float3.zero,
            
            
        };
        dstManager.AddComponentData(entity, targetinput);

        var ratenum = new Rate
        {
            Value = 0,
            Cooldown = 1,
            Max = 20
        };
        dstManager.AddComponentData(entity, ratenum);

        var damagenum = new Damage
        {
            Max = 20,
            Min = 5,
            Type = AttackType.Slashing
        };
        dstManager.AddComponentData(entity, damagenum);

        var rangenum = new Range
        {
            MaxEngagement = 20.0f,
            Max = 5.0f,
            Min = 1.0f,
            Value = 0f
        };
        dstManager.AddComponentData(entity, rangenum);

        var hp = new Health
        {
            Max = 100,
            Value = 100,
            Type = ArmorType.Medium
        };
        dstManager.AddComponentData(entity, hp);


        var movementSpeed = new MovementSpeed
        {
            Value = unitspeed
        };
        dstManager.AddComponentData(entity, movementSpeed);

        var copyTransform = new CopyTransformToGameObject { };
        dstManager.AddComponentData(entity, copyTransform);

        var tag = new TagLegionnaire
        {
        };
        dstManager.AddComponentData(entity, tag);

        var tag2 = new TagMeleeUnit
        {

        };
        dstManager.AddComponentData(entity, tag2);
        */

        var animations = new AnimationsComponent
        {
            // For Gameplay
            unitAudioSourceSpawnGameplayState = UnitAudioSourceSpawnGameplayState.NONE,

            // For VoiceActing
            unitAudioSourceSpawnVoiceActingState = UnitAudioSourceSpawnVoiceActingState.LINE_01,

            // Position
            spawnAudioSourcePrefabPosition = new float3(0, 0, 0),
        };
        dstManager.AddComponentData(entity, animations);
    }
}
