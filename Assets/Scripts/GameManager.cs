using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int width = 9;

    [SerializeField]
    private int height = 14;

    [SerializeField]
    private Sprite[] types;

    [SerializeField]
    private GameObject nodePrefab;

    [SerializeField]
    private RectTransform gameBoard;

    private Node[,] board;

    void Start() {
        board = new Node[width, height];
        for (int i = 0; i < width; ++i) {
            for (int j =0; j<height; ++j) {
                int val = Random.Range(0, types.Length);
                if (i>1) {
                    if (board[i-1,j].getValue() == val) {
                        if (board[i-2,j].getValue() == val) {
                            while (val == board[i-2,j].getValue()) //redo
                                val = Random.Range(0, types.Length);
                        }
                    }
                }
                if (j>1) {
                    if (board[i,j-1].getValue() == val) {
                        if (board[i,j-2].getValue() == val){
                            while (val == board[i,j-2].getValue()) //redo
                                val = Random.Range(0, types.Length);
                        }
                    }
                }
                board[i,j] = new Node(i, j, val);
                GameObject inst = Instantiate(nodePrefab, gameBoard);
                NodePiece nodePiece = inst.GetComponent<NodePiece>();
                RectTransform rect = inst.GetComponent<RectTransform>();
                rect.anchoredPosition = new Vector2(32 + (64 * i), -32 - (64 * j));
                nodePiece.Initialize(val, new int[]{i, j}, types[val]);
                nodePiece.UpdateName();
            }
        }
    }

    void Update() {
        
    }


}
