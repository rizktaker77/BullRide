using UnityEngine;
using System.Collections;

namespace Core.Game
{
    public class GameController : MonoBehaviour
    {
        public string State;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void StartGame()
        {
            State = "Running";
        }

    }
}