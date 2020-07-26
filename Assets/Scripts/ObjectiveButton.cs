using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveButton : MonoBehaviour
{
    public GameObject objectivePanel;
    public Text objective;
    private string message;

    private void Start() {
        OpenObjective();
    }
    public void SetMsg(string msg) {
        message = msg;
    }
    public void SetScore(int s, int mS){
        objective.text = s.ToString() + "/" + mS.ToString();
    }
    public void OpenObjective(){
        objectivePanel.GetComponent<ObjectivePanel>().SetObjective(message);
        Instantiate(objectivePanel, GameObject.FindWithTag("GUI").transform);
    }
}
