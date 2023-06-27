using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject Telephone_Number;
    [SerializeField] GameObject Telephone;
    [SerializeField] GameObject Entrance_Key;

    [SerializeField] GameObject get_Telephone_Number;
    [SerializeField] GameObject get_Entrance_Key;
    [SerializeField] GameObject get_Rack_Key;
    [SerializeField] GameObject get_Telephone;

    [SerializeField] GameObject Rack_Text;
    [SerializeField] GameObject Bear_Text;
    [SerializeField] GameObject Cushion_Text;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ItemClick(string Button)
    {
        Debug.Log(Button);

        switch (Button)
        { 
            case "Book":
                Telephone_Number.SetActive(true);
                break;

            case "Telephone":
                Telephone.SetActive(true);
                break;

            case "Entrance_Key":
                Entrance_Key.SetActive(true);
                break;

            case "Rack":
                Rack_Text.SetActive(true);
                break;

            case "Bear":
                Bear_Text.SetActive(true);
                break;

            case "Cushion":
                Cushion_Text.SetActive(true);
                break;

            default:
                break;
        }
        //Telephone_Number.SetActive(true);
    }

    public void ItemClose(string Item)
    {

        switch(Item)
        {
            case "Book":
                Telephone_Number.SetActive(false);
                get_Telephone_Number.SetActive(true);
                break;

            case "Telephone":
                Telephone.SetActive(false);
                get_Telephone.SetActive(true);
                break;

            case "Entrance_Key":
                Entrance_Key.SetActive(false);
                get_Entrance_Key.SetActive(true);
                break;

            case "Rack":
                Rack_Text.SetActive(false);
                break;

            case "Bear":
                Bear_Text.SetActive(false);
                break;

            case "Cushion":
                Cushion_Text.SetActive(false);
                break;

            default:
                break;
        }

        /*
        Telephone_Number.SetActive(false);
        get_Telephone_Number.SetActive(true);
        */
    }

    public void GetItemClick(string select)
    {
        switch (select)
        {
            case "Book":
                get_Telephone_Number.GetComponent<Outline>().enabled = true;
                get_Entrance_Key.GetComponent<Outline>().enabled = false;
                get_Rack_Key.GetComponent<Outline>().enabled = false;
                get_Telephone.GetComponent<Outline>().enabled = false;
                break;

            case "Entrance_Key":
                get_Entrance_Key.GetComponent<Outline>().enabled = true;
                get_Telephone_Number.GetComponent<Outline>().enabled = false;
                get_Rack_Key.GetComponent<Outline>().enabled = false;
                get_Telephone.GetComponent<Outline>().enabled = false;
                break;

            case "Rack_Key":
                get_Rack_Key.GetComponent<Outline>().enabled = true;
                get_Entrance_Key.GetComponent<Outline>().enabled = false;
                get_Telephone_Number.GetComponent<Outline>().enabled = false;
                get_Telephone.GetComponent<Outline>().enabled = false;
                break;

            case "Telephone":
                get_Telephone.GetComponent<Outline>().enabled = true;
                get_Entrance_Key.GetComponent<Outline>().enabled = false;
                get_Telephone_Number.GetComponent<Outline>().enabled = false;
                get_Rack_Key.GetComponent<Outline>().enabled = false;
                break;

            default:
                    break;
        }
    }

}
