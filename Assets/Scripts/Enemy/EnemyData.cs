namespace Scripts.Enemy
{
    public class EnemyData
    {
        private  EnemyView m_View;
        public EnemyView View => m_View;

        public void AttachView(EnemyView data)
        {
            m_View = data;
            m_View.AttachData(this);
        }
    }
}