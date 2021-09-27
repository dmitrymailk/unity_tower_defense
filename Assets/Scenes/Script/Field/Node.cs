namespace Scenes.Script.Field
{
    public class Node
    {
        public Node NextNode;
        public bool IsOccupied;

        public float PathWeight;

        public void ResetWeight()
        {
            PathWeight = float.MaxValue;
        }
    }
}