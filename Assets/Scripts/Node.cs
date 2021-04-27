using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {
    private int x;
    private int y;
    private int v;

    public Node(int x, int y, int v) {
        this.x = x;
        this.y = y;
        this.v = v;
    }

    public void setValue (int v) {
        this.v = v;
    }

    public int getValue () {
        return v;
    }
}
