using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Class responsible for dragging itself.
/// Using EventSystems interfaces.
/// </summary>
public class UIDragItem : MonoBehaviour
{
    // Reference to current item slot.
    public UIDropSlot currentSlot;
    private bool isdragged;

    void OnMouseDown()
    {
        isdragged = true;
        if(currentSlot!=null){
            currentSlot.currentItem = null;
            currentSlot = null;
            transform.localScale = transform.localScale * 3.0f;
        }

    }
        void OnMouseUp()
    {
        isdragged = false;
        Camera camera = FindObjectsOfType<Camera>()[0];
        Ray ray = camera.ScreenPointToRay ( Input.mousePosition);
     
         RaycastHit2D hit2D = Physics2D.GetRayIntersection ( ray );
     
         if ( hit2D.collider != null )
         {
             Debug.Log ( hit2D.collider.name );
        UIDropSlot slot = hit2D.collider.gameObject.GetComponent<UIDropSlot>();
        slot.currentItem = this;
        currentSlot = slot;
        transform.localScale = transform.localScale / 3.0f;
        }
    }

    public void Update()
    {
        if(isdragged)
        {
            Camera camera = FindObjectsOfType<Camera>()[0];
            Vector3 screenSpacePos3D = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z-camera.transform.position.z);
            Vector3 worldSpacePos = camera.ScreenToWorldPoint(screenSpacePos3D);
            transform.position = new Vector3(worldSpacePos.x, worldSpacePos.y, transform.position.z);
        }
    }
}