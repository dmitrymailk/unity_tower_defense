using UnityEngine;

namespace Scripts.Enemy
{
    public class EnemyView : MonoBehaviour
    {
        private EnemyData m_Data;
        public EnemyData Data => m_Data;

        public void AttachData(EnemyData data)
        {
            m_Data = data;
        }
    }
}