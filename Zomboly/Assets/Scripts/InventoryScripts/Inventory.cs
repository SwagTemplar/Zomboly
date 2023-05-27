
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class to controll the inventory
public class Inventory: MonoBehaviour
{
    //this inventory stored in list and the equiped and count
    public List<Item> inventoryList = new List<Item>();
    public Item equipped;
    public int count = 0;
    public int radioObjects = 0;
    public int radioObjectsMax = 3;

    //function to add items to the inventory
    public void add(Item newitem)
    {
        isRadio(newitem);
        //adds item
        inventoryList.Add(newitem);
        //increments count
        count++;
    }

    //function to drop/remove items from inventory
    public Item dropItem(int i)
    {
        //gets the item
        Item itm = inventoryList[i];
        //removes the items from the inventory
        inventoryList.RemoveAt(i);
        //decreases count
        count--;
        //returns the removed item
        return itm;

    }

    //function to equip items
    public void equip(int i)
    {
        
        //sets the old item to not equiped
        if(equipped!= null)
        {
            equipped.equip = false;
        }
        
        //sets the equipped to the new equiped
        equipped = inventoryList[i];
        //sets equipped to true
        equipped.equip = true;
    }
    //return the equiped game object body
    public GameObject getEquipped(){
        return equipped.body;
    }
    public void isRadio(Item item){
        if(item.isRadio){
            radioObjects++;
            //calls a function that updates the menu or smth
            //update menu //menu.update(); 
        }
    }
    //checks if the user has all of the radio parts
    public bool checkRadio(){
        if (radioObjects >= radioObjectsMax){
            return true;
        }
        return false;
    }

}
