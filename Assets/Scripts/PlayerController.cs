using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public CharacterController cc;
    public float speed;
    public Animator PlayAnimator;
    public TextMeshProUGUI Health, ScoreText, ZoneText;
    private float health=100;
    private int score = 0;
    public ParticleSystem IceParticle;
    public GameObject LightA, LightB;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        LightA.SetActive(false);
        LightB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        Vector3 newpos = transform.right * X + transform.forward * Z;
        cc.SimpleMove(newpos * speed);

        PlayAnimator.SetFloat("Walk", Z);

        float healthvalue = Time.deltaTime;
        health=health - healthvalue;
        Health.text = health.ToString("00");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Water")
        {
            score++;
            collision.gameObject.SetActive(false);
            Instantiate(IceParticle, collision.collider.transform.position, Quaternion.identity);
            IceParticle.Play();
            ScoreText.text = score.ToString();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="ZoneA")
        {
            ZoneText.text = "A";
            LightA.SetActive(true);
            LightB.SetActive(false);
        }
        if (other.gameObject.tag == "ZoneB")
        {
            ZoneText.text = "B";
            LightA.SetActive(false);
            LightB.SetActive(true);
        }
        if (other.gameObject.tag == "ZoneC")
        {
            ZoneText.text = "C";
        }
        if (other.gameObject.tag == "ZoneD")
        {
            ZoneText.text = "D";
        }
    }
}
