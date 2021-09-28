﻿using Scripts.Enemy;
using UnityEngine;

namespace Scripts.Assets
{
    [CreateAssetMenu(menuName = "Assets/Enemy Asset", fileName = "Enemy Asset")]
    public class EnemyAsset : ScriptableObject
    {
        public int StartHealth;
        public EnemyView ViewPrefab;
    }
}