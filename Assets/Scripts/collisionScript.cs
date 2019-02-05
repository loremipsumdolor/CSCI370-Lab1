using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript : MonoBehaviour
{
    public GameObject FifteenBumperOneLight, FifteenBumperTwoLight, FiftyBumperLight, LeftFlipper, RightFlipper;
    public int points;
    public Rigidbody Sphere;
    public TextMesh PointsText;
    // Start is called before the first frame update
    void Start()
    {
        Sphere = GetComponent<Rigidbody>();
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "15Bumper1")
        {
            points += 15;
            PointsText.text = "Points: " + points.ToString();
            FifteenBumperOneLight.SetActive(true);
        } else if (collision.collider.name == "15Bumper2")
        {
            points += 15;
            PointsText.text = "Points: " + points.ToString();
            FifteenBumperTwoLight.SetActive(true);
        } else if (collision.collider.name == "50Bumper")
        {
            points += 50;
            PointsText.text = "Points: " + points.ToString();
            FiftyBumperLight.SetActive(true);
        } else if (collision.collider.tag == "Flipper" && Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            Sphere.AddForce(0f, 0f, 200f);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.name == "15Bumper1")
        {
            FifteenBumperOneLight.SetActive(false);
        }
        else if (collision.collider.name == "15Bumper2")
        {
            FifteenBumperTwoLight.SetActive(false);
        }
        else if (collision.collider.name == "50Bumper")
        {
            FiftyBumperLight.SetActive(false);
        }
    }
}
