using System.Collections.Generic;
using UnityEngine;

public class Rook : Piece
{


    public override List<Vector2Int> GetAvailableMoves(ref Piece[,] board, int tileCountX, int tileCountY)
    {
        List<Vector2Int> r = new List<Vector2Int>();

        // check if team is white or black, if it's white it goes +1, else -1
        //int direction = (team == 0) ? 1 : -1;
        

        // Front

        for (int i = currentY + 1; i < tileCountY; i++)
        {
            if(board[currentX,i] == null)
            {
                r.Add(new Vector2Int(currentX, i));
            }
            if(board[currentX,i] != null)
            {
                if(board[currentX, i].team != team)
                {
                    r.Add(new Vector2Int(currentX, i));
                }
                break;
            }
        }

        // Bottom
        for (int i = currentY - 1; i >= 0; i--)
        {
            if (board[currentX, i] == null)
            {
                r.Add(new Vector2Int(currentX, i));
            }
            if (board[currentX, i] != null)
            {
                if (board[currentX, i].team != team)
                {
                    r.Add(new Vector2Int(currentX, i));
                }
                break;
            }
        }
        // Right
        for(int i = currentX + 1; i <tileCountX; i++)
        {
            if(board[i, currentY]== null)
            {
                r.Add(new Vector2Int(i, currentY));
            }
            if(board[i, currentY] != null)
            {
                if (board[i, currentY].team != team)
                {
                    r.Add(new Vector2Int(i, currentY));
                }
                break;
            }
    
        }

        // Left
        for (int i = currentX - 1; i >= 0; i--)
        {
            if (board[i, currentY] == null)
            {
                r.Add(new Vector2Int(i, currentY));
            }
            if (board[i, currentY] != null)
            {
                if (board[i, currentY].team != team)
                {
                    r.Add(new Vector2Int(i, currentY));
                }
                break;
            }

        }

        return r;
    }
}
