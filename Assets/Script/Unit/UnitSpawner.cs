using System;
using System.Collections;
using Script.Field;
using UnityEngine;

namespace Script.Unit
{
    public class UnitSpawner : MonoBehaviour
    {
        [SerializeField] 
        private GridMovementAgent m_MovementAgent;
        [SerializeField]
        private GridHolder m_GridHolder;

        private void Awake()
        {
            StartCoroutine(SpawnInitsCoroutine());
        }

        private IEnumerator SpawnInitsCoroutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);
                SpawnUnit();
            }
            // ReSharper disable once IteratorNeverReturns
        }

        private void SpawnUnit()
        {
            Node startNode = m_GridHolder.Grid.GetNode(m_GridHolder.StartCoordinate);
            Vector3 position = startNode.Position;
            GridMovementAgent  movementAgent = Instantiate(m_MovementAgent, position, Quaternion.identity);
            movementAgent.SetStartNode(startNode);
        }
    }
}