using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Sign : MonoBehaviour
{
    public GameObject dialogBox;
    public GameObject Koniec;
    public static bool GameIsPaused = false;
    public Text dialogText;
    public string dialog;
    public bool PlayerInRange;
    public string objectName;
    public bool npc_1, npc_2, npc_3, npc_4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && PlayerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);

            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
                string objectName = gameObject.name;
                if (objectName == "PT_Medieval_Male_Peasant_01_d")
                {

                    PlayerPrefs.SetInt("npc_1", 1);
                }
                if (objectName == "PT_Medieval_Female_Peasant_01_e")
                {
                    // npc_2 = true;
                    PlayerPrefs.SetInt("npc_2", 1);
                }
                if (objectName == "TurtleShell")
                {
                    // npc_3 = true;
                    PlayerPrefs.SetInt("npc_3", 1);
                }
                if (objectName == "TT_demo_male_B")
                {
                    // npc_4 = true;
                    PlayerPrefs.SetInt("npc_4", 1);
                }

            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerInRange = false;
            dialogBox.SetActive(false);
        }


        
    }
}
