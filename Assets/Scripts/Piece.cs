using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public int height;
    public EnumPieceColor PIECE_COLOR;
    public bool dent;
    public EnumPieceForm PIECE_FORM;
    public string prefabResorcesName;

    public int getHeight()
    {
        return this.height;
    }

    public EnumPieceColor getEnumPieceColor()
    {
        return this.PIECE_COLOR;
    }

    public bool isDent()
    {
        return this.dent;
    }

    public Piece(int height, EnumPieceColor PIECE_COLOR, bool dent, EnumPieceForm PIECE_FORM)
    {
        this.height = height;
        this.PIECE_COLOR = PIECE_COLOR;
        this.dent = dent;
        this.PIECE_FORM = PIECE_FORM;
    }

    public EnumPieceForm getEnumPieceForm()
    {
        return this.PIECE_FORM;
    }

    public string getPrefabResorcesName()
    {
        return this.prefabResorcesName;
    }
}
