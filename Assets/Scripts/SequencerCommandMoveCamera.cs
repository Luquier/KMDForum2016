using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;
using PlayMaker;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{

    public class SequencerCommandMoveCamera : SequencerCommand
    {

        // Use this for initialization
        void Start()
        {

            var x = float.Parse(GetParameter(0));
            var y = float.Parse(GetParameter(1));
            var z = float.Parse(GetParameter(2));
            Camera.main.gameObject.transform.position = new Vector3(x, y, z);
            Stop();
        }
    }
}
