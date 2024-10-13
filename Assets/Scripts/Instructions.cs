using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{

    public Canvas instr;
    public Canvas Home;

    // Start is called before the first frame update
    public void InstructionsFunction()
    {
        instr.enabled = true;
        Home.enabled = false;
    }
}
