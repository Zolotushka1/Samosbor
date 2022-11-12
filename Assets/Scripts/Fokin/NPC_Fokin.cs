<<<<<<< HEAD:Assets/Scripts/Fokin/NPC.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "NPC file", menuName="NPC Files Archive")]
public class NPC : ScriptableObject
{
    public string name;
    [TextArea(3, 15)]
    public string[] dialogue;
    [TextArea(3, 15)]
    public string[] playerDialogue;
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName= "NPC file", menuName="NPC Files Archive")]
public class NPC : ScriptableObject
{
    public string name;
    [TextArea(3, 30)]
    public string[] dialogue;
    [TextArea(3, 30)]
    public string[] playerDialogue;
}
>>>>>>> origin/cospero:Assets/Scripsts/NPC.cs
