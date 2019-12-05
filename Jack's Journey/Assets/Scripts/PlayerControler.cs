using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRB;
    public GameObject projectile;
    public float jumpForce = 10;
    public float gravitymod = 10;
    public float speed = 5;
    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravitymod;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), projectile.transform.rotation);
        }
    }
}
