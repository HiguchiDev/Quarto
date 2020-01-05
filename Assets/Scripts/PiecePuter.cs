using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Piece
{
    public class PiecePuter : MonoBehaviour
    {

        private int x, y;
        private List<GameObject> pieceList = new List<GameObject>();

        void Start()
        {
            x = 1;
            y = 1;

            pieceList.Add(this.create("丸1_白"));
            pieceList.Add(this.create("丸1_茶"));
            pieceList.Add(this.create("丸1凹_白"));
            pieceList.Add(this.create("丸1凹_茶"));
            pieceList.Add(this.create("丸2_白"));
            pieceList.Add(this.create("丸2_茶"));
            pieceList.Add(this.create("丸2凹_白"));
            pieceList.Add(this.create("丸2凹_茶"));
            pieceList.Add(this.create("四角1_白"));
            pieceList.Add(this.create("四角1_茶"));
            pieceList.Add(this.create("四角1凹_白"));
            pieceList.Add(this.create("四角1凹_茶"));
            pieceList.Add(this.create("四角2_白"));
            pieceList.Add(this.create("四角2_茶"));
            pieceList.Add(this.create("四角2凹_白"));
            pieceList.Add(this.create("四角2凹_茶"));


        }

        private GameObject create(string pieceName)
        {   
            GameObject obj = (GameObject)Resources.Load(pieceName);

            GameObject createdObj = Instantiate(obj, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);

            Piece piece = createdObj.GetComponent<Piece>();

            if (x > 4)
            {
                x = 1;
                y++;
            }

            piece.xGamePosition = x++;


            piece.yGamePosition = y;


           

            string cloneName = pieceName + "(Clone)";

            Transform pieceTrans = GameObject.Find(cloneName).transform;

            Vector3 pos = pieceTrans.position;

            pos.x = PiecePositionGetter.getXPosition(piece);
            pos.y = PiecePositionGetter.getYPosition();
            pos.z = PiecePositionGetter.getZPosition(piece);

            pieceTrans.position = pos;

            return obj;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            { 

            }
        }

        public void put(PutParameter putParameter)
        {
            

            // Cubeプレハブを元に、インスタンスを生成、
            
        }
    }
}