using UnityEngine;  
using System.Collections;  
using UnityEngine.EventSystems;   
using UnityEngine.UI;
 
public class textHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
 
    public Text Text;
 
    public void OnPointerEnter(PointerEventData eventData)
    {
        Text.color = Color.red; //Or however you do your color
    }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        Text.color = Color.white; //Or however you do your color
    }
}
