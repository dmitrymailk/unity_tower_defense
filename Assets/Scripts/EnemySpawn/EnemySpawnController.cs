using Scripts.Assets;
using Scripts.Runtime;
using UnityEngine;

namespace Scripts.EnemySpawn
{
    public class EnemySpawnController : Icontroller
    {
        private SpawnWavesAsset m_SpawnWaves;
        private Grid m_Grid;

        private float m_SpawnStartTime;
        private float m_PassedTimeAtPreviousFrame = -1;
        
        public EnemySpawnController(SpawnWavesAsset mSpawnWaves, Grid mGrid)
        {
            m_SpawnWaves = mSpawnWaves;
            m_Grid = mGrid;
        }

        public void OnStart()
        {
            m_SpawnStartTime = Time.time;
        }

        public void OnStop()
        {
        }

        public void Tick()
        {
            float passedTime = Time.time - m_SpawnStartTime;
            float timeToSpawn = 0f;

            foreach (var wave in m_SpawnWaves.SpawnWaves)
            {
                timeToSpawn += wave.TimeBeforeStartWave;
                for (int i = 0; i < wave.Count; i++)
                {
                    if (passedTime >= timeToSpawn && m_PassedTimeAtPreviousFrame < timeToSpawn)
                    {
                        SpawnEnemy(wave.EnemyAsset);
                    }

                    if (i < wave.Count - 1)
                        timeToSpawn += wave.TimeBetweenSpawns;
                }
            }

            
            m_PassedTimeAtPreviousFrame = passedTime;
        }

        private void SpawnEnemy(EnemyAsset enemyAsset)
        {
            
        }
    }
}