using UnityEngine;

namespace Scripts.Runtime
{
    public class TestController : Icontroller
    {
        public void OnStart()
        {
            Debug.Log("start");
        }

        public void OnStop()
        {
            Debug.Log("stop");

        }

        public void Tick()
        {
            Debug.Log("tick");

        }
    }
}