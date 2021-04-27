using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NodePiece : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private int v;
    private int[] index;
    private Vector2 pos;
    private RectTransform rectTransform;
    private Image image;

    public void Initialize(int v, int[] i, Sprite sprite) {
        image = GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();

        this.v = v;
        this.index = i;
        image.sprite = sprite;
    }

    public void UpdateName() {
        transform.name = "Node [" + index[0] + ", " + index[1] + "]";
    }

    public int getValue() {
        return v;
    }

    public void OnPointerDown(PointerEventData data) {
        Debug.Log(transform.name+this.getValue());
    }

    public void OnPointerUp(PointerEventData data) {
        //throw new System.NotImplementedException();
    }
}
