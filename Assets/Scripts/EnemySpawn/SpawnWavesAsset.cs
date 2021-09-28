using System.Collections.Generic;
using Scripts.Assets;
using UnityEngine;

namespace Scripts.EnemySpawn
{
    
    [CreateAssetMenu(menuName = "Assets/Spawn Waves Asset", fileName = "Spawn Waves Asset")]
    public class SpawnWavesAsset : ScriptableObject
    {
        public SpawnWave[] SpawnWaves;
    }
}