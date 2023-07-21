using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();


    public CurrMoneyAmount CurrAmount;
    public Transform ItemContent;
    public GameObject InventoryItem;
    private Item selecteditem;
    public Camera mainCamera;
    public float depth = 10.0f;

    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void Remove(Item item)
    {
        Items.Remove(item);
    }

    public void ListItems()
    {

        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
            Button itemButton = obj.GetComponent<Button>();
            itemButton.onClick.AddListener(() => SelectItem(item));


        }


    }

    public void SelectItem(Item item)
    {
        selecteditem = item;
        Debug.Log(item.itemName);


    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (CurrAmount.amount >= selecteditem.value) 
            {
                CurrAmount.amount = CurrAmount.amount - selecteditem.value; 

                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = mainCamera.nearClipPlane;

                mousePosition.z += depth;

                Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);

                Instantiate(selecteditem.gameObject, worldPosition, Quaternion.identity);
            }

            
        }
    }


}