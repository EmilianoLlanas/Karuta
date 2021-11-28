using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private bool isMoving;
    private Vector3 origPos, targetPos;
    public float timetoMove = 0.2f;
    public Grid grid;
    // Start is called before the first frame update
    void Start()
    {

        Vector3Int cellPosition = grid.WorldToCell(transform.position);
        transform.position = grid.GetCellCenterWorld(cellPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !isMoving)
           StartCoroutine(MovePlayer(Vector3.up));

        if (Input.GetKey(KeyCode.A) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.left));

        if (Input.GetKey(KeyCode.S) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.down));

        if (Input.GetKey(KeyCode.D) && !isMoving)
            StartCoroutine(MovePlayer(Vector3.right));
    }

    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        origPos = transform.position;
        //ajustado para escala de grid 1,1, si se cambian las dimensiones de las grid cells, multiplicar direction por la nueva escala relativa a 1
        targetPos = origPos + direction; 

        while(elapsedTime < timetoMove)
        {
            transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timetoMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos;

        isMoving = false;
        
    }

}
