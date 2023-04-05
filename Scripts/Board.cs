using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject boardPrefab;
    public GameObject[] piecePrefabs;
    public GameObject tilePrefab;

    void Start()
    {
        // Instantiate the board
        GameObject board = Instantiate(boardPrefab, Vector3.zero, Quaternion.identity);
        // Set the board to be the parent of the pieces
        Transform boardTransform = board.transform;

        // Instantiate the pieces for white and black
        GameObject[] whitePieces = new GameObject[16];
        GameObject[] blackPieces = new GameObject[16];


        // Instantiate and position white pawns
        for (int i = 0; i < 8; i++)
        {
            Vector3 position = new Vector3(i, 0, 6);
            whitePieces[i] = Instantiate(piecePrefabs[0], position, Quaternion.identity, boardTransform);
        }
        

        //The board prefab I am using is on the moves pieces via X and Z axis, Y axis is not involved whatsoever and the board has perfect positions for
        //the vectors to instantiate on tiles based off of whole numbers.

        // Instantiate and position white non-pawn pieces
        whitePieces[8] = Instantiate(piecePrefabs[1], new Vector3(0, 0, 7), Quaternion.identity, boardTransform); // Rook
        whitePieces[9] = Instantiate(piecePrefabs[2], new Vector3(1, 0, 7), Quaternion.identity, boardTransform); // Knight
        whitePieces[10] = Instantiate(piecePrefabs[3], new Vector3(2, 0, 7), Quaternion.identity, boardTransform); // Bishop
        whitePieces[11] = Instantiate(piecePrefabs[4], new Vector3(3, 0, 7), Quaternion.identity, boardTransform); // Queen
        whitePieces[12] = Instantiate(piecePrefabs[5], new Vector3(4, 0, 7), Quaternion.identity, boardTransform); // King
        whitePieces[13] = Instantiate(piecePrefabs[3], new Vector3(5, 0, 7), Quaternion.identity, boardTransform); // Bishop
        whitePieces[14] = Instantiate(piecePrefabs[2], new Vector3(6, 0, 7), Quaternion.identity, boardTransform); // Knight
        whitePieces[15] = Instantiate(piecePrefabs[1], new Vector3(7, 0, 7), Quaternion.identity, boardTransform); // Rook

        // Instantiate and position black pawns
        for (int i = 0; i < 8; i++)
        {
            Vector3 position = new Vector3(i, 0, 1);
            blackPieces[i] = Instantiate(piecePrefabs[6], position, Quaternion.identity, boardTransform);
        }

        // Instantiate and position black non-pawn pieces
        blackPieces[8] = Instantiate(piecePrefabs[7], new Vector3(0, 0, 0), Quaternion.identity, boardTransform); // Rook
        blackPieces[9] = Instantiate(piecePrefabs[8], new Vector3(1, 0, 0), Quaternion.identity, boardTransform); // Knight
        blackPieces[10] = Instantiate(piecePrefabs[9], new Vector3(2, 0, 0), Quaternion.identity, boardTransform); // Bishop
        blackPieces[11] = Instantiate(piecePrefabs[10], new Vector3(3, 0, 0), Quaternion.identity, boardTransform); // Queen
        blackPieces[12] = Instantiate(piecePrefabs[11], new Vector3(4, 0, 0), Quaternion.identity, boardTransform); // King
        blackPieces[13] = Instantiate(piecePrefabs[9], new Vector3(5, 0, 0), Quaternion.identity, boardTransform); //Bishop
        blackPieces[14] = Instantiate(piecePrefabs[8], new Vector3(6, 0, 0), Quaternion.identity, boardTransform); // Knight
        blackPieces[15] = Instantiate(piecePrefabs[7], new Vector3(7, 0, 0), Quaternion.identity, boardTransform); // Rook
    }

}